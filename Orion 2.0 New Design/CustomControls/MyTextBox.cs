using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion_2._0_New_Design.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class MyTextBox : UserControl
    {
        //Поля
        private Color borderColor = Color.FromArgb(225, 225, 225);
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color borderFocusColor = Color.FromArgb(0, 114, 198);
        private bool isFocused = false;

        //Конструктор
        public MyTextBox()
        {
            InitializeComponent();
        }

        //События

        public event EventHandler _TextChanged;

        //Зависимости

        [Category("MyCode")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("MyCode")]
        public int BorderSize {
            get 
            {
                return borderSize; 
            }
            set
            {
                borderSize = value; 
                this.Invalidate();
            }
        }

        [Category("MyCode")]
        public bool UnderlineStyle
        {
            get
            {
                return underlineStyle;
            }
            set
            {
                underlineStyle = value;
                this.Invalidate();
            }
        }

        [Category("MyCode")]
        public bool PasswordChar
        {
            get
            {
                return textBox1.UseSystemPasswordChar;
            }
            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("MyCode")]
        public bool Multiline
        {
            get => textBox1.Multiline;
            set
            {
                textBox1.Multiline = value;
            }
        }

        //Перезаписаные методды
        [Category("MyCode")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("MyCode")]
        public override Color ForeColor 
        { 
            get => base.ForeColor;
            set
            { 
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
            
        }

        [Category("MyCode")]
        public override Font Font 
        { 
            get => base.Font;
            set
            { 
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("MyCode")]
        public string Texts
        {
            get => textBox1.Text;
            set
            {
                textBox1.Text = value;
            }
        }

        [Category("MyCode")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Отрисовываем рамки
            using (Pen penBorder = new Pen(BorderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!isFocused)
                {
                    if (underlineStyle) //Для подчеркивания
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Для обычного
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.0F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;

                    if (underlineStyle) //Для подчеркивания
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Для обычного
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.0F, this.Height - 0.5F);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if(textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
