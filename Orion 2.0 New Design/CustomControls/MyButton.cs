using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< Updated upstream
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
=======
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
>>>>>>> Stashed changes

namespace Orion_2._0_New_Design.CustomControls
{
    class MyButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

<<<<<<< Updated upstream
        [Category("Custom Controls")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("Custom Controls")]
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); }}
        [Category("Custom Controls")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("Custom Controls")]
        public Color BackgroundColor
        {
            get => this.BackColor;
            set => this.BackColor = value; 
        }
        [Category("Custom Controls")]
        public Color TextColor
        {
            get => this.ForeColor;
            set => this.ForeColor = value;
        }

=======
        //Constructor
>>>>>>> Stashed changes
        public MyButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
<<<<<<< Updated upstream
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if(borderRadius > this.Height)
            {
                BorderRadius = this.Height;
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
=======
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radi)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radi, radi, 180, 90);
            path.AddArc(rect.Width - radi, rect.Y, radi, radi, 270, 90);
            path.AddArc(rect.Width - radi, rect.Height - radi, radi, radi, 0, 90);
            path.AddArc(rect.X, rect.Height - radi, radi, radi, 90, 90);
>>>>>>> Stashed changes
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
<<<<<<< Updated upstream
            RectangleF recBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) //Если закругленная кнопка
            {
                using(GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using(GraphicsPath pathBorder = GetFigurePath(rectSurface, borderRadius-1F))
                using(Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using(Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Незакругленная кнопка
            {
                this.Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using(Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }


        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
=======
            RectangleF rectBorder = new RectangleF(1, 1, this.Width-0.8F, this.Height);
>>>>>>> Stashed changes
        }
    }
}
