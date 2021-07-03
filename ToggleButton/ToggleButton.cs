using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace WinPngConverter.ToggleButton
{
    public class ToggleButton : CheckBox
    {
        readonly private Color onBackColor = Color.DodgerBlue;
        readonly private Color onToggleColor = Color.Green;
        readonly private Color offBackColor = Color.DodgerBlue;
        readonly private Color offToggleColor = Color.Red;

        //private bool solidStyle = true;

        //Properties
        //[Category("ToggleButton")]
        //public Color OnBackColor
        //{
        //    get { return onBackColor; }
        //    set
        //    {
        //        onBackColor = value;
        //        this.Invalidate();
        //    }
        //}
        //[Category("ToggleButton")]
        //public Color OnToggleColor
        //{
        //    get { return OnToggleColor; }
        //    set
        //    {
        //        OnToggleColor = value;
        //        this.Invalidate();
        //    }
        //}
        //[Category("ToggleButton")]
        //public Color OffBackColor
        //{
        //    get { return OffBackColor; }
        //    set
        //    {
        //        OffBackColor = value;
        //        this.Invalidate();
        //    }
        //}
        //[Category("ToggleButton")]
        //public Color OffToggleColor
        //{
        //    get { return OffToggleColor; }
        //    set
        //    {
        //        OffToggleColor = value;
        //        this.Invalidate();
        //    }
        //}
        [Browsable(false)]
        public override string Text
        {
            get { return base.Text; }
            set {}
        }
        //[Category("ToggleButton")]
        //[DefaultValue(true)]
        //public bool SolidStyle 
        //{
        //    get { return solidStyle; }
        //    set
        //    {
        //        solidStyle = value;
        //        this.Invalidate();
        //    }
        //}

        //Constructor
        public ToggleButton()
        {
            this.MinimumSize = new Size(45, 25);
        }

        //Draw Shape
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath _path = new GraphicsPath();
            _path.StartFigure();
            _path.AddArc(leftArc, 90, 180);
            _path.AddArc(rightArc, 270, 180);
            _path.CloseFigure();

            return _path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)
            {
                //if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                //else pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), 
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }else
            {
                //if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                //else pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
