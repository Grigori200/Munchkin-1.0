using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Munchkin.Contexts;
using Munchkin.Models;
using Munchkin.Models.Cards.Doors;

namespace Munchkin
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>

        static Player player = new Player();

        [STAThread]
        static void Main()
        {
            WindowMenager.SetDefaultData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
