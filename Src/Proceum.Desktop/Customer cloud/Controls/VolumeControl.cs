using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proceum.Customer_cloud.Controls
{
    public partial class VolumeControl : UserControl
    {
        public VolumeControl()
        {
            InitializeComponent();
            VolumeFront.Width = VolumeBack.Width;

            ChangeProgress(1);
        }


        #region Progress Bar Progressing Events

        public double Value;
        public event EventHandler OnProgressChange;

        private bool IsMouseDown = false;

        private void ProgressBarBack_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeProgress(e.Location.Y);
            IsMouseDown = true;
        }
        private void ProgressBarBack_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }
        private void ProgressBarBack_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown) ChangeProgress(e.Location.Y);
        }
        private void ChangeProgress(int Pos)
        {
            Pos = Pos < 0 ? 0 : Pos > VolumeBack.Height ? VolumeBack.Height : Pos;     //Code to normalise position According to ProgressBar Width

            this.Value = ((Pos * 100.0) / VolumeBack.Height);
            VolumeFront.Location = VolumeBack.Location;
            VolumeFront.Height = Pos;
            if (this.OnProgressChange != null) this.OnProgressChange(this, null);
        }

        #endregion

        #region Hiding Events

        public event EventHandler MouseIn;
        public event EventHandler MouseOut;
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (MouseIn != null) this.MouseIn(this, e);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (MouseOut != null) this.MouseOut(this, e);
        }
        #endregion

        private void VolumeControl_Load(object sender, EventArgs e)
        {

            ChangeProgress(1);
        }

        private void VolumeBack_Click(object sender, EventArgs e)
        {

        }
    }
}
