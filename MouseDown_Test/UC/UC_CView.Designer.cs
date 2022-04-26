
namespace MouseDown_Test.UC
{
    partial class UC_CView
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_PictureBox = new System.Windows.Forms.Panel();
            this.pictureBox_CView = new System.Windows.Forms.PictureBox();
            this.panel_PictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_PictureBox
            // 
            this.panel_PictureBox.Controls.Add(this.pictureBox_CView);
            this.panel_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.panel_PictureBox.Name = "panel_PictureBox";
            this.panel_PictureBox.Size = new System.Drawing.Size(388, 195);
            this.panel_PictureBox.TabIndex = 2;
            this.panel_PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_PictureBox_MouseDown);
            // 
            // pictureBox_CView
            // 
            this.pictureBox_CView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CView.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_CView.Name = "pictureBox_CView";
            this.pictureBox_CView.Size = new System.Drawing.Size(388, 195);
            this.pictureBox_CView.TabIndex = 0;
            this.pictureBox_CView.TabStop = false;
            this.pictureBox_CView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_CView_MouseDown);
            // 
            // UC_CView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_PictureBox);
            this.Name = "UC_CView";
            this.Size = new System.Drawing.Size(388, 195);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UC_CView_MouseDown);
            this.panel_PictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_PictureBox;
        private System.Windows.Forms.PictureBox pictureBox_CView;
    }
}
