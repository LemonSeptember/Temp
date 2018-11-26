namespace Screen1
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
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.picScreen = new System.Windows.Forms.PictureBox();
            this.lblScreenStartPoint = new System.Windows.Forms.Label();
            this.lblScreenArea = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.Location = new System.Drawing.Point(694, 144);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(75, 23);
            this.btnScreenShot.TabIndex = 0;
            this.btnScreenShot.Text = "button1";
            this.btnScreenShot.UseVisualStyleBackColor = true;
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // picScreen
            // 
            this.picScreen.Location = new System.Drawing.Point(12, 12);
            this.picScreen.Name = "picScreen";
            this.picScreen.Size = new System.Drawing.Size(538, 352);
            this.picScreen.TabIndex = 1;
            this.picScreen.TabStop = false;
            // 
            // lblScreenStartPoint
            // 
            this.lblScreenStartPoint.AutoSize = true;
            this.lblScreenStartPoint.Location = new System.Drawing.Point(584, 37);
            this.lblScreenStartPoint.Name = "lblScreenStartPoint";
            this.lblScreenStartPoint.Size = new System.Drawing.Size(119, 12);
            this.lblScreenStartPoint.TabIndex = 2;
            this.lblScreenStartPoint.Text = "lblScreenStartPoint";
            // 
            // lblScreenArea
            // 
            this.lblScreenArea.AutoSize = true;
            this.lblScreenArea.Location = new System.Drawing.Point(586, 73);
            this.lblScreenArea.Name = "lblScreenArea";
            this.lblScreenArea.Size = new System.Drawing.Size(83, 12);
            this.lblScreenArea.TabIndex = 3;
            this.lblScreenArea.Text = "lblScreenArea";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(694, 236);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "截图保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.lblScreenArea);
            this.Controls.Add(this.lblScreenStartPoint);
            this.Controls.Add(this.picScreen);
            this.Controls.Add(this.btnScreenShot);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.PictureBox picScreen;
        private System.Windows.Forms.Label lblScreenStartPoint;
        private System.Windows.Forms.Label lblScreenArea;
        private System.Windows.Forms.Button buttonSave;
    }
}

