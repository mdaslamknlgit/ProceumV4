//using AxWMPLib;
using Proceum.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proceum
{
    class DisplayWatermark
    {
        //[DllImport("User32.dll")]
        //public static extern IntPtr GetDC(IntPtr hwnd);
        //[DllImport("User32.dll")]
        //public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);



        public string Text { get; set; }
        Form currentForm;
        Control controlToBound;
        Timer tm_watermarker;
        Timer tm_randomPointer;
        Random r = new Random();
        Point point;
        BackgroundWorker bw;
        frmVideoOverlay video_overlay;
        public DisplayWatermark(Form currentForm, Control controlToBound)
        {
            this.currentForm = currentForm;
            this.controlToBound = controlToBound;
            tm_watermarker = new Timer();
            tm_watermarker.Interval = 5000;
            tm_watermarker.Tick += Tm_watermarker_Tick;

            tm_randomPointer = new Timer();
            tm_randomPointer.Interval = 5000;
            tm_randomPointer.Tick += Tm_randomPointer_Tick;
            video_overlay = new frmVideoOverlay();
            video_overlay.TopMost = true;
            video_overlay.ShowInTaskbar = false;
            video_overlay.ShowIcon = false;

        }

        private void Tm_randomPointer_Tick(object sender, EventArgs e)
        {
            getNewPoint();
        }

        private void Tm_watermarker_Tick(object sender, EventArgs e)
        {
            // unmanagedWatermark();
            managedWatermark();
        }

        public void Start()
        {
            if (!string.IsNullOrWhiteSpace(this.Text))
            {
                getNewPoint();
                tm_randomPointer.Start();
                tm_watermarker.Start();
            }
        }

        public void Stop()
        {
            video_overlay.Hide();
            tm_randomPointer.Stop();
            tm_watermarker.Stop();
        }
        void unmanagedWatermark()
        {
            //if (point == null) return;

            //IntPtr desktopPtr = GetDC(IntPtr.Zero);
            //Graphics g = Graphics.FromHdc(desktopPtr);

            //SolidBrush b = new SolidBrush(Color.White);
            //g.DrawString(this.Text, new Font(FontFamily.GenericSansSerif, 24, GraphicsUnit.Pixel), Brushes.Blue, point);
            //// g.FillRectangle(b, new Rectangle(0, 0, 1920, 1080));

            //g.Dispose();
            //ReleaseDC(IntPtr.Zero, desktopPtr);
        }

        private const int SW_SHOWNOACTIVATE = 4;
        private const int HWND_TOPMOST = -1;
        private const uint SWP_NOACTIVATE = 0x0010;

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        static extern bool SetWindowPos(
             int hWnd,             // Window handle
             int hWndInsertAfter,  // Placement-order handle
             int X,                // Horizontal position
             int Y,                // Vertical position
             int cx,               // Width
             int cy,               // Height
             uint uFlags);         // Window positioning flags

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        static void ShowInactiveTopmost(Form frm)
        {
            ShowWindow(frm.Handle, SW_SHOWNOACTIVATE);
            SetWindowPos(frm.Handle.ToInt32(), HWND_TOPMOST,
            frm.Left, frm.Top, frm.Width, frm.Height,
            SWP_NOACTIVATE);
        }

        void managedWatermark()
        {
            video_overlay.Hide();
            video_overlay.Location = point;
            video_overlay.label1.Text = this.Text;
            ShowInactiveTopmost(video_overlay);

        }
        void getNewPoint()
        {
            try
            {
                Point locationOnForm = controlToBound.FindForm().PointToClient(controlToBound.Parent.PointToScreen(controlToBound.Location));

                var start_x = locationOnForm.X + 10;
                var start_y = locationOnForm.Y + 10;

                var end_x = locationOnForm.X + controlToBound.Width - (10 + video_overlay.Width);
                var end_y = locationOnForm.Y + controlToBound.Height - (10 + video_overlay.Height);

                if (start_x < end_x && start_y < end_y)
                {
                    var rand_x = r.Next(start_x, end_x);
                    var rand_y = r.Next(start_y, end_y);
                    point = new Point(rand_x, rand_y);
                }
            }
            catch { }
        }
    }
}
