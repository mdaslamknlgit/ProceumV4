﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proceum.Customer_cloud.Controls
{
    public partial class TransparentPictureBox : PictureBox
    {
        private const int WS_EX_TRANSPARENT = 0x20;

        private int opacity = 50;

        [DefaultValue(50)]
        public int Opacity
        {
            get
            {
                return this.opacity;
            }

            set
            {
                this.opacity = value < 0 ? 0 : value > 100 ? 100 : value;
            }
        }

        public TransparentPictureBox()
        {
            InitializeComponent();

            SetStyle(ControlStyles.Opaque, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cpar = base.CreateParams;
                cpar.ExStyle = cpar.ExStyle | WS_EX_TRANSPARENT;
                return cpar;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            using (var brush = new SolidBrush(Color.FromArgb(this.opacity * 255 / 100, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }


        public TransparentPictureBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
