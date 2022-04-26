
namespace MouseDown_Test.UC
{
    partial class UC_BView
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
            this.uc_CView = new MouseDown_Test.UC.UC_CView();
            this.SuspendLayout();
            // 
            // uc_CView
            // 
            this.uc_CView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_CView.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_CView.Location = new System.Drawing.Point(0, 0);
            this.uc_CView.Name = "uc_CView";
            this.uc_CView.Size = new System.Drawing.Size(674, 92);
            this.uc_CView.TabIndex = 2;
            this.uc_CView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uc_CView_MouseDown);
            // 
            // UC_BView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc_CView);
            this.Name = "UC_BView";
            this.Size = new System.Drawing.Size(674, 369);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UC_BView_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private UC_CView uc_CView;
    }
}
