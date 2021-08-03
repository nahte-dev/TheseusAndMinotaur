using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheseusAndMinotaur
{
    public partial class Popup : Form
    {
        private Controller controller;

        public Popup()
        {
            InitializeComponent();
        }

        public void SetController(Controller theController)
        {
            this.controller = theController;
        }

        public void DrawConditionMsg(string condition)
        {
            winConditionTBox.Text = condition;
        }

        private void option1Btn_Click(object sender, EventArgs e)
        {
            if (controller.TheseusWins())
            {
                controller.QuitGame();
            }
            else if (controller.MinotaurWins())
            {
                controller.QuitGame();
            }
        }

        private void option2Btn_Click(object sender, EventArgs e)
        {
            if (controller.TheseusWins())
            {
                controller.LoadNextLevel();
                Close();
            }
            else if (controller.MinotaurWins())
            {
                controller.RestartLevel();
                Close();
            }
        }

        private void Popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
