
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelEntry = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.myTextBoxPassword = new Orion_2._0_New_Design.CustomControls.MyTextBox();
            this.myTextBoxLogin = new Orion_2._0_New_Design.CustomControls.MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            this.iconPictureBox1.MouseEnter += new System.EventHandler(this.iconPictureBox1_MouseEnter);
            this.iconPictureBox1.MouseLeave += new System.EventHandler(this.iconPictureBox1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelEntry
            // 
            this.labelEntry.AutoSize = true;
            this.labelEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEntry.Location = new System.Drawing.Point(13, 104);
            this.labelEntry.Name = "labelEntry";
            this.labelEntry.Size = new System.Drawing.Size(79, 37);
            this.labelEntry.TabIndex = 2;
            this.labelEntry.Text = "Вход";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.buttonLogin.Location = new System.Drawing.Point(250, 342);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 29);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Далее";
            this.buttonLogin.UseVisualStyleBackColor = false;
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
            this.myTextBoxPassword.Size = new System.Drawing.Size(305, 22);
            this.myTextBoxPassword.TabIndex = 8;
            this.myTextBoxPassword.Texts = "Пароль";
            this.myTextBoxPassword.UnderlineStyle = true;
            this.myTextBoxPassword.Enter += new System.EventHandler(this.myTextBoxPassword_Enter);
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
            this.myTextBoxLogin.Size = new System.Drawing.Size(305, 22);
            this.myTextBoxLogin.TabIndex = 7;
            this.myTextBoxLogin.Texts = "Имя входа";
            this.myTextBoxLogin.UnderlineStyle = true;
            this.myTextBoxLogin.Enter += new System.EventHandler(this.myTextBoxLogin_Enter);
            this.myTextBoxLogin.Leave += new System.EventHandler(this.myTextBoxLogin_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(337, 416);
            this.Controls.Add(this.myTextBoxPassword);
            this.Controls.Add(this.myTextBoxLogin);
            this.Controls.Add(this.checkBoxRemember);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelEntry);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconPictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelEntry;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private CustomControls.MyTextBox myTextBoxLogin;
        private CustomControls.MyTextBox myTextBoxPassword;
    }
}