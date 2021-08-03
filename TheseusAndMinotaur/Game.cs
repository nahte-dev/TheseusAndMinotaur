using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheseusAndMinotaur
{
    public enum Moves
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
        PAUSE,
    }

    public class Game : ILevelHolder, IMoveableHolder, IMoveable
    {
        public List<Level> allLevels = new List<Level>();

        public int LevelWidth { get; set; }
        public int LevelHeight { get; set; }
        public string CurrentLevelName { get; set; } = "No levels loaded";

        // Implementing IMoveableHolder members
        public int MinotaurRow { get; set; }
        public int MinotaurColumn { get; set; }
        public int TheseusRow { get; set; }
        public int TheseusColumn { get; set; }
        public int MoveCount { get; set; }

        // Implementing IMoveable members
        public int Row { get; set; }
        public int Column { get; set; }

        // Declaring level array
        public Square[,] level;

        // Delete if unused
        private Controller controller;

        public void SetController(Controller theController)
        {
            controller = theController;
        }

        public void MoveTheseus(Moves direction)
        {
            switch (direction)
            {
                case Moves.UP:
                    GoUp();
                    break;
                case Moves.DOWN:
                    GoDown();
                    break;
                case Moves.LEFT:
                    GoLeft();
                    break;
                case Moves.RIGHT:
                    GoRight();
                    break;
                case Moves.PAUSE:
                    break;
                default:
                    break;
            }
            MoveMinotaur();
            MoveMinotaur();

            MoveCount++;
        }

        public void ProcessMovement(int rowMove, int colMove)
        {
            WhatIsAt(TheseusRow, TheseusColumn).Theseus = false;
            TheseusRow += rowMove;
            TheseusColumn += colMove;
            WhatIsAt(TheseusRow, TheseusColumn).Theseus = true;
        }

        public void ProcessMinotaurMovement(int rowMove, int colMove)
        {
            WhatIsAt(MinotaurRow, MinotaurColumn).Minotaur = false;
            MinotaurRow += rowMove;
            MinotaurColumn += colMove;
            WhatIsAt(MinotaurRow, MinotaurColumn).Minotaur = true;
        }

        public void GoUp()
        {
            if (!WhatIsAt(TheseusRow, TheseusColumn).Top && !WhatIsAt(TheseusRow - 1, TheseusColumn).Bottom)
            {
                ProcessMovement(-1, 0);
            }
        }

        public void GoDown()
        {
            if (!WhatIsAt(TheseusRow, TheseusColumn).Bottom && !WhatIsAt(TheseusRow + 1, TheseusColumn).Top)
            {
                ProcessMovement(+1, 0);
            }
        }

        public void GoLeft()
        {
            if (!WhatIsAt(TheseusRow, TheseusColumn).Left && !WhatIsAt(TheseusRow, TheseusColumn - 1).Right)
            {
                ProcessMovement(0, -1);
            }
        }

        public void GoRight()
        {
            if (!WhatIsAt(TheseusRow, TheseusColumn).Right && !WhatIsAt(TheseusRow, TheseusColumn + 1).Left)
            {
                ProcessMovement(0, +1);
            }
        }

        public void AddLevel(string name, int width, int height, string data)
        {
            Level newLevel = new Level();

            newLevel.Name = name;
            newLevel.Width = width;
            newLevel.Height = height;
            newLevel.Data = data;

            allLevels.Add(newLevel);
        }

        public void LoadLevel(Level loadedLevel)
        {
            level = new Square[loadedLevel.Height, loadedLevel.Width];

            LevelWidth = loadedLevel.Width;
            LevelHeight = loadedLevel.Height;
            CurrentLevelName = loadedLevel.Name;

            string[] squareData = loadedLevel.Data.Split(' ');
            int wallIndex = 3;

            bool topValue = false;
            bool leftValue = false;
            bool bottomValue = false;
            bool rightValue = false;

            bool theseusValue = false;
            bool minotaurValue = false;
            bool exitValue = false;

            for (int i = 0; i < loadedLevel.Height; i++)
            {
                for (int j = 0; j < loadedLevel.Width; j++)
                {
                    // Wall data order: TOP RIGHT BOTTOM LEFT
                    var wallData = squareData[wallIndex];
                    int[] wallPosition = { Convert.ToInt32(wallData.Substring(0, 1)), Convert.ToInt32(wallData.Substring(1, 1)),
                        Convert.ToInt32(wallData.Substring(2, 1)), Convert.ToInt32(wallData.Substring(3, 1)) };

                    topValue = Convert.ToBoolean(wallPosition[0]);
                    rightValue = Convert.ToBoolean(wallPosition[1]);
                    bottomValue = Convert.ToBoolean(wallPosition[2]);
                    leftValue = Convert.ToBoolean(wallPosition[3]);

                    level[i, j] = new Square(topValue, leftValue, bottomValue, rightValue, theseusValue, minotaurValue,
                        exitValue);

                    wallIndex++;
                }
            }

            int[] minotaurData = { Convert.ToInt32(loadedLevel.Data.Substring(0, 2)), Convert.ToInt32(loadedLevel.Data.Substring(2, 2)) };
            MinotaurRow = minotaurData[0];
            MinotaurColumn = minotaurData[1];

            int[] theseusData = { Convert.ToInt32(loadedLevel.Data.Substring(5, 2)), Convert.ToInt32(loadedLevel.Data.Substring(7, 2)) };
            TheseusRow = theseusData[0];
            TheseusColumn = theseusData[1];

            int[] exitData = { Convert.ToInt32(loadedLevel.Data.Substring(10, 2)), Convert.ToInt32(loadedLevel.Data.Substring(12, 2)) };

            WhatIsAt(TheseusRow, TheseusColumn).Theseus = true;
            WhatIsAt(MinotaurRow, MinotaurColumn).Minotaur = true;
            WhatIsAt(exitData[0], exitData[1]).Exit = true;

            MoveCount = 0;
        }

        public void RestartLevel()
        {
            int levelToRestart = allLevels.FindIndex(i => i.Name == CurrentLevelName);
            LoadLevel(allLevels[levelToRestart]);
        }

        public void LoadNextLevel()
        {
            int curLevelIndex = allLevels.FindIndex(i => i.Name == CurrentLevelName);
            int nextLevel = curLevelIndex + 1;

            LoadLevel(allLevels[nextLevel]);
        }

        public bool HasMinotaurWon()
        {
            if (WhatIsAt(MinotaurRow, MinotaurColumn) == WhatIsAt(TheseusRow, TheseusColumn))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasTheseusWon()
        {
            if (WhatIsAt(TheseusRow, TheseusColumn).Theseus == WhatIsAt(TheseusRow, TheseusColumn).Exit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MoveMinotaur()
        {
            bool canMoveVertically = false;

            // Deciding if horizontal movement
            if (MinotaurColumn > TheseusColumn)
            {
                if (!WhatIsAt(MinotaurRow, MinotaurColumn).Left && !WhatIsAt(MinotaurRow, MinotaurColumn - 1).Right)
                {
                    ProcessMinotaurMovement(0, -1);
                }
            }
            else if (MinotaurColumn < TheseusColumn)
            {
                if (!WhatIsAt(MinotaurRow, MinotaurColumn).Right && !WhatIsAt(MinotaurRow, MinotaurColumn + 1).Left)
                {
                    ProcessMinotaurMovement(0, +1);
                }
            }
            else
            {
                canMoveVertically = true;
            }

            // If minotaur can't move horizontally, attempts to move vertically using previously
            // defined flag variable
            if (canMoveVertically)
            {
                if (MinotaurRow > TheseusRow)
                {
                    if (!WhatIsAt(MinotaurRow, MinotaurColumn).Top && !WhatIsAt(MinotaurRow - 1, MinotaurColumn).Bottom)
                    {
                        ProcessMinotaurMovement(-1, 0);
                    }
                }
                else if (MinotaurRow < TheseusRow)
                {
                    if (!WhatIsAt(MinotaurRow, MinotaurColumn).Bottom && !WhatIsAt(MinotaurRow + 1, MinotaurColumn).Top)
                    {
                        ProcessMinotaurMovement(+1, 0);
                    }
                }
            }
        }

        public Square WhatIsAt(int row, int col)
        {
            return level[row, col];
        }
    }

    public class Square
    {
        // Grouping square variables
        public bool Minotaur { get; set; }
        public bool Theseus { get; set; }
        public bool Exit { get; set; }

        public bool Top;
        public bool Left;
        public bool Bottom;
        public bool Right;

        // Contructor
        public Square(bool top, bool left, bool bottom, bool right, bool hasMinotaur, bool hasTheseus, bool isExit)
        {
            this.Top = top;
            this.Left = left;
            this.Bottom = bottom;
            this.Right = right;
            this.Minotaur = hasMinotaur;
            this.Theseus = hasTheseus;
            this.Exit = isExit;
        }
    }

    public class Level : ILevel
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Data { get; set; }
    }
}

