using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace Proceum.Customer_cloud.Controls
{
    public partial class Player_Controls : UserControl
    {
        public bool IsLiveVideo = false;
        public double Duration = 0;
        public double CurrentTime = 0;
        public bool IsLoaded = false;//itshould be false

        private int TimeToHideVolumeControl = 2;
        private int TimeToHideSettingControl = 2;

        VolumeControl VolumeProgress;
        PoperContainer VolumeContainer;

        public Player_Controls()
        {
            InitializeComponent();

        }

        public Player_Controls(bool IsLiveVideo)
        {
            InitializeComponent();
            this.IsLiveVideo = IsLiveVideo;
            HoverColorSetting();
            ProgressBarFront.Location = ProgressBarBack.Location;
            if (IsLiveVideo)
            {
                string itemsName = "";
                ProgressBarFront.Width = ProgressBarBack.Width;
                SettingControls.Items[0].Visible = false;
                Change_Quality_Names();
            }
            else
            {
                ProgressBarFront.Width = 0;
                Hide_Quality_Name();
            }

            VolumeProgress = new VolumeControl();
            VolumeContainer = new PoperContainer(VolumeProgress);

            Set_Mouse_Leave();
        }

        private void Hide_Quality_Name()
        {
            try
            {
                var Obj = (SettingControls.Items[1] as ToolStripMenuItem).DropDownItems;

                Obj[4].Visible = false;

            }
            catch
            {
            }
        }

        private void Set_Mouse_Leave()
        {
            for (int i = 0; i <= 1; i++)
            {
                foreach (ToolStripItem item in (SettingControls.Items[i] as ToolStripMenuItem).DropDownItems)
                {
                    item.MouseEnter += Item_MouseEnter;
                    item.MouseLeave += Item_MouseLeave;
                }
            }
        }

        bool Is_Mouse_Inside_Settings = false;
        private void Item_MouseLeave(object sender, EventArgs e)
        {
            Is_Mouse_Inside_Settings = false;
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            Is_Mouse_Inside_Settings = true;
        }

        private void Change_Quality_Names()
        {
            try
            {
                var Obj = (SettingControls.Items[1] as ToolStripMenuItem).DropDownItems;

                Obj[1].Text = "240p";                  
                Obj[2].Text = "360p";
                Obj[3].Text = "480p";
                //Obj[4].Text = "480p";
                Obj[4].Visible = false;

            }
            catch
            {
            }
        }
        public void SetMedia(double Duration)
        {
            this.Duration = Duration;
            IsLoaded = true;
        }

        #region Video Player Main Controls

        public bool IsPlaying;
        public event EventHandler PlayPauseClick;
       

        public void Pause()
        {
            PlayPause.Image = Properties.Resources.play_button;
            IsPlaying = true;

            if (PlayPauseClick != null) this.PlayPauseClick(this, null);
        }

        public void Play()
        {
            WatchTimer.Enabled = true;
            PlayPause.Image = Properties.Resources.pause;
            IsPlaying = false;

            if (PlayPauseClick != null) this.PlayPauseClick(this, null);
        }

        private void PlayPause_Click(object sender, EventArgs e)
        {
            IsLoaded = true;
            if (IsLoaded)
            {
                if (IsPlaying)
                {
                    Play();
                }
                else
                {
                    Pause();
                }
            }
        }

        public event EventHandler GoLiveClick;
        private void GoLive_Click(object sender, EventArgs e)
        {
            if (GoLiveClick != null) this.GoLiveClick(this, e);

            //if (IsLoaded)
            //{
            //    if (GoLiveClick != null) this.GoLiveClick(this, e);
            //}
        }

        bool SettingControlsShown = false;
        private void Settings_Click(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                if (!SettingControlsShown)
                {
                    SettingControls.Show(Settings, new Point(0, 0), ToolStripDropDownDirection.AboveRight);
                }
            }
        }

        public bool IsFullScreen;
        public event EventHandler FullScreenClick;
        private void FullScreen_Click(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                if (IsFullScreen)
                {
                    FullScreen.Image = Properties.Resources.switch_to_full_screen_button;
                    IsFullScreen = false;
                }
                else
                {
                    FullScreen.Image = Properties.Resources.full_screen_exit;
                    IsFullScreen = true;
                }
                if (FullScreenClick != null) this.FullScreenClick(this, e);
            }
        }

        public int Volume = 0;
        public event EventHandler VolumeChange;
        private void VolumeController_Click(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                TimeToHideVolumeControl = 3;
                VolumeProgress.OnProgressChange += volumeProgressChange;
                VolumeContainer.Show(VolumeController);
            }
        }

        private void volumeProgressChange(object sender, EventArgs e)
        {
            Volume = Convert.ToInt32(VolumeProgress.Value);
            if (VolumeChange != null) this.VolumeChange(this, e);
        }

        private void Player_Controls_Load(object sender, EventArgs e)
        {
            if (!IsLiveVideo)
            {
                Pn_GoLive.Visible = false;
            }
            WatchTimer.Enabled = true;
        }

        #endregion

        #region Video Quality Changing Events

        public event EventHandler QualityChanged;
        public int QualityCode;
        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormalizeAllSelectionInSettingControl(1);
            var item = sender as ToolStripMenuItem;
            item.ForeColor = Color.FromArgb(30, 97, 123);
            QualityCode = -1;
            if (this.QualityChanged != null) this.QualityChanged(this, e);
        }
        private void pToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NormalizeAllSelectionInSettingControl(1);
            var item = sender as ToolStripMenuItem;
            item.ForeColor = Color.FromArgb(30, 97, 123);
            QualityCode = 0;
            if (this.QualityChanged != null) this.QualityChanged(this, e);
        }

        private void pToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NormalizeAllSelectionInSettingControl(1);
            var item = sender as ToolStripMenuItem;
            item.ForeColor = Color.FromArgb(30, 97, 123);
            QualityCode = 1;
            if (this.QualityChanged != null) this.QualityChanged(this, e);
        }

        private void pToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            NormalizeAllSelectionInSettingControl(1);
            var item = sender as ToolStripMenuItem;
            item.ForeColor = Color.FromArgb(30, 97, 123);
            QualityCode = 2;
            if (this.QualityChanged != null) this.QualityChanged(this, e);
        }

        private void pToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NormalizeAllSelectionInSettingControl(1);
            var item = sender as ToolStripMenuItem;
            item.ForeColor = Color.FromArgb(30, 97, 123);
            QualityCode = 3;
            if (this.QualityChanged != null) this.QualityChanged(this, e);
        }

        #endregion

        #region video Playback Speed Changing events

        public event EventHandler SpeedChanged;
        public double SpeedCode;
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormalizeAllSelectionInSettingControl(0);
            var item = sender as ToolStripMenuItem;
            item.ForeColor = Color.FromArgb(30, 97, 123);
            SpeedCode = 0.5;
            if (this.SpeedChanged != null) this.SpeedChanged(this, e);
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NormalizeAllSelectionInSettingControl(0);
            var item = sender as ToolStripMenuItem;
            item.ForeColor = Color.FromArgb(30, 97, 123);
            SpeedCode = 0.75;
            if (this.SpeedChanged != null) this.SpeedChanged(this, e);
        }

        private void xToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NormalizeAllSelectionInSettingControl(0);
            var item = sender as ToolStripMenuItem;
            item.ForeColor = Color.FromArgb(30, 97, 123);
            SpeedCode = 1;
            if (this.SpeedChanged != null) this.SpeedChanged(this, e);
        }

        private void xToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NormalizeAllSelectionInSettingControl(0);
            var item = sender as ToolStripMenuItem;
            item.ForeColor = Color.FromArgb(30, 97, 123);
            SpeedCode = 1.5;
            if (this.SpeedChanged != null) this.SpeedChanged(this, e);
        }
        //1.1,1.2,1.3,1.4,1.5,1.6,1.8,2
        private void xToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            NormalizeAllSelectionInSettingControl(0);
            var item = sender as ToolStripMenuItem;
            item.ForeColor = Color.FromArgb(30, 97, 123);
            SpeedCode = 2;
            if (this.SpeedChanged != null) this.SpeedChanged(this, e);
        }

        private void NormalizeAllSelectionInSettingControl(int Index)
        {
            try
            {
                foreach (var Obj in (SettingControls.Items[Index] as ToolStripMenuItem).DropDownItems)
                {
                    try
                    {
                        var item = Obj as ToolStripMenuItem;
                        item.ForeColor = Color.Black;
                    }
                    catch { }
                }
            }
            catch
            {
            }
        }

        #endregion

        #region Timer Events
        public event EventHandler OnMediaCurrentTimeChange;
        private void WatchTimer_Tick(object sender, EventArgs e)
        {
            if (OnMediaCurrentTimeChange != null) this.OnMediaCurrentTimeChange(this, e);

            Hide_Popups();

            if (!IsLiveVideo)
            {
                if (IsLoaded && Duration > 0)
                {
                    double Pos = ((CurrentTime * 100) / Duration);

                    lblTime.Text = GetTimeFromSeconds(Convert.ToInt32(Math.Round(CurrentTime, 2)));
                    IncreaseProgressBar(Pos);
                    if (Pos > 99.99999)
                    {
                        PlayPause.Image = Properties.Resources.play_button;
                        IsPlaying = false;
                    }
                }
                else
                {
                    //ProgressBarFront.Width = ProgressBarBack.Width;
                   // IsLoaded = false;

                    //if (CurrentTime > 5)
                    //{
                    //    this.IsLiveVideo = true;
                    //    GoLive.Visible = true;                        
                    //}
                }
            }
            else
            {
                ProgressBarFront.Width = ProgressBarBack.Width;
                lblTime.Text = GetTimeFromSeconds(Convert.ToInt32(Math.Round(CurrentTime, 2)));
            }
        }

        private void Hide_Popups()
        {
            if (!(VolumeController.ClientRectangle.Contains(VolumeController.PointToClient(Cursor.Position)) || VolumeContainer.ClientRectangle.Contains(VolumeContainer.PointToClient(Cursor.Position))))
            {
                VolumeContainer.Visible = false;
                VolumeContainer.Hide();
            }

            if (!(Settings.ClientRectangle.Contains(Settings.PointToClient(Cursor.Position)) || SettingControls.ClientRectangle.Contains(SettingControls.PointToClient(Cursor.Position))))
            {
                if (!Is_Mouse_Inside_Settings)
                {
                    SettingControls.Visible = false;
                    SettingControls.Hide();
                }
            }
        }
        private string GetTimeFromSeconds(int seconds)
        {
            string time = "";

            TimeSpan span = TimeSpan.FromSeconds(seconds);

            if (span.Hours > 0)
            {
                if (span.Hours < 10) time += "0" + span.Hours + ":";
                else time += span.Hours + ":";
            }
            else
            {
                time += "00:";
            }
            if (span.Minutes > 0)
            {
                if (span.Minutes < 10) time += "0" + span.Minutes + ":";
                else time += span.Minutes + ":";
            }
            else
            {
                time += "00:";
            }
            if (span.Seconds < 10) time += "0" + span.Seconds;
            else time += span.Seconds;

            return time;
        }

        private void IncreaseProgressBar(double Pos)
        {
            if (IsLoaded)
            {
                this.Progress = Pos;

                Pos = (ProgressBarBack.Width * Pos) / 100;
                try
                {
                    ProgressBarFront.Location = ProgressBarBack.Location;
                    ProgressBarFront.Width = Convert.ToInt32(Math.Round(Pos, 2));
                }
                catch { }
            }
        }

        #endregion

        #region Progress Bar Progressing Events

        public double Progress;
        public event EventHandler OnProgressChange;

        private bool IsMouseDown = false;

        private void ProgressBarBack_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsLoaded)
            {
                // MessageBox.Show(((e.Location.X * 100.0) / ProgressBarBack.Width).ToString());
                if (!IsLiveVideo)
                {
                    ChangeProgress(e.Location.X);
                    IsMouseDown = true;
                }
            }
        }
        private void ProgressBarBack_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsLoaded)
            {
                if (!IsLiveVideo)
                {
                    IsMouseDown = false;
                }
            }
        }
        private void ProgressBarBack_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (IsLoaded)
                {
                    if (!IsLiveVideo)
                    {
                        if (IsMouseDown) ChangeProgress(e.Location.X);
                        if (ProgressBarBack.ClientRectangle.Contains(ProgressBarBack.PointToClient(Cursor.Position)))
                        {
                            Display_Time.Visible = true;
                            Display_Time.Text = GetTimeFromSeconds(Convert.ToInt32(Math.Round((e.Location.X * Duration) / ProgressBarBack.Width, 2)));
                            int x = e.Location.X - (Display_Time.Width / 2);
                            Display_Time.Location = new Point(x < 0 ? 0 : x > (ProgressBarBack.Width - Display_Time.Width) ? (ProgressBarBack.Width - Display_Time.Width) : x, ProgressBarBack.Location.Y);
                        }
                    }
                }
            }
            catch { }
        }
        private void ChangeProgress(int Pos)
        {
            if (IsLoaded)
            {
                if (IsLoaded)
                {
                    Pos = Pos < 0 ? 0 : Pos > ProgressBarBack.Width ? ProgressBarBack.Width : Pos;     //Code to normalise position According to ProgressBar Width

                    this.Progress = ((Pos * 100.0) / ProgressBarBack.Width);
                    this.CurrentTime = ((this.Progress * Duration) / 100);
                    ProgressBarFront.Location = ProgressBarBack.Location;
                    ProgressBarFront.Width = Pos;
                    if (this.OnProgressChange != null) this.OnProgressChange(this, null);
                }
            }
        }

        bool Mouse_Over = true;
        Timer Hiding_Display_Time = new Timer();
        private void ProgressBarBack_MouseEnter(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                if (!IsLiveVideo)
                {
                    Mouse_Over = true;

                    Hiding_Display_Time.Interval = 1000;
                    Hiding_Display_Time.Tick += Hiding_Display_Time_Tick;
                    Hiding_Display_Time.Enabled = true;

                    Display_Time.Visible = true;
                }
            }
        }
        private void ProgressBarBack_MouseLeave(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                if (!IsLiveVideo)
                {
                    Mouse_Over = false;
                    Display_Time.Visible = false;
                    Hiding_Display_Time.Enabled = false;
                }
            }
        }
        private void Hiding_Display_Time_Tick(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                if (!IsLiveVideo)
                {
                    if (!ProgressBarBack.ClientRectangle.Contains(ProgressBarBack.PointToClient(Cursor.Position)))
                    {
                        Mouse_Over = false;
                        Display_Time.Visible = false;
                        Hiding_Display_Time.Enabled = false;
                    }
                }
            }
        }
        #endregion

        #region Settings Selection Color Change

        private void HoverColorSetting()
        {
            SettingControls.Renderer = new MyRenderer();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(1, 143, 165); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(1, 143, 165); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(230, 230, 230); }
            }
        }

        #endregion

        #region Setting Controls Adding

        public void AddQuality(string QualityName)
        {
            //ContextMenuStrip item = SettingControls
        }


        #endregion

        private void QualityOptions_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }

}
