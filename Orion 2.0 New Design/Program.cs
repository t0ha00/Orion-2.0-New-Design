using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

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
           
            using (WebClient webClient = new MyWebClient())
            {
                try
                {
                    var json_serverA = webClient.DownloadString("http://orion.bnprofi.host/");
                    if (json_serverA == "OK")
                    {
                        if (Classes.DataBank.User == null)
                            Application.Run(new Forms.LoginForm());
                        else
                            Application.Run(new Forms.FrmMain());
                    }
                    else
                    {
                        MessageBox.Show("Сервер не доступен, проверьте пожалуйста доступ к интернету!");
                    }
                }
                catch (Exception e)
                {
                    //MessageBox.Show("Ошибка - " + e);
                    Application.Run(new Forms.LoginForm());
                }
            }
            
            
        }

        private class MyWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri address)
            {
                WebRequest w = base.GetWebRequest(address);
                w.Timeout = 600;
                return w;
            }
        }
    }
}
