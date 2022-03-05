
namespace Orion_2._0_New_Design.Forms
{
    partial class MakingGroups
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxOTV = new System.Windows.Forms.CheckBox();
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPlaces = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxOTV);
            this.panel1.Controls.Add(this.listBoxWorkers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxPlaces);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 450);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxOTV
            // 
            this.checkBoxOTV.AutoSize = true;
            this.checkBoxOTV.Location = new System.Drawing.Point(141, 63);
            this.checkBoxOTV.Name = "checkBoxOTV";
            this.checkBoxOTV.Size = new System.Drawing.Size(48, 17);
            this.checkBoxOTV.TabIndex = 4;
            this.checkBoxOTV.Text = "ОТВ";
            this.checkBoxOTV.UseVisualStyleBackColor = true;
            // 
            // listBoxWorkers
            // 
            this.listBoxWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxWorkers.FormattingEnabled = true;
            this.listBoxWorkers.Location = new System.Drawing.Point(6, 91);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.Size = new System.Drawing.Size(186, 121);
            this.listBoxWorkers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ответственные";
            // 
            // comboBoxPlaces
            // 
            this.comboBoxPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPlaces.FormattingEnabled = true;
            this.comboBoxPlaces.Location = new System.Drawing.Point(6, 35);
            this.comboBoxPlaces.Name = "comboBoxPlaces";
            this.comboBoxPlaces.Size = new System.Drawing.Size(186, 21);
            this.comboBoxPlaces.TabIndex = 1;
            this.comboBoxPlaces.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlaces_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подразделение";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(195, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 450);
            this.panel2.TabIndex = 1;
            // 
            // MakingGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MakingGroups";
            this.Text = "MakingGroups";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxWorkers;
        private System.Windows.Forms.ComboBox comboBoxPlaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxOTV;
    }
}