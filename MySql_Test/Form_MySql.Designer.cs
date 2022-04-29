
namespace MySql_Test
{
    partial class Form_MySql
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("项目管理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("人员管理");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("系统设置");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView_Main = new System.Windows.Forms.TreeView();
            this.uc_UserManager = new MySql_Test.UC.UC_UserManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView_Main);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uc_UserManager);
            this.splitContainer1.Size = new System.Drawing.Size(900, 565);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView_Main
            // 
            this.treeView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Main.FullRowSelect = true;
            this.treeView_Main.ItemHeight = 40;
            this.treeView_Main.Location = new System.Drawing.Point(0, 0);
            this.treeView_Main.Margin = new System.Windows.Forms.Padding(4);
            this.treeView_Main.Name = "treeView_Main";
            treeNode1.Name = "tn_ProjectManager";
            treeNode1.Text = "项目管理";
            treeNode2.Name = "tn_UserManager";
            treeNode2.Text = "人员管理";
            treeNode3.Name = "tn_SystemSet";
            treeNode3.Text = "系统设置";
            this.treeView_Main.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView_Main.ShowLines = false;
            this.treeView_Main.Size = new System.Drawing.Size(125, 565);
            this.treeView_Main.TabIndex = 0;
            this.treeView_Main.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Main_AfterSelect);
            // 
            // uc_UserManager
            // 
            this.uc_UserManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_UserManager.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uc_UserManager.Location = new System.Drawing.Point(0, 0);
            this.uc_UserManager.Margin = new System.Windows.Forms.Padding(4);
            this.uc_UserManager.Name = "uc_UserManager";
            this.uc_UserManager.Size = new System.Drawing.Size(770, 565);
            this.uc_UserManager.TabIndex = 0;
            // 
            // Form_MySql
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 565);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_MySql";
            this.Text = "项目管理";
            this.Load += new System.EventHandler(this.Form_MySql_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView_Main;
        private UC.UC_UserManager uc_UserManager;
    }
}

