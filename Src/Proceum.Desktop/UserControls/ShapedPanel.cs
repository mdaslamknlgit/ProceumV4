using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Proceum.UserControls
{
    public class ShapedPanel : Panel
    {
        private Pen pen = new Pen(Color.Wheat, penWidth);
        private static readonly float penWidth = 2.0F;

        public ShapedPanel()
        {
        }

        private Color _borderColor = Color.White;
        //[Browsable(true)]
        //public Color BorderColor
        //{
        //    get
        //    {
        //        return _borderColor;
        //    }
        //    set
        //    {
        //        _borderColor = Value;
        //        pen = new Pen(_borderColor, penWidth);
        //        Invalidate();
        //    }
        //}

        [Browsable(true)]
        public Color BorderColor {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
                pen = new Pen(_borderColor, penWidth);
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ExtendedDraw(e);
            DrawBorder(e.Graphics);
        }

        private int _edge = 50;
        [Browsable(true)]
        public int Edge
        {
            get
            {
                return _edge;
            }
            set
            {
                _edge = value;
                Invalidate();
            }
        }


        private Rectangle GetLeftUpper(int e)
        {
            return new Rectangle(0, 0, e, e);
        }

        private Rectangle GetRightUpper(int e)
        {
            return new Rectangle(Width - e, 0, e, e);
        }

        private Rectangle GetRightLower(int e)
        {
            return new Rectangle(Width - e, Height - e, e, e);
        }

        private Rectangle GetLeftLower(int e)
        {
            return new Rectangle(0, Height - e, e, e);
        }

        private void ExtendedDraw(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.StartFigure();
            path.AddArc(GetLeftUpper(Edge), 180, 90);
            path.AddLine(Edge, 0, Width - Edge, 0);
            path.AddArc(GetRightUpper(Edge), 270, 90);
            path.AddLine(Width, Edge, Width, Height - Edge);
            path.AddArc(GetRightLower(Edge), 0, 90);
            path.AddLine(Width - Edge, Height, Edge, Height);
            path.AddArc(GetLeftLower(Edge), 90, 90);
            path.AddLine(0, Height - Edge, 0, Edge);
            path.CloseFigure();
            Region = new Region(path);
        }

        private void DrawSingleBorder(Graphics graphics)
        {
            graphics.DrawArc(pen, new Rectangle(0, 0, Edge, Edge), 180, 90);
            graphics.DrawArc(pen, new Rectangle(Width - Edge - 1, -1, Edge, Edge), 270, 90);
            graphics.DrawArc(pen, new Rectangle(Width - Edge - 1, Height - Edge - 1, Edge, Edge), 0, 90);
            graphics.DrawArc(pen, new Rectangle(0, Height - Edge - 1, Edge, Edge), 90, 90);
            graphics.DrawRectangle(pen, 0.0F, 0.0F, System.Convert.ToSingle((Width - 1)), System.Convert.ToSingle((Height - 1)));
        }

        private void Draw3DBorder(Graphics graphics)
        {
        }

        private void DrawBorder(Graphics graphics)
        {
            DrawSingleBorder(graphics);
        }
    }
}
