namespace Proceum.Customer_cloud.Controls
{
    partial class Player_Controls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WatchTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.SettingControls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SpeedOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.QualityOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftGap = new System.Windows.Forms.Panel();
            this.RightGap = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Display_Time = new System.Windows.Forms.Label();
            this.ProgressBarFront = new System.Windows.Forms.PictureBox();
            this.ProgressBarBack = new System.Windows.Forms.PictureBox();
            this.Pn_GoLive = new System.Windows.Forms.Panel();
            this.GoLive = new System.Windows.Forms.Button();
            this.VolumeController = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.FullScreen = new System.Windows.Forms.PictureBox();
            this.PlayPause = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SettingControls.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarBack)).BeginInit();
            this.Pn_GoLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPause)).BeginInit();
            this.SuspendLayout();
            // 
            // WatchTimer
            // 
            this.WatchTimer.Interval = 1000;
            this.WatchTimer.Tick += new System.EventHandler(this.WatchTimer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTime.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(53, 0);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(117, 49);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblTime, "Video Timer");
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // SettingControls
            // 
            this.SettingControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SettingControls.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.SettingControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpeedOptions,
            this.QualityOptions});
            this.SettingControls.Name = "contextMenuStrip1";
            this.SettingControls.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SettingControls.ShowImageMargin = false;
            this.SettingControls.Size = new System.Drawing.Size(119, 64);
            // 
            // SpeedOptions
            // 
            this.SpeedOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.SpeedOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.xToolStripMenuItem1,
            this.xToolStripMenuItem2,
            this.xToolStripMenuItem3,
            this.xToolStripMenuItem4});
            this.SpeedOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedOptions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpeedOptions.Name = "SpeedOptions";
            this.SpeedOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SpeedOptions.Size = new System.Drawing.Size(118, 30);
            this.SpeedOptions.Text = "Speed";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.xToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.xToolStripMenuItem.Text = "0.50x";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem1
            // 
            this.xToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.xToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Size = new System.Drawing.Size(138, 30);
            this.xToolStripMenuItem1.Text = "0.75x";
            this.xToolStripMenuItem1.Click += new System.EventHandler(this.xToolStripMenuItem1_Click);
            // 
            // xToolStripMenuItem2
            // 
            this.xToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.xToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(97)))), ((int)(((byte)(123)))));
            this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            this.xToolStripMenuItem2.Size = new System.Drawing.Size(138, 30);
            this.xToolStripMenuItem2.Text = "1x";
            this.xToolStripMenuItem2.Click += new System.EventHandler(this.xToolStripMenuItem2_Click);
            // 
            // xToolStripMenuItem3
            // 
            this.xToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.xToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xToolStripMenuItem3.Name = "xToolStripMenuItem3";
            this.xToolStripMenuItem3.Size = new System.Drawing.Size(138, 30);
            this.xToolStripMenuItem3.Text = "1.5x";
            this.xToolStripMenuItem3.Click += new System.EventHandler(this.xToolStripMenuItem3_Click);
            // 
            // xToolStripMenuItem4
            // 
            this.xToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.xToolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xToolStripMenuItem4.Name = "xToolStripMenuItem4";
            this.xToolStripMenuItem4.Size = new System.Drawing.Size(138, 30);
            this.xToolStripMenuItem4.Text = "2x";
            this.xToolStripMenuItem4.Click += new System.EventHandler(this.xToolStripMenuItem4_Click);
            // 
            // QualityOptions
            // 
            this.QualityOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.QualityOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pToolStripMenuItem,
            this.pToolStripMenuItem2,
            this.pToolStripMenuItem3,
            this.pToolStripMenuItem4,
            this.pToolStripMenuItem1});
            this.QualityOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QualityOptions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QualityOptions.Name = "QualityOptions";
            this.QualityOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QualityOptions.Size = new System.Drawing.Size(118, 30);
            this.QualityOptions.Text = "Quality";
            this.QualityOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.QualityOptions.Click += new System.EventHandler(this.QualityOptions_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(97)))), ((int)(((byte)(123)))));
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
            this.pToolStripMenuItem.Text = "Auto";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // pToolStripMenuItem2
            // 
            this.pToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pToolStripMenuItem2.Name = "pToolStripMenuItem2";
            this.pToolStripMenuItem2.Size = new System.Drawing.Size(134, 30);
            this.pToolStripMenuItem2.Text = "240p";
            this.pToolStripMenuItem2.Visible = false;
            this.pToolStripMenuItem2.Click += new System.EventHandler(this.pToolStripMenuItem2_Click);
            // 
            // pToolStripMenuItem3
            // 
            this.pToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pToolStripMenuItem3.Name = "pToolStripMenuItem3";
            this.pToolStripMenuItem3.Size = new System.Drawing.Size(134, 30);
            this.pToolStripMenuItem3.Text = "360p";
            this.pToolStripMenuItem3.Visible = false;
            this.pToolStripMenuItem3.Click += new System.EventHandler(this.pToolStripMenuItem3_Click);
            // 
            // pToolStripMenuItem4
            // 
            this.pToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pToolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pToolStripMenuItem4.Name = "pToolStripMenuItem4";
            this.pToolStripMenuItem4.Size = new System.Drawing.Size(134, 30);
            this.pToolStripMenuItem4.Text = "480p";
            this.pToolStripMenuItem4.Click += new System.EventHandler(this.pToolStripMenuItem4_Click);
            // 
            // pToolStripMenuItem1
            // 
            this.pToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pToolStripMenuItem1.Name = "pToolStripMenuItem1";
            this.pToolStripMenuItem1.Size = new System.Drawing.Size(134, 30);
            this.pToolStripMenuItem1.Text = "720p";
            this.pToolStripMenuItem1.Click += new System.EventHandler(this.pToolStripMenuItem1_Click);
            // 
            // LeftGap
            // 
            this.LeftGap.BackColor = System.Drawing.Color.Transparent;
            this.LeftGap.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftGap.Location = new System.Drawing.Point(170, 0);
            this.LeftGap.Margin = new System.Windows.Forms.Padding(4);
            this.LeftGap.Name = "LeftGap";
            this.LeftGap.Size = new System.Drawing.Size(16, 49);
            this.LeftGap.TabIndex = 7;
            // 
            // RightGap
            // 
            this.RightGap.BackColor = System.Drawing.Color.Transparent;
            this.RightGap.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightGap.Location = new System.Drawing.Point(989, 0);
            this.RightGap.Margin = new System.Windows.Forms.Padding(4);
            this.RightGap.Name = "RightGap";
            this.RightGap.Size = new System.Drawing.Size(19, 49);
            this.RightGap.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Display_Time);
            this.panel1.Controls.Add(this.ProgressBarFront);
            this.panel1.Controls.Add(this.ProgressBarBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(186, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 49);
            this.panel1.TabIndex = 13;
            // 
            // Display_Time
            // 
            this.Display_Time.AutoSize = true;
            this.Display_Time.BackColor = System.Drawing.Color.White;
            this.Display_Time.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(118)))), ((int)(((byte)(140)))));
            this.Display_Time.Location = new System.Drawing.Point(200, 2);
            this.Display_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Display_Time.Name = "Display_Time";
            this.Display_Time.Size = new System.Drawing.Size(72, 23);
            this.Display_Time.TabIndex = 7;
            this.Display_Time.Text = "00:00:00";
            this.Display_Time.Visible = false;
            // 
            // ProgressBarFront
            // 
            this.ProgressBarFront.Image = global::Proceum.Properties.Resources.video_bar_green;
            this.ProgressBarFront.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarFront.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBarFront.Name = "ProgressBarFront";
            this.ProgressBarFront.Padding = new System.Windows.Forms.Padding(0, 25, 0, 15);
            this.ProgressBarFront.Size = new System.Drawing.Size(0, 49);
            this.ProgressBarFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProgressBarFront.TabIndex = 6;
            this.ProgressBarFront.TabStop = false;
            this.ProgressBarFront.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseDown);
            this.ProgressBarFront.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseMove);
            this.ProgressBarFront.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseUp);
            // 
            // ProgressBarBack
            // 
            this.ProgressBarBack.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBarBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProgressBarBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBarBack.Image = global::Proceum.Properties.Resources.video_bar_white_outline;
            this.ProgressBarBack.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarBack.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBarBack.Name = "ProgressBarBack";
            this.ProgressBarBack.Padding = new System.Windows.Forms.Padding(0, 25, 0, 15);
            this.ProgressBarBack.Size = new System.Drawing.Size(803, 49);
            this.ProgressBarBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProgressBarBack.TabIndex = 5;
            this.ProgressBarBack.TabStop = false;
            this.ProgressBarBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseDown);
            this.ProgressBarBack.MouseEnter += new System.EventHandler(this.ProgressBarBack_MouseEnter);
            this.ProgressBarBack.MouseLeave += new System.EventHandler(this.ProgressBarBack_MouseLeave);
            this.ProgressBarBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseMove);
            this.ProgressBarBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseUp);
            // 
            // Pn_GoLive
            // 
            this.Pn_GoLive.BackColor = System.Drawing.Color.Transparent;
            this.Pn_GoLive.Controls.Add(this.GoLive);
            this.Pn_GoLive.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pn_GoLive.Location = new System.Drawing.Point(1008, 0);
            this.Pn_GoLive.Margin = new System.Windows.Forms.Padding(4);
            this.Pn_GoLive.Name = "Pn_GoLive";
            this.Pn_GoLive.Size = new System.Drawing.Size(117, 49);
            this.Pn_GoLive.TabIndex = 11;
            // 
            // GoLive
            // 
            this.GoLive.BackgroundImage = global::Proceum.Properties.Resources.go_live;
            this.GoLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoLive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoLive.FlatAppearance.BorderSize = 0;
            this.GoLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoLive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoLive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(118)))), ((int)(((byte)(140)))));
            this.GoLive.Location = new System.Drawing.Point(9, 7);
            this.GoLive.Margin = new System.Windows.Forms.Padding(4);
            this.GoLive.Name = "GoLive";
            this.GoLive.Size = new System.Drawing.Size(96, 34);
            this.GoLive.TabIndex = 0;
            this.GoLive.Text = "Go Live";
            this.toolTip1.SetToolTip(this.GoLive, "Go To Live Video");
            this.GoLive.UseVisualStyleBackColor = true;
            this.GoLive.Visible = false;
            this.GoLive.Click += new System.EventHandler(this.GoLive_Click);
            // 
            // VolumeController
            // 
            this.VolumeController.BackColor = System.Drawing.Color.Transparent;
            this.VolumeController.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VolumeController.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeController.Dock = System.Windows.Forms.DockStyle.Right;
            this.VolumeController.Image = global::Proceum.Properties.Resources.volume;
            this.VolumeController.Location = new System.Drawing.Point(1125, 0);
            this.VolumeController.Margin = new System.Windows.Forms.Padding(0);
            this.VolumeController.Name = "VolumeController";
            this.VolumeController.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.VolumeController.Size = new System.Drawing.Size(53, 49);
            this.VolumeController.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VolumeController.TabIndex = 3;
            this.VolumeController.TabStop = false;
            this.toolTip1.SetToolTip(this.VolumeController, "Speaker");
            this.VolumeController.Click += new System.EventHandler(this.VolumeController_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.Settings.Image = global::Proceum.Properties.Resources.gear_option;
            this.Settings.Location = new System.Drawing.Point(1178, 0);
            this.Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Settings.Size = new System.Drawing.Size(53, 49);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Settings.TabIndex = 2;
            this.Settings.TabStop = false;
            this.toolTip1.SetToolTip(this.Settings, "Video Setting");
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // FullScreen
            // 
            this.FullScreen.BackColor = System.Drawing.Color.Transparent;
            this.FullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.FullScreen.Image = global::Proceum.Properties.Resources.switch_to_full_screen_button;
            this.FullScreen.Location = new System.Drawing.Point(1231, 0);
            this.FullScreen.Margin = new System.Windows.Forms.Padding(0);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.FullScreen.Size = new System.Drawing.Size(53, 49);
            this.FullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FullScreen.TabIndex = 1;
            this.FullScreen.TabStop = false;
            this.toolTip1.SetToolTip(this.FullScreen, "Full Screen");
            this.FullScreen.Click += new System.EventHandler(this.FullScreen_Click);
            this.FullScreen.DoubleClick += new System.EventHandler(this.FullScreen_Click);
            // 
            // PlayPause
            // 
            this.PlayPause.BackColor = System.Drawing.Color.Transparent;
            this.PlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlayPause.Image = global::Proceum.Properties.Resources.pause;
            this.PlayPause.Location = new System.Drawing.Point(0, 0);
            this.PlayPause.Margin = new System.Windows.Forms.Padding(0);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.PlayPause.Size = new System.Drawing.Size(53, 49);
            this.PlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayPause.TabIndex = 0;
            this.PlayPause.TabStop = false;
            this.toolTip1.SetToolTip(this.PlayPause, "Play/Pause");
            this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
            this.PlayPause.DoubleClick += new System.EventHandler(this.PlayPause_Click);
            // 
            // Player_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RightGap);
            this.Controls.Add(this.Pn_GoLive);
            this.Controls.Add(this.LeftGap);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.VolumeController);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.FullScreen);
            this.Controls.Add(this.PlayPause);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Player_Controls";
            this.Size = new System.Drawing.Size(1284, 49);
            this.Load += new System.EventHandler(this.Player_Controls_Load);
            this.SettingControls.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarBack)).EndInit();
            this.Pn_GoLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayPause;
        private System.Windows.Forms.PictureBox FullScreen;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.Timer WatchTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ContextMenuStrip SettingControls;
        private System.Windows.Forms.ToolStripMenuItem SpeedOptions;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem QualityOptions;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem4;
        private System.Windows.Forms.PictureBox ProgressBarBack;
        private System.Windows.Forms.PictureBox ProgressBarFront;
        private System.Windows.Forms.Panel LeftGap;
        private System.Windows.Forms.PictureBox VolumeController;
        private System.Windows.Forms.Panel RightGap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem1;
        private System.Windows.Forms.Label Display_Time;
        private System.Windows.Forms.Panel Pn_GoLive;
        private System.Windows.Forms.Button GoLive;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
