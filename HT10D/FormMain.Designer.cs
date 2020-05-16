namespace HT10D
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.trackBar_AViewPoint = new System.Windows.Forms.TrackBar();
            this.ucAView = new HT10D.UCAView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AViewPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(542, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(896, 12);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(113, 38);
            this.button_OpenFile.TabIndex = 1;
            this.button_OpenFile.Text = "OpenFile";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // trackBar_AViewPoint
            // 
            this.trackBar_AViewPoint.AutoSize = false;
            this.trackBar_AViewPoint.Enabled = false;
            this.trackBar_AViewPoint.LargeChange = 1;
            this.trackBar_AViewPoint.Location = new System.Drawing.Point(12, 402);
            this.trackBar_AViewPoint.Maximum = 0;
            this.trackBar_AViewPoint.Name = "trackBar_AViewPoint";
            this.trackBar_AViewPoint.Size = new System.Drawing.Size(512, 20);
            this.trackBar_AViewPoint.TabIndex = 3;
            this.trackBar_AViewPoint.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_AViewPoint.Scroll += new System.EventHandler(this.trackBar_AViewPoint_Scroll);
            // 
            // ucAView
            // 
            this.ucAView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAView.Location = new System.Drawing.Point(12, 56);
            this.ucAView.mEnvelope = false;
            this.ucAView.mHT10D_Info = null;
            this.ucAView.Name = "ucAView";
            this.ucAView.PlayPoint = 0;
            this.ucAView.Size = new System.Drawing.Size(512, 340);
            this.ucAView.StartPoint = 0;
            this.ucAView.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1021, 513);
            this.Controls.Add(this.trackBar_AViewPoint);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucAView);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AViewPoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_OpenFile;
        private UCAView ucAView;
        private System.Windows.Forms.TrackBar trackBar_AViewPoint;
    }
}

