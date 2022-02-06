using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion_2._0_New_Design.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

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
            }
        }

        private void myTextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (myTextBoxPassword.Texts == "")
            {
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
    }
}
