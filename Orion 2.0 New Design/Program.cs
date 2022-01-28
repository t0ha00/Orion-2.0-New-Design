using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion_2._0_New_Design
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Classes.DataBank.User == null)
            { Application.Run(new Forms.FrmMain()); }
            else
            { Application.Run(new Forms.FrmMain()); }
        }
    }
}
