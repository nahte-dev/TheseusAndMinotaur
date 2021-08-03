namespace TheseusAndMinotaur
{
    partial class GameViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBtn = new System.Windows.Forms.Button();
            this.levelListBox = new System.Windows.Forms.ListBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.controlsTBox = new System.Windows.Forms.TextBox();
            this.levelNumberLbl = new System.Windows.Forms.Label();
            this.levelNameHeading = new System.Windows.Forms.TextBox();
            this.levelNumberHeading = new System.Windows.Forms.TextBox();
            this.moveCountHeading = new System.Windows.Forms.TextBox();
            this.elapsedTimeBox = new System.Windows.Forms.TextBox();
            this.timerHeading = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2093, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.restartLevelToolStripMenuItem,
            this.selectLevelToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newToolStripMenuItem.Text = "&New Game";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // restartLevelToolStripMenuItem
            // 
            this.restartLevelToolStripMenuItem.Name = "restartLevelToolStripMenuItem";
            this.restartLevelToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.restartLevelToolStripMenuItem.Text = "Restart Level";
            this.restartLevelToolStripMenuItem.Click += new System.EventHandler(this.restartLevelToolStripMenuItem_Click);
            // 
            // selectLevelToolStripMenuItem
            // 
            this.selectLevelToolStripMenuItem.Name = "selectLevelToolStripMenuItem";
            this.selectLevelToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.selectLevelToolStripMenuItem.Text = "Select Level";
            this.selectLevelToolStripMenuItem.Click += new System.EventHandler(this.selectLevelToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitGameToolStripMenuItem.Text = "&Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.windowToolStripMenuItem.Text = "&View Controls";
            this.windowToolStripMenuItem.Click += new System.EventHandler(this.windowToolStripMenuItem_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(1536, 336);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 4;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Visible = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // levelListBox
            // 
            this.levelListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.levelListBox.FormattingEnabled = true;
            this.levelListBox.Location = new System.Drawing.Point(1536, 27);
            this.levelListBox.Name = "levelListBox";
            this.levelListBox.Size = new System.Drawing.Size(385, 303);
            this.levelListBox.TabIndex = 5;
            this.levelListBox.Visible = false;
            this.levelListBox.DoubleClick += new System.EventHandler(this.selectBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(1846, 336);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Visible = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // controlsTBox
            // 
            this.controlsTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.controlsTBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsTBox.Location = new System.Drawing.Point(1536, 754);
            this.controlsTBox.Multiline = true;
            this.controlsTBox.Name = "controlsTBox";
            this.controlsTBox.ReadOnly = true;
            this.controlsTBox.Size = new System.Drawing.Size(385, 165);
            this.controlsTBox.TabIndex = 7;
            this.controlsTBox.Visible = false;
            // 
            // levelNumberLbl
            // 
            this.levelNumberLbl.AutoSize = true;
            this.levelNumberLbl.Location = new System.Drawing.Point(12, 50);
            this.levelNumberLbl.Name = "levelNumberLbl";
            this.levelNumberLbl.Size = new System.Drawing.Size(0, 13);
            this.levelNumberLbl.TabIndex = 8;
            this.levelNumberLbl.Visible = false;
            // 
            // levelNameHeading
            // 
            this.levelNameHeading.BackColor = System.Drawing.SystemColors.Control;
            this.levelNameHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levelNameHeading.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelNameHeading.HideSelection = false;
            this.levelNameHeading.Location = new System.Drawing.Point(12, 65);
            this.levelNameHeading.Name = "levelNameHeading";
            this.levelNameHeading.ReadOnly = true;
            this.levelNameHeading.Size = new System.Drawing.Size(510, 25);
            this.levelNameHeading.TabIndex = 9;
            // 
            // levelNumberHeading
            // 
            this.levelNumberHeading.BackColor = System.Drawing.SystemColors.Control;
            this.levelNumberHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levelNumberHeading.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelNumberHeading.Location = new System.Drawing.Point(12, 29);
            this.levelNumberHeading.Name = "levelNumberHeading";
            this.levelNumberHeading.ReadOnly = true;
            this.levelNumberHeading.Size = new System.Drawing.Size(90, 25);
            this.levelNumberHeading.TabIndex = 10;
            // 
            // moveCountHeading
            // 
            this.moveCountHeading.BackColor = System.Drawing.SystemColors.Control;
            this.moveCountHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moveCountHeading.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveCountHeading.Location = new System.Drawing.Point(392, 31);
            this.moveCountHeading.Name = "moveCountHeading";
            this.moveCountHeading.ReadOnly = true;
            this.moveCountHeading.Size = new System.Drawing.Size(130, 22);
            this.moveCountHeading.TabIndex = 11;
            // 
            // elapsedTimeBox
            // 
            this.elapsedTimeBox.BackColor = System.Drawing.SystemColors.Control;
            this.elapsedTimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elapsedTimeBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTimeBox.Location = new System.Drawing.Point(556, 65);
            this.elapsedTimeBox.Name = "elapsedTimeBox";
            this.elapsedTimeBox.ReadOnly = true;
            this.elapsedTimeBox.Size = new System.Drawing.Size(135, 25);
            this.elapsedTimeBox.TabIndex = 12;
            // 
            // timerHeading
            // 
            this.timerHeading.BackColor = System.Drawing.SystemColors.Control;
            this.timerHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timerHeading.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerHeading.Location = new System.Drawing.Point(392, 66);
            this.timerHeading.Name = "timerHeading";
            this.timerHeading.ReadOnly = true;
            this.timerHeading.Size = new System.Drawing.Size(158, 25);
            this.timerHeading.TabIndex = 13;
            // 
            // GameViewForm
            // 
            this.ClientSize = new System.Drawing.Size(2093, 931);
            this.Controls.Add(this.timerHeading);
            this.Controls.Add(this.elapsedTimeBox);
            this.Controls.Add(this.moveCountHeading);
            this.Controls.Add(this.levelNumberHeading);
            this.Controls.Add(this.levelNameHeading);
            this.Controls.Add(this.levelNumberLbl);
            this.Controls.Add(this.controlsTBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.levelListBox);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameViewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectLevelToolStripMenuItem;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.ToolStripMenuItem restartLevelToolStripMenuItem;
        private System.Windows.Forms.ListBox levelListBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox controlsTBox;
        private System.Windows.Forms.Label levelNumberLbl;
        private System.Windows.Forms.TextBox levelNameHeading;
        private System.Windows.Forms.TextBox levelNumberHeading;
        private System.Windows.Forms.TextBox moveCountHeading;
        private System.Windows.Forms.TextBox elapsedTimeBox;
        private System.Windows.Forms.TextBox timerHeading;
    }
}
