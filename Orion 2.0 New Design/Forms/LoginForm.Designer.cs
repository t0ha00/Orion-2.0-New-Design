
namespace Orion_2._0_New_Design.Forms
{
    partial class LoginForm
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelEntry = new System.Windows.Forms.Label();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.myTextBoxPassword = new Orion_2._0_New_Design.CustomControls.MyTextBox();
            this.myTextBoxLogin = new Orion_2._0_New_Design.CustomControls.MyTextBox();
            this.myButton1 = new Orion_2._0_New_Design.CustomControls.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(293, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            this.iconPictureBox1.MouseEnter += new System.EventHandler(this.iconPictureBox1_MouseEnter);
            this.iconPictureBox1.MouseLeave += new System.EventHandler(this.iconPictureBox1_MouseLeave);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Orion_2._0_New_Design.Properties.Resources.BNP_LOGO;
            this.pictureBoxLogo.Location = new System.Drawing.Point(20, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(92, 89);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelEntry
            // 
            this.labelEntry.AutoSize = true;
            this.labelEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEntry.Location = new System.Drawing.Point(13, 120);
            this.labelEntry.Name = "labelEntry";
            this.labelEntry.Size = new System.Drawing.Size(79, 37);
            this.labelEntry.TabIndex = 2;
            this.labelEntry.Text = "Вход";
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRemember.Location = new System.Drawing.Point(20, 300);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(118, 19);
            this.checkBoxRemember.TabIndex = 6;
            this.checkBoxRemember.Text = "Запомнить меня";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // myTextBoxPassword
            // 
            this.myTextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.myTextBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.myTextBoxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.myTextBoxPassword.BorderSize = 2;
            this.myTextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myTextBoxPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.myTextBoxPassword.Location = new System.Drawing.Point(20, 244);
            this.myTextBoxPassword.Multiline = false;
            this.myTextBoxPassword.Name = "myTextBoxPassword";
            this.myTextBoxPassword.Padding = new System.Windows.Forms.Padding(2);
            this.myTextBoxPassword.PasswordChar = false;
            this.myTextBoxPassword.Size = new System.Drawing.Size(295, 22);
            this.myTextBoxPassword.TabIndex = 8;
            this.myTextBoxPassword.Texts = "Пароль";
            this.myTextBoxPassword.UnderlineStyle = true;
            this.myTextBoxPassword.Enter += new System.EventHandler(this.myTextBoxPassword_Enter);
            this.myTextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myTextBoxPassword_KeyDown);
            this.myTextBoxPassword.Leave += new System.EventHandler(this.myTextBoxPassword_Leave);
            // 
            // myTextBoxLogin
            // 
            this.myTextBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.myTextBoxLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.myTextBoxLogin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.myTextBoxLogin.BorderSize = 2;
            this.myTextBoxLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myTextBoxLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.myTextBoxLogin.Location = new System.Drawing.Point(20, 181);
            this.myTextBoxLogin.Multiline = false;
            this.myTextBoxLogin.Name = "myTextBoxLogin";
            this.myTextBoxLogin.Padding = new System.Windows.Forms.Padding(2);
            this.myTextBoxLogin.PasswordChar = false;
            this.myTextBoxLogin.Size = new System.Drawing.Size(295, 22);
            this.myTextBoxLogin.TabIndex = 7;
            this.myTextBoxLogin.Texts = "Имя входа";
            this.myTextBoxLogin.UnderlineStyle = true;
            this.myTextBoxLogin.Enter += new System.EventHandler(this.myTextBoxLogin_Enter);
            this.myTextBoxLogin.Leave += new System.EventHandler(this.myTextBoxLogin_Leave);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.myButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.myButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.myButton1.BorderRadius = 0;
            this.myButton1.BorderSize = 0;
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myButton1.Location = new System.Drawing.Point(250, 337);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(75, 22);
            this.myButton1.TabIndex = 9;
            this.myButton1.Text = "Далее";
            this.myButton1.TextColor = System.Drawing.SystemColors.ControlText;
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(337, 398);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.myTextBoxPassword);
            this.Controls.Add(this.myTextBoxLogin);
            this.Controls.Add(this.checkBoxRemember);
            this.Controls.Add(this.labelEntry);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.iconPictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelEntry;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private CustomControls.MyTextBox myTextBoxLogin;
        private CustomControls.MyTextBox myTextBoxPassword;
        private CustomControls.MyButton myButton1;
    }
}