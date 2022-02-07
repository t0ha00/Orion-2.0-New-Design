using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net;
using FontAwesome.Sharp;

namespace Orion_2._0_New_Design.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Перетаскивание
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void myTextBoxLogin_Enter(object sender, EventArgs e)
        {
            if (myTextBoxLogin.Texts == "Имя входа")
            {
                myTextBoxLogin.Texts = "";
                myTextBoxLogin.ForeColor = Color.Black;
            }
        }

        private void myTextBoxLogin_Leave(object sender, EventArgs e)
        {
            if (myTextBoxLogin.Texts == "")
            {
                myTextBoxLogin.Texts = "Имя входа";
                myTextBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void myTextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (myTextBoxPassword.Texts == "Пароль")
            {
                myTextBoxPassword.Texts = "";
                myTextBoxPassword.ForeColor = Color.Black;
                myTextBoxPassword.PasswordChar = true;
            }
        }

        private void myTextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (myTextBoxPassword.Texts == "")
            {
                myTextBoxPassword.PasswordChar = false;
                myTextBoxPassword.Texts = "Пароль";
                myTextBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void iconPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox1.IconColor = Color.Gray;
        }

        private void iconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox1.IconColor = Color.Black;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            pictureBoxLogo.Image = Orion_2._0_New_Design.Properties.Resources.Vp3R;
            using (WebClient webClient = new WebClient())
            {
                var responseEnter = webClient.DownloadString("http://orion.bnprofi.host/get_login_pass?login=Вася&pass=йуцейцуе");
                
            }

                //Form formMain = new FrmMain();
                //formMain.Show();
                //this.Hide();
            }
    }
}
