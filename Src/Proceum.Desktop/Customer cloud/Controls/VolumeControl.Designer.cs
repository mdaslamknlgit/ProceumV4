namespace Proceum.Customer_cloud.Controls
{
    partial class VolumeControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.VolumeFront = new System.Windows.Forms.PictureBox();
            this.VolumeBack = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 17);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 17);
            this.panel2.TabIndex = 1;
            this.panel2.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.VolumeFront);
            this.panel3.Controls.Add(this.VolumeBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 119);
            this.panel3.TabIndex = 2;
            this.panel3.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // VolumeFront
            // 
            this.VolumeFront.Image = global::Proceum.Properties.Resources.Volume_Back;
            this.VolumeFront.Location = new System.Drawing.Point(0, 63);
            this.VolumeFront.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VolumeFront.Name = "VolumeFront";
            this.VolumeFront.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.VolumeFront.Size = new System.Drawing.Size(43, 55);
            this.VolumeFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VolumeFront.TabIndex = 1;
            this.VolumeFront.TabStop = false;
            this.VolumeFront.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseDown);
            this.VolumeFront.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.VolumeFront.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.VolumeFront.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseMove);
            this.VolumeFront.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseUp);
            // 
            // VolumeBack
            // 
            this.VolumeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VolumeBack.Image = global::Proceum.Properties.Resources.Volume_Front_Green;
            this.VolumeBack.Location = new System.Drawing.Point(0, 0);
            this.VolumeBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VolumeBack.Name = "VolumeBack";
            this.VolumeBack.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.VolumeBack.Size = new System.Drawing.Size(43, 119);
            this.VolumeBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VolumeBack.TabIndex = 0;
            this.VolumeBack.TabStop = false;
            this.VolumeBack.Click += new System.EventHandler(this.VolumeBack_Click);
            this.VolumeBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseDown);
            this.VolumeBack.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.VolumeBack.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.VolumeBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseMove);
            this.VolumeBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarBack_MouseUp);
            // 
            // VolumeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VolumeControl";
            this.Size = new System.Drawing.Size(43, 153);
            this.Load += new System.EventHandler(this.VolumeControl_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox VolumeBack;
        private System.Windows.Forms.PictureBox VolumeFront;
    }
}
