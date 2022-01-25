using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Orion_2._0_New_Design.Forms
{
    public partial class FrmMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public FrmMain()
        {
            InitializeComponent();
            //Создание выделения выбранного пункта
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelSideMenu.Controls.Add(leftBorderBtn);
            //Дефолтные значения при запуске
            CustomizeDesign();
            //Меняем размер рамок
            this.Text = String.Empty;
            
            this.DoubleBuffered = false;
        }
        private void CustomizeDesign()
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            panelArchiveSubMenu.Visible = false;
            panelContractSubMenu.Visible = false;
            panelSearchSubMenu.Visible = false;
            panelSettingsSubMenu.Visible = false;
            panelGroupSubMenu.Visible = false;
            panelMetodSubMenu.Visible = false;
            panelEconomicSubMenu.Visible = false;
            panelStudSubMenu.Visible = false;
            //Скрываем подменю при запуске
        }
        private void HideSubMenu()
        {
            if (panelArchiveSubMenu.Visible == true)            
                panelArchiveSubMenu.Visible = false;
            if (panelContractSubMenu.Visible == true)
                panelContractSubMenu.Visible = false;
            if (panelSearchSubMenu.Visible == true)
                panelSearchSubMenu.Visible = false;
            if (panelSettingsSubMenu.Visible == true)
                panelSettingsSubMenu.Visible = false;
            if (panelGroupSubMenu.Visible == true)
                panelGroupSubMenu.Visible = false;
            if (panelMetodSubMenu.Visible == true)
                panelMetodSubMenu.Visible = false;
            if (panelEconomicSubMenu.Visible == true)
                panelEconomicSubMenu.Visible = false;
            if (panelStudSubMenu.Visible == true)
                panelStudSubMenu.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //Struct for the buttons
        private struct RGBColors
        {
          public static Color color1 = Color.FromArgb(172, 126, 241);
          public static Color color2 = Color.FromArgb(249, 118, 176);
          public static Color color3 = Color.FromArgb(253, 138, 114);
          public static Color color4 = Color.FromArgb(95, 77, 221);
          public static Color color5 = Color.FromArgb(249, 88, 155);
          public static Color color6 = Color.FromArgb(24, 161, 251);
        }                                                            

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                titleCurrentChildForm.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void Alert(string msg)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg);
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ShowSubMenu(panelArchiveSubMenu);
        }

        private void buttonContract_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ShowSubMenu(panelContractSubMenu);
        }

        private void buttonMetod_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            ShowSubMenu(panelMetodSubMenu);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            ShowSubMenu(panelSettingsSubMenu);
        }

        private void buttonStudie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            ShowSubMenu(panelStudSubMenu);
        }

        private void buttonMakeGroupe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            ShowSubMenu(panelGroupSubMenu);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ShowSubMenu(panelSearchSubMenu);
        }

        private void buttonEconomy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ShowSubMenu(panelEconomicSubMenu);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            iconCloseWindow.IconColor = Color.White;
        }

        private void iconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            iconCloseWindow.IconColor = Color.Black;
        }

        private void iconMaximazeWindow_MouseEnter(object sender, EventArgs e)
        {
            iconMaximazeWindow.IconColor = Color.White;
        }

        private void iconMaximazeWindow_MouseLeave(object sender, EventArgs e)
        {
            iconMaximazeWindow.IconColor = Color.Black;
        }

        private void iconMinimizeWindow_MouseEnter(object sender, EventArgs e)
        {
            iconMinimizeWindow.IconColor = Color.White;
        }

        private void iconMinimizeWindow_MouseLeave(object sender, EventArgs e)
        {
            iconMinimizeWindow.IconColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Alert("ТЕСТ");
        }
    }
}
