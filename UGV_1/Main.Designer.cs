namespace UGV_1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Dog_timer = new System.Windows.Forms.Timer(this.components);
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.Video = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).BeginInit();
            this.SuspendLayout();
            // 
            // Dog_timer
            // 
            this.Dog_timer.Interval = 200;
            this.Dog_timer.Tick += new System.EventHandler(this.Dog_timer_tick);
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(1366, 768);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // Video
            // 
            this.Video.BackColor = System.Drawing.Color.Transparent;
            this.Video.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Video.BackgroundImage")));
            this.Video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Video.Location = new System.Drawing.Point(20, 2);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(110, 90);
            this.Video.TabIndex = 22;
            this.Video.TabStop = false;
            this.Video.Click += new System.EventHandler(this.Video_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.axVLCPlugin21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Dog_timer;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.PictureBox Video;
    }
}