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
        private IconButton currentBtn, predCurrentBtn;
        private Panel panelSubmenuCurr;
        private bool subMenuCollapsed = true;


        public FrmMain()
        {
            InitializeComponent();
            DisablePanels();
            //Меняем размер рамок
            this.Text = String.Empty;
            
            this.DoubleBuffered = false;
        }                                                             

        private void ActivateButton(object senderBtn, Panel panelSubMenu)
        {
            if (senderBtn != null)
            {
                DisableButton();
                predCurrentBtn = currentBtn;
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);

                panelSubmenuCurr = panelSubMenu;
                
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                titleCurrentChildForm.Text = currentBtn.Text;
                timerSubMenu.Start();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(38, 43, 72);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void DisablePanels()
        {
            panelContractSubMenu.Height = 0;
            panelArchiveSubMenu.Height = 0;
            panelEconomicSubMenu.Height = 0;
            panelMetodSubMenu.Height = 0;
            panelSearchSubMenu.Height = 0;
            panelGroupSubMenu.Height = 0;
            panelSettingsSubMenu.Height = 0;
            panelStudSubMenu.Height = 0;
            subMenuCollapsed = true;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void timerSubMenu_Tick(object sender, EventArgs e)
        {
            if (subMenuCollapsed)
            {
                panelSubmenuCurr.Height += 10;
                if (panelSubmenuCurr.Height == panelSubmenuCurr.MaximumSize.Height)
                {
                    subMenuCollapsed = false;
                    timerSubMenu.Stop();
                }
            }
            else
            {
                if (predCurrentBtn == currentBtn) 
                {
                    panelSubmenuCurr.Height -= 10;
                    if (panelSubmenuCurr.Height == panelSubmenuCurr.MinimumSize.Height)
                    {
                        DisableButton();
                        subMenuCollapsed = true;
                        timerSubMenu.Stop();
                    }
                }
                else
                {
                    DisablePanels();
                    panelSubmenuCurr.Height += 10;
                    if (panelSubmenuCurr.Height == panelSubmenuCurr.MaximumSize.Height)
                    {
                        subMenuCollapsed = false;
                        timerSubMenu.Stop();
                    }
                }
            }
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelArchiveSubMenu);
        }

        private void buttonContract_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelContractSubMenu);            
        }

        private void buttonMetod_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelMetodSubMenu);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelSettingsSubMenu);
        }

        private void buttonStudie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelStudSubMenu);
        }

        private void buttonMakeGroupe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelGroupSubMenu);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelSearchSubMenu);
        }

        private void buttonEconomy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelEconomicSubMenu);
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
            this.Alert("Info", Form_Alert.enmType.Info);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Alert("Warning", Form_Alert.enmType.Warning);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Alert("Error", Form_Alert.enmType.Error);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Alert("Success", Form_Alert.enmType.Success);
        }
    }
}
