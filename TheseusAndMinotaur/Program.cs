using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheseusAndMinotaur
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GameViewForm frmMain = new GameViewForm();
            Game game = new Game();
            Popup pop = new Popup();
            // Controller instantiated with three classes
            Controller controller = new Controller(game, frmMain, pop);

            // Setting the correct controller and form relations
            frmMain.SetController(controller);
            frmMain.SetChildForm(pop);
            game.SetController(controller);
            pop.SetController(controller);

            // Adding levels 
            // Wall data order: TOP RIGHT BOTTOM LEFT
            controller.AddNewLevel("Entryway", 3, 1, "0000 0001 0002 1011 1010 1110");
            controller.AddNewLevel("Halls of the Damned", 4, 3, "0001 0201 0103" + " 1001 1010 1100 0001" + " 0001 1110 0001 1010" + " 0011 1010 0110 1001");
            controller.AddNewLevel("Level three", 3, 3, "0000 0101 0202" + " 1111 1001 1100" + " 1001 0000 0100" + " 0011 0010 0110");
            controller.AddNewLevel("BlockedThesesusIn3by3", 3, 3, "0000 0101 0202" + " 1111 1001 1100" + " 1101 1111 0101" + " 0011 1010 0110");
            controller.AddNewLevel("CentredMinotaurThesesusIn7by7", 7, 7, "0303 0003 0001" + " 1001 1000 1000 1000 1000 1000 1100" + " 0001 0000 0000 0000 0000 0000 0100" + " 0001 0000 0000 0000 0000 0000 0100" 
                + " 0001 0000 0000 0000 0000 0000 0100" + " 0001 0000 0000 0000 0000 0000 0100" + " 0001 0000 0000 0000 0000 0000 0100" + " 0011 0010 0010 0010 0010 0010 0110");

            controller.ImportLevelData();

            Application.Run(frmMain);
        }
    }
}
