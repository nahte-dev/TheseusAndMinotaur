namespace TheseusAndMinotaur
{
    partial class Popup
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
            this.winConditionTBox = new System.Windows.Forms.TextBox();
            this.option1Btn = new System.Windows.Forms.Button();
            this.option2Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winConditionTBox
            // 
            this.winConditionTBox.BackColor = System.Drawing.SystemColors.Control;
            this.winConditionTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.winConditionTBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winConditionTBox.Location = new System.Drawing.Point(12, 68);
            this.winConditionTBox.Multiline = true;
            this.winConditionTBox.Name = "winConditionTBox";
            this.winConditionTBox.ReadOnly = true;
            this.winConditionTBox.Size = new System.Drawing.Size(360, 107);
            this.winConditionTBox.TabIndex = 1;
            this.winConditionTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // option1Btn
            // 
            this.option1Btn.Location = new System.Drawing.Point(63, 176);
            this.option1Btn.Name = "option1Btn";
            this.option1Btn.Size = new System.Drawing.Size(75, 23);
            this.option1Btn.TabIndex = 2;
            this.option1Btn.Text = "button1";
            this.option1Btn.UseVisualStyleBackColor = true;
            this.option1Btn.Click += new System.EventHandler(this.option1Btn_Click);
            // 
            // option2Btn
            // 
            this.option2Btn.Location = new System.Drawing.Point(247, 176);
            this.option2Btn.Name = "option2Btn";
            this.option2Btn.Size = new System.Drawing.Size(75, 23);
            this.option2Btn.TabIndex = 3;
            this.option2Btn.Text = "button2";
            this.option2Btn.UseVisualStyleBackColor = true;
            this.option2Btn.Click += new System.EventHandler(this.option2Btn_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.option2Btn);
            this.Controls.Add(this.option1Btn);
            this.Controls.Add(this.winConditionTBox);
            this.Name = "Popup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Popup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox winConditionTBox;
        public System.Windows.Forms.Button option1Btn;
        public System.Windows.Forms.Button option2Btn;
    }
}

