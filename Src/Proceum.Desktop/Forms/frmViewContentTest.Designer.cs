namespace Proceum.Forms
{
    partial class frmViewContent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewContent));
            this.imageListLime = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Content_Category = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StatusDisplayer = new System.Windows.Forms.Panel();
            this.VideoValidity = new System.Windows.Forms.Label();
            this.CourseValidity = new System.Windows.Forms.Label();
            this.Refrence_Panel = new System.Windows.Forms.Panel();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnPdf = new System.Windows.Forms.Panel();
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.pnLoading = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnPlayer = new System.Windows.Forms.Panel();
            this.pnYoutube = new System.Windows.Forms.Panel();
            this.pncover = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnM3u8 = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.Blinker = new System.Windows.Forms.Timer(this.components);
            this.FullScreenPanel = new System.Windows.Forms.Panel();
            this.VideoValidityTimer = new System.Windows.Forms.Timer(this.components);
            this.VideoTimeUpdatingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.MainSettingMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundPDFDownloader = new System.ComponentModel.BackgroundWorker();
            this.Video_Menu_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoIDHolder = new System.Windows.Forms.Label();
            this.Rest_container = new System.Windows.Forms.Panel();
            this.MainFormContainer = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.customPanel1 = new Proceum.UserControls.CustomPanel();
            this.UserName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bwLoadContent = new System.ComponentModel.BackgroundWorker();
            this.TimerValidityUpdate = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.StatusDisplayer.SuspendLayout();
            this.Refrence_Panel.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.pnPdf.SuspendLayout();
            this.pnLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnPlayer.SuspendLayout();
            this.pnYoutube.SuspendLayout();
            this.pncover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.pnInfo.SuspendLayout();
            this.MainSettingMenuStrip.SuspendLayout();
            this.Video_Menu_Strip.SuspendLayout();
            this.Rest_container.SuspendLayout();
            this.MainFormContainer.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListLime
            // 
            this.imageListLime.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLime.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListLime.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plus_on.png");
            this.imageList1.Images.SetKeyName(1, "minus_off.png");
            this.imageList1.Images.SetKeyName(2, "play_video.png");
            this.imageList1.Images.SetKeyName(3, "pouse_video.png");
            this.imageList1.Images.SetKeyName(4, "pdf_1.png");
            this.imageList1.Images.SetKeyName(5, "pdf_open.png");
            this.imageList1.Images.SetKeyName(6, "ppt.png");
            this.imageList1.Images.SetKeyName(7, "eye.png");
            this.imageList1.Images.SetKeyName(8, "plus_on_live.png");
            this.imageList1.Images.SetKeyName(9, "minus_off_active.png");
            this.imageList1.Images.SetKeyName(10, "play_Video_active.png");
            this.imageList1.Images.SetKeyName(11, "pouse_video_active.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.Content_Category);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitContainer1.Size = new System.Drawing.Size(1224, 520);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.Black;
            this.treeView1.HideSelection = false;
            this.treeView1.HotTracking = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 32;
            this.treeView1.ItemHeight = 40;
            this.treeView1.Location = new System.Drawing.Point(0, 39);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 7;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(25, 481);
            this.treeView1.StateImageList = this.imageListLime;
            this.treeView1.TabIndex = 0;
            this.treeView1.TabStop = false;
            this.treeView1.Visible = false;
            this.treeView1.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView1_DrawNode);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 4);
            this.panel3.TabIndex = 2;
            // 
            // Content_Category
            // 
            this.Content_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.Content_Category.Dock = System.Windows.Forms.DockStyle.Top;
            this.Content_Category.Location = new System.Drawing.Point(0, 0);
            this.Content_Category.Margin = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Content_Category.MinimumSize = new System.Drawing.Size(0, 35);
            this.Content_Category.Name = "Content_Category";
            this.Content_Category.Size = new System.Drawing.Size(25, 35);
            this.Content_Category.TabIndex = 1;
            this.Content_Category.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::Proceum.Properties.Resources.VideoPlayerBG_without_radius;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.StatusDisplayer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Refrence_Panel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1196, 520);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // StatusDisplayer
            // 
            this.StatusDisplayer.Controls.Add(this.VideoValidity);
            this.StatusDisplayer.Controls.Add(this.CourseValidity);
            this.StatusDisplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusDisplayer.Location = new System.Drawing.Point(3, 3);
            this.StatusDisplayer.Name = "StatusDisplayer";
            this.StatusDisplayer.Size = new System.Drawing.Size(1190, 2);
            this.StatusDisplayer.TabIndex = 3;
            this.StatusDisplayer.Visible = false;
            // 
            // VideoValidity
            // 
            this.VideoValidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.VideoValidity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoValidity.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F);
            this.VideoValidity.ForeColor = System.Drawing.Color.White;
            this.VideoValidity.Location = new System.Drawing.Point(0, 0);
            this.VideoValidity.Name = "VideoValidity";
            this.VideoValidity.Size = new System.Drawing.Size(805, 2);
            this.VideoValidity.TabIndex = 12;
            this.VideoValidity.Text = "Video Validity";
            this.VideoValidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VideoValidity.Visible = false;
            // 
            // CourseValidity
            // 
            this.CourseValidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.CourseValidity.Dock = System.Windows.Forms.DockStyle.Right;
            this.CourseValidity.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseValidity.ForeColor = System.Drawing.Color.White;
            this.CourseValidity.Location = new System.Drawing.Point(805, 0);
            this.CourseValidity.Margin = new System.Windows.Forms.Padding(0);
            this.CourseValidity.Name = "CourseValidity";
            this.CourseValidity.Size = new System.Drawing.Size(385, 2);
            this.CourseValidity.TabIndex = 10;
            this.CourseValidity.Text = "Course Validity :- ";
            this.CourseValidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CourseValidity.Visible = false;
            // 
            // Refrence_Panel
            // 
            this.Refrence_Panel.BackgroundImage = global::Proceum.Properties.Resources.VideoPlayerBG_without_radius;
            this.Refrence_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Refrence_Panel.Controls.Add(this.pnContent);
            this.Refrence_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Refrence_Panel.Location = new System.Drawing.Point(3, 11);
            this.Refrence_Panel.Name = "Refrence_Panel";
            this.Refrence_Panel.Size = new System.Drawing.Size(1190, 486);
            this.Refrence_Panel.TabIndex = 4;
            this.Refrence_Panel.Resize += new System.EventHandler(this.Refrence_Panel_Resize);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.White;
            this.pnContent.BackgroundImage = global::Proceum.Properties.Resources.VideoPlayerBG_without_radius;
            this.pnContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnContent.Controls.Add(this.pnPdf);
            this.pnContent.Controls.Add(this.pnLoading);
            this.pnContent.Controls.Add(this.pnPlayer);
            this.pnContent.Controls.Add(this.pnInfo);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1190, 486);
            this.pnContent.TabIndex = 2;
            // 
            // pnPdf
            // 
            this.pnPdf.Controls.Add(this.pdfViewer1);
            this.pnPdf.Location = new System.Drawing.Point(202, 14);
            this.pnPdf.Margin = new System.Windows.Forms.Padding(2);
            this.pnPdf.Name = "pnPdf";
            this.pnPdf.Size = new System.Drawing.Size(106, 83);
            this.pnPdf.TabIndex = 7;
            this.pnPdf.Visible = false;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.ShowBookmarks = false;
            this.pdfViewer1.ShowToolbar = false;
            this.pdfViewer1.Size = new System.Drawing.Size(106, 83);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.Visible = false;
            this.pdfViewer1.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            // 
            // pnLoading
            // 
            this.pnLoading.Controls.Add(this.pictureBox3);
            this.pnLoading.Location = new System.Drawing.Point(20, 14);
            this.pnLoading.Name = "pnLoading";
            this.pnLoading.Size = new System.Drawing.Size(70, 70);
            this.pnLoading.TabIndex = 6;
            this.pnLoading.Visible = false;
            this.pnLoading.VisibleChanged += new System.EventHandler(this.pnLoading_VisibleChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnPlayer
            // 
            this.pnPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.pnPlayer.Controls.Add(this.pnYoutube);
            this.pnPlayer.Controls.Add(this.pnM3u8);
            this.pnPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPlayer.Location = new System.Drawing.Point(0, 0);
            this.pnPlayer.Name = "pnPlayer";
            this.pnPlayer.Size = new System.Drawing.Size(1190, 486);
            this.pnPlayer.TabIndex = 5;
            this.pnPlayer.Resize += new System.EventHandler(this.pnPlayer_Resize);
            // 
            // pnYoutube
            // 
            this.pnYoutube.Controls.Add(this.pncover);
            this.pnYoutube.Controls.Add(this.webView21);
            this.pnYoutube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnYoutube.Location = new System.Drawing.Point(0, 0);
            this.pnYoutube.Name = "pnYoutube";
            this.pnYoutube.Size = new System.Drawing.Size(1190, 451);
            this.pnYoutube.TabIndex = 3;
            this.pnYoutube.Visible = false;
            // 
            // pncover
            // 
            this.pncover.BackColor = System.Drawing.Color.Transparent;
            this.pncover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pncover.Controls.Add(this.pictureBox4);
            this.pncover.Location = new System.Drawing.Point(3, 8);
            this.pncover.Name = "pncover";
            this.pncover.Size = new System.Drawing.Size(119, 81);
            this.pncover.TabIndex = 1;
            this.pncover.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(119, 81);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1190, 451);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webView21_CoreWebView2InitializationCompleted);
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView21_NavigationCompleted);
            // 
            // pnM3u8
            // 
            this.pnM3u8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnM3u8.Location = new System.Drawing.Point(0, 451);
            this.pnM3u8.Name = "pnM3u8";
            this.pnM3u8.Size = new System.Drawing.Size(1190, 35);
            this.pnM3u8.TabIndex = 3;
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.lblInfo);
            this.pnInfo.Location = new System.Drawing.Point(107, 14);
            this.pnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(76, 74);
            this.pnInfo.TabIndex = 0;
            this.pnInfo.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(18, 19);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "...";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Blinker
            // 
            this.Blinker.Interval = 1000;
            this.Blinker.Tick += new System.EventHandler(this.Blinker_Tick);
            // 
            // FullScreenPanel
            // 
            this.FullScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.FullScreenPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullScreenPanel.Location = new System.Drawing.Point(1079, 601);
            this.FullScreenPanel.Name = "FullScreenPanel";
            this.FullScreenPanel.Size = new System.Drawing.Size(83, 36);
            this.FullScreenPanel.TabIndex = 7;
            this.FullScreenPanel.Visible = false;
            // 
            // VideoValidityTimer
            // 
            this.VideoValidityTimer.Interval = 1000;
            this.VideoValidityTimer.Tick += new System.EventHandler(this.VideoValidityTimer_Tick);
            // 
            // VideoTimeUpdatingBackgroundWorker
            // 
            this.VideoTimeUpdatingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.VideoTimeUpdatingBackgroundWorker_DoWork);
            // 
            // MainSettingMenuStrip
            // 
            this.MainSettingMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainSettingMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutToolStripMenuItem,
            this.RefreshCoursesToolStripMenuItem,
            this.resetPasswordToolStripMenuItem});
            this.MainSettingMenuStrip.Name = "contextMenuStrip1";
            this.MainSettingMenuStrip.Size = new System.Drawing.Size(218, 94);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LogoutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.LogoutToolStripMenuItem.Text = "Logout";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // RefreshCoursesToolStripMenuItem
            // 
            this.RefreshCoursesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RefreshCoursesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshCoursesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshCoursesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.RefreshCoursesToolStripMenuItem.Name = "RefreshCoursesToolStripMenuItem";
            this.RefreshCoursesToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.RefreshCoursesToolStripMenuItem.Text = "Refresh Courses";
            this.RefreshCoursesToolStripMenuItem.Click += new System.EventHandler(this.RefreshCoursesToolStripMenuItem_Click);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.resetPasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // BackgroundPDFDownloader
            // 
            this.BackgroundPDFDownloader.WorkerSupportsCancellation = true;
            this.BackgroundPDFDownloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundPDFDownloader_DoWork);
            // 
            // Video_Menu_Strip
            // 
            this.Video_Menu_Strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Video_Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.Video_Menu_Strip.Name = "Video_Menu_Strip";
            this.Video_Menu_Strip.Size = new System.Drawing.Size(223, 34);
            this.Video_Menu_Strip.Opening += new System.ComponentModel.CancelEventHandler(this.Video_Menu_Strip_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 30);
            this.toolStripMenuItem1.Text = "Download Video";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // VideoIDHolder
            // 
            this.VideoIDHolder.BackColor = System.Drawing.Color.Transparent;
            this.VideoIDHolder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoIDHolder.Location = new System.Drawing.Point(897, 601);
            this.VideoIDHolder.Name = "VideoIDHolder";
            this.VideoIDHolder.Size = new System.Drawing.Size(120, 20);
            this.VideoIDHolder.TabIndex = 3;
            this.VideoIDHolder.Text = "Video ID Holder";
            this.VideoIDHolder.Visible = false;
            // 
            // Rest_container
            // 
            this.Rest_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.Rest_container.Controls.Add(this.splitContainer1);
            this.Rest_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rest_container.Location = new System.Drawing.Point(0, 54);
            this.Rest_container.Name = "Rest_container";
            this.Rest_container.Size = new System.Drawing.Size(1224, 520);
            this.Rest_container.TabIndex = 7;
            // 
            // MainFormContainer
            // 
            this.MainFormContainer.Controls.Add(this.Rest_container);
            this.MainFormContainer.Controls.Add(this.TopPanel);
            this.MainFormContainer.Location = new System.Drawing.Point(0, 0);
            this.MainFormContainer.Name = "MainFormContainer";
            this.MainFormContainer.Size = new System.Drawing.Size(1224, 574);
            this.MainFormContainer.TabIndex = 5;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.Controls.Add(this.customPanel1);
            this.TopPanel.Controls.Add(this.pictureBox2);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1224, 54);
            this.TopPanel.TabIndex = 6;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.customPanel1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.customPanel1.BorderRadius = 12;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.UserName);
            this.customPanel1.Location = new System.Drawing.Point(15, 12);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(368, 37);
            this.customPanel1.TabIndex = 3;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Microsoft PhagsPa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(8, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(335, 37);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Welcome: Proceum Student";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Proceum.Properties.Resources.cross;
            this.pictureBox2.Location = new System.Drawing.Point(1189, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Close");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bwLoadContent
            // 
            this.bwLoadContent.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadContent_DoWork);
            this.bwLoadContent.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadContent_RunWorkerCompleted);
            // 
            // TimerValidityUpdate
            // 
            this.TimerValidityUpdate.Interval = 1000;
            this.TimerValidityUpdate.Tick += new System.EventHandler(this.TimerValidityUpdate_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmViewContent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = global::Proceum.Properties.Resources.VideoPlayerBG_without_radius;
            this.BackMaxSize = 1244;
            this.ClientSize = new System.Drawing.Size(1227, 656);
            this.ControlBox = false;
            this.Controls.Add(this.FullScreenPanel);
            this.Controls.Add(this.MainFormContainer);
            this.Controls.Add(this.VideoIDHolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewContent";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 16);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Activated += new System.EventHandler(this.first_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewContent_FormClosing);
            this.Load += new System.EventHandler(this.frmViewContent_Load);
            this.SizeChanged += new System.EventHandler(this.frmViewContent_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.StatusDisplayer.ResumeLayout(false);
            this.Refrence_Panel.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnPdf.ResumeLayout(false);
            this.pnLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnPlayer.ResumeLayout(false);
            this.pnYoutube.ResumeLayout(false);
            this.pncover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.MainSettingMenuStrip.ResumeLayout(false);
            this.Video_Menu_Strip.ResumeLayout(false);
            this.Rest_container.ResumeLayout(false);
            this.MainFormContainer.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageListLime;
        private System.Windows.Forms.SplitContainer splitContainer1;
        //private Proceum.Customer_cloud.Controls.CustomTreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label VideoIDHolder;
        private System.Windows.Forms.Timer Blinker;
        private System.Windows.Forms.Panel FullScreenPanel;
        private System.Windows.Forms.Timer VideoValidityTimer;
        private System.ComponentModel.BackgroundWorker VideoTimeUpdatingBackgroundWorker;
        private System.Windows.Forms.ContextMenuStrip MainSettingMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RefreshCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker BackgroundPDFDownloader;
        private System.Windows.Forms.Panel StatusDisplayer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip Video_Menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel Rest_container;
        private System.Windows.Forms.Panel MainFormContainer;
        private System.Windows.Forms.ToolTip toolTip1;
      
        private System.ComponentModel.BackgroundWorker bwLoadContent;
        private System.Windows.Forms.Timer TimerValidityUpdate;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel Content_Category;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label VideoValidity;
        private System.Windows.Forms.Label CourseValidity;
        private System.Windows.Forms.Panel Refrence_Panel;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel pnPdf;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Panel pnLoading;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnPlayer;
        private System.Windows.Forms.Panel pnYoutube;
        private System.Windows.Forms.Panel pncover;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel pnM3u8;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lblInfo;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private UserControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label UserName;
    }
}