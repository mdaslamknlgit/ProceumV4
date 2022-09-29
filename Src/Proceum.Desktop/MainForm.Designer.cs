namespace Proceum
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormContainer = new System.Windows.Forms.Panel();
            this.Rest_container = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StatusDisplayer = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.VideoValidity = new System.Windows.Forms.Label();
            this.CourseValidity = new System.Windows.Forms.Label();
            this.Refrence_Panel = new System.Windows.Forms.Panel();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnPdf = new System.Windows.Forms.Panel();
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.pnPlayer = new System.Windows.Forms.Panel();
            this.pnYoutube = new System.Windows.Forms.Panel();
            this.pncover = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnLoading = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnM3u8 = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.customPanel1 = new Proceum.UserControls.CustomPanel();
            this.UserName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainFormContainer.SuspendLayout();
            this.Rest_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.StatusDisplayer.SuspendLayout();
            this.Refrence_Panel.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.pnPdf.SuspendLayout();
            this.pnPlayer.SuspendLayout();
            this.pnYoutube.SuspendLayout();
            this.pncover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.pnInfo.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormContainer
            // 
            this.MainFormContainer.Controls.Add(this.Rest_container);
            this.MainFormContainer.Controls.Add(this.TopPanel);
            this.MainFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormContainer.Location = new System.Drawing.Point(0, 30);
            this.MainFormContainer.Name = "MainFormContainer";
            this.MainFormContainer.Size = new System.Drawing.Size(1293, 665);
            this.MainFormContainer.TabIndex = 6;
            // 
            // Rest_container
            // 
            this.Rest_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.Rest_container.Controls.Add(this.splitContainer1);
            this.Rest_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rest_container.Location = new System.Drawing.Point(0, 54);
            this.Rest_container.Name = "Rest_container";
            this.Rest_container.Size = new System.Drawing.Size(1293, 611);
            this.Rest_container.TabIndex = 7;
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
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitContainer1.Size = new System.Drawing.Size(1293, 611);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 4);
            this.panel3.TabIndex = 2;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1265, 611);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // StatusDisplayer
            // 
            this.StatusDisplayer.Controls.Add(this.lblTitle);
            this.StatusDisplayer.Controls.Add(this.VideoValidity);
            this.StatusDisplayer.Controls.Add(this.CourseValidity);
            this.StatusDisplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusDisplayer.Location = new System.Drawing.Point(3, 3);
            this.StatusDisplayer.Name = "StatusDisplayer";
            this.StatusDisplayer.Size = new System.Drawing.Size(1259, 49);
            this.StatusDisplayer.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1256, 49);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Video Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VideoValidity
            // 
            this.VideoValidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.VideoValidity.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F);
            this.VideoValidity.ForeColor = System.Drawing.Color.White;
            this.VideoValidity.Location = new System.Drawing.Point(0, 0);
            this.VideoValidity.Name = "VideoValidity";
            this.VideoValidity.Size = new System.Drawing.Size(340, 49);
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
            this.CourseValidity.Location = new System.Drawing.Point(874, 0);
            this.CourseValidity.Margin = new System.Windows.Forms.Padding(0);
            this.CourseValidity.Name = "CourseValidity";
            this.CourseValidity.Size = new System.Drawing.Size(385, 49);
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
            this.Refrence_Panel.Location = new System.Drawing.Point(3, 58);
            this.Refrence_Panel.Name = "Refrence_Panel";
            this.Refrence_Panel.Size = new System.Drawing.Size(1259, 530);
            this.Refrence_Panel.TabIndex = 4;
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.pnContent.BackgroundImage = global::Proceum.Properties.Resources.VideoPlayerBG_without_radius;
            this.pnContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnContent.Controls.Add(this.pnPdf);
            this.pnContent.Controls.Add(this.pnPlayer);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1259, 530);
            this.pnContent.TabIndex = 2;
            // 
            // pnPdf
            // 
            this.pnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
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
            // pnPlayer
            // 
            this.pnPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.pnPlayer.Controls.Add(this.pnYoutube);
            this.pnPlayer.Controls.Add(this.pnM3u8);
            this.pnPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPlayer.Location = new System.Drawing.Point(0, 0);
            this.pnPlayer.Name = "pnPlayer";
            this.pnPlayer.Size = new System.Drawing.Size(1259, 530);
            this.pnPlayer.TabIndex = 5;
            // 
            // pnYoutube
            // 
            this.pnYoutube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.pnYoutube.Controls.Add(this.pncover);
            this.pnYoutube.Controls.Add(this.pnLoading);
            this.pnYoutube.Controls.Add(this.webView21);
            this.pnYoutube.Controls.Add(this.pnInfo);
            this.pnYoutube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnYoutube.Location = new System.Drawing.Point(0, 0);
            this.pnYoutube.Name = "pnYoutube";
            this.pnYoutube.Size = new System.Drawing.Size(1259, 495);
            this.pnYoutube.TabIndex = 3;
            this.pnYoutube.Visible = false;
            // 
            // pncover
            // 
            this.pncover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.pncover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pncover.Controls.Add(this.pictureBox4);
            this.pncover.Location = new System.Drawing.Point(47, 109);
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
            // pnLoading
            // 
            this.pnLoading.Controls.Add(this.pictureBox3);
            this.pnLoading.Location = new System.Drawing.Point(20, 14);
            this.pnLoading.Name = "pnLoading";
            this.pnLoading.Size = new System.Drawing.Size(70, 70);
            this.pnLoading.TabIndex = 6;
            this.pnLoading.Visible = false;
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
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1259, 495);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
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
            // pnM3u8
            // 
            this.pnM3u8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.pnM3u8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnM3u8.Location = new System.Drawing.Point(0, 495);
            this.pnM3u8.Name = "pnM3u8";
            this.pnM3u8.Size = new System.Drawing.Size(1259, 35);
            this.pnM3u8.TabIndex = 3;
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
            this.TopPanel.Size = new System.Drawing.Size(1293, 54);
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
            this.customPanel1.Location = new System.Drawing.Point(28, 12);
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
            this.pictureBox2.Location = new System.Drawing.Point(1258, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1293, 695);
            this.Controls.Add(this.MainFormContainer);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainFormContainer.ResumeLayout(false);
            this.Rest_container.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.StatusDisplayer.ResumeLayout(false);
            this.Refrence_Panel.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnPdf.ResumeLayout(false);
            this.pnPlayer.ResumeLayout(false);
            this.pnYoutube.ResumeLayout(false);
            this.pncover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainFormContainer;
        private System.Windows.Forms.Panel Rest_container;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel StatusDisplayer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label VideoValidity;
        private System.Windows.Forms.Label CourseValidity;
        private System.Windows.Forms.Panel Refrence_Panel;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel pnPdf;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Panel pnPlayer;
        private System.Windows.Forms.Panel pnYoutube;
        private System.Windows.Forms.Panel pncover;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnLoading;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnM3u8;
        private System.Windows.Forms.Panel TopPanel;
        private UserControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}