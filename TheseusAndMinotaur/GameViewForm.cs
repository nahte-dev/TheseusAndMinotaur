using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Versioning;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;

namespace TheseusAndMinotaur
{
    public partial class GameViewForm : Form
    {
        private Controller controller;
        private Popup dialogForm;

        const int startView_Y = 100, startView_X = 100;
        const int squareWidth = 200;

        Rectangle theseusBox = new Rectangle();
        Rectangle minotaurBox = new Rectangle();
        Rectangle exitBox = new Rectangle();
        Rectangle moveCountBox = new Rectangle();

        Stopwatch gameTimer = new Stopwatch();

        public GameViewForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(GameViewForm_KeyPress);
        }

        // Sets correct controller object
        public void SetController(Controller theController)
        {
            controller = theController;
        }

        // Allows main form to access popup form members/methods
        // for win conditions 
        public void SetChildForm(Popup theDialogForm)
        {
            this.dialogForm = theDialogForm;
        }

        private void GameViewForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                    controller.MoveInput(Moves.UP);
                    break;
                case 's':
                    controller.MoveInput(Moves.DOWN);
                    break;
                case 'a':
                    controller.MoveInput(Moves.LEFT);
                    break;
                case 'd':
                    controller.MoveInput(Moves.RIGHT);
                    break;
                case 'f':
                    controller.MoveInput(Moves.PAUSE);
                    break;
                default:
                    break;
            }
            // For every key press,  move count and sprites are updated
            // and the program checks for a win condition
            UpdateMoveCount();
            UpdateSprites();
            WinCondition();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.LoadLevel(controller.allLevels[0]);
            StartTimer();
        }

        private void restartLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.RestartLevel();
        }

        private void selectLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            levelListBox.Visible = true;
            closeBtn.Visible = true;
            selectBtn.Visible = true;
            CreateLevelList();
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.QuitGame();
        }

        public void DisplayLoadedLevel()
        {
            DisplayHeadings();
            DrawMoveCount();
            DrawLevel();
            DrawSprites();
        }

        public void DrawLevel()
        {
            Graphics g = CreateGraphics();
            Pen wallPen = new Pen(Color.Black, 3);

            for (int row = 0; row < controller.height; row++)
            {
                for (int col = 0; col < controller.width; col++)
                {
                    Square currentSquare = controller.GetSquare(row, col);

                    Point topLeft = new Point(startView_X + col * squareWidth, startView_Y + row * squareWidth);
                    Point topRight = new Point(startView_X + (col + 1) * squareWidth, startView_Y + row * squareWidth);
                    Point bottomLeft = new Point(startView_X + col * squareWidth, startView_Y + (row + 1) * squareWidth);
                    Point bottomRight = new Point(startView_X + (col + 1) * squareWidth, startView_Y + (row + 1) * squareWidth);

                    Image exitSprite = Image.FromFile(@"D:\GitHub Repos\C#\TheseusAndMinotaur\img\exit.png");

                    if (currentSquare.Top)
                    {
                        g.DrawLine(wallPen, topLeft, topRight);
                    }

                    if (currentSquare.Bottom)
                    {
                        g.DrawLine(wallPen, bottomLeft, bottomRight);
                    }

                    if (currentSquare.Left)
                    {
                        g.DrawLine(wallPen, topLeft, bottomLeft);
                    }

                    if (currentSquare.Right)
                    {
                        g.DrawLine(wallPen, topRight, bottomRight);
                    }

                    if (currentSquare.Exit)
                    {
                        Size spriteSize = new Size(50, 50);
                        exitBox.Size = spriteSize;
                        exitBox.Location = topLeft;
                        exitBox.Offset(squareWidth / 3, squareWidth / 3);

                        g.DrawImage(exitSprite, exitBox);
                    }
                }
            }
        }

        public void DrawSprites()
        {
            Graphics g = CreateGraphics();

            for (int row = 0; row < controller.height; row++)
            {
                for (int col = 0; col < controller.width; col++)
                {
                    Square currentSquare = controller.GetSquare(row, col);
                    Point topLeft = new Point(startView_X + col * squareWidth, startView_Y + row * squareWidth);

                    Image theseusImg = Image.FromFile(@"D:\GitHub Repos\C#\TheseusAndMinotaur\img\theseus.png");
                    Image minotaurImg = Image.FromFile(@"D:\GitHub Repos\C#\TheseusAndMinotaur\img\minotaur.png");
                    

                    if (currentSquare.Theseus)
                    {
                        Size spriteSize = new Size(75, 75);
                        theseusBox.Size = spriteSize;
                        theseusBox.Location = topLeft;
                        theseusBox.Offset(squareWidth / 3, squareWidth / 4);

                        g.DrawImage(theseusImg, theseusBox);
                    }

                    if (currentSquare.Minotaur)
                    {
                        Size spriteSize = new Size(75, 75);
                        minotaurBox.Size = spriteSize;
                        minotaurBox.Location = topLeft;
                        minotaurBox.Offset(squareWidth / 3, squareWidth / 4);

                        g.DrawImage(minotaurImg, minotaurBox);
                    }
                    // Memory exception thrown unless images disposed
                    theseusImg.Dispose();
                    minotaurImg.Dispose();
                }
            }
            g.Dispose();
        }

        public void UpdateSprites()
        {
            Invalidate(theseusBox); 
            Invalidate(minotaurBox); 
            Update();

            DrawSprites();
        }

        public void UpdateMoveCount()
        {
            controller.ImportLevelData();
            Invalidate(moveCountBox);
            Update();

            DrawMoveCount();
        }

        public void DisplayHeadings()
        {
            string curLevelName = controller.currentLevelName;

            int levelIndex = controller.allLevels.FindIndex(a => a.Name == curLevelName);
            int levelHeading = levelIndex + 1;

            levelNumberHeading.Text = $"Level {levelHeading}";
            levelNameHeading.Text = curLevelName;
            moveCountHeading.Text = "Move Count: ";
            timerHeading.Text = "Elapsed Time: ";
        }

        public void DrawMoveCount()
        {
            Graphics g = CreateGraphics();

            int moveCount = controller.moveCount;
            
            Font drawFont = new Font("Arial", 16);
            Point pos1 = new Point(520, 30);
            Size size = new Size(30, 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            moveCountBox.Location = pos1;
            moveCountBox.Size = size;

            g.DrawString(moveCount.ToString(), drawFont, drawBrush, moveCountBox);

            g.Dispose();
        }

        public void CreateLevelList()
        {
            levelListBox.Items.Clear();

            foreach (Level level in controller.allLevels)
            {
                levelListBox.Items.Add(level.Name);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            levelListBox.Visible = false;
            closeBtn.Visible = false;
            selectBtn.Visible = false;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            int levelIdx = levelListBox.SelectedIndex;

            controller.LoadLevel(controller.allLevels[levelIdx]);
            DisplayLoadedLevel();

            levelListBox.Visible = false;
            closeBtn.Visible = false;
            selectBtn.Visible = false;
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!controlsTBox.Visible)
            {
                controlsTBox.Visible = true;
            }
            else
            {
                controlsTBox.Visible = false;
            }

            controlsTBox.Text = "W - Move Up \r\n" +
                "S - Move Down \r\n" +
                "A - Move Left \r\n" +
                "D - Move Right \r\n" +
                "F - Pause";
        }

        public void WinCondition()
        {
            string lostMessage = "Oh no! You were eaten by the Minotaur!";
            string winMessage = "Congratulations! You exited the level!";

            if (controller.TheseusWins())
            {
                dialogForm.Text = "Congratulations!";
                dialogForm.Visible = true;
                dialogForm.option1Btn.Text = "Exit Game";
                dialogForm.option2Btn.Text = "Next Level";

                dialogForm.DrawConditionMsg(winMessage);

                Invalidate(theseusBox);
                Invalidate(minotaurBox);

                StopTimer();
            }
            else if (controller.MinotaurWins())
            {
                dialogForm.Text = "Game Over!";
                dialogForm.Visible = true;
                dialogForm.option1Btn.Text = "Exit Game";
                dialogForm.option2Btn.Text = "Retry";

                dialogForm.DrawConditionMsg(lostMessage);

                Invalidate(theseusBox);
                Invalidate(minotaurBox);

                StopTimer();
            }
        }

        public void DisplayTimer()
        {
            TimeSpan ts = gameTimer.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            elapsedTimeBox.Text = elapsedTime;
            
        }

        public void StartTimer()
        {
            gameTimer.Start();
        }

        public void StopTimer()
        {
            gameTimer.Stop();
            DisplayTimer();
        }

        public void ResetTimer()
        {
            gameTimer.Reset();
            DisplayTimer();
        }
    }
}
