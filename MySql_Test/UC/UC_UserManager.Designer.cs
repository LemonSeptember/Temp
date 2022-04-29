namespace MySql_Test.UC
{
    partial class UC_UserManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_UserManager = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cms_UserManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Select = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbx_Company = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserManager)).BeginInit();
            this.cms_UserManager.SuspendLayout();
            this.groupBox_Select.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_UserManager
            // 
            this.dgv_UserManager.AllowUserToAddRows = false;
            this.dgv_UserManager.AllowUserToDeleteRows = false;
            this.dgv_UserManager.AllowUserToResizeRows = false;
            this.dgv_UserManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UserManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.RealName,
            this.CompanyId,
            this.CompanyName,
            this.UserTypeId,
            this.UserBase,
            this.IsDel});
            this.dgv_UserManager.ContextMenuStrip = this.cms_UserManager;
            this.dgv_UserManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_UserManager.Location = new System.Drawing.Point(0, 0);
            this.dgv_UserManager.MultiSelect = false;
            this.dgv_UserManager.Name = "dgv_UserManager";
            this.dgv_UserManager.ReadOnly = true;
            this.dgv_UserManager.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_UserManager.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_UserManager.RowTemplate.Height = 23;
            this.dgv_UserManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserManager.Size = new System.Drawing.Size(716, 395);
            this.dgv_UserManager.TabIndex = 0;
            this.dgv_UserManager.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_UserManager_CellMouseDown);
            this.dgv_UserManager.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_UserManager_MouseDown);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "User_Id";
            this.UserId.HeaderText = "编号";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "User_Account";
            this.UserName.HeaderText = "账号";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Visible = false;
            // 
            // RealName
            // 
            this.RealName.DataPropertyName = "User_Name";
            this.RealName.HeaderText = "姓名";
            this.RealName.Name = "RealName";
            this.RealName.ReadOnly = true;
            // 
            // CompanyId
            // 
            this.CompanyId.DataPropertyName = "Cmp_Id";
            this.CompanyId.HeaderText = "部门ID";
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.ReadOnly = true;
            this.CompanyId.Visible = false;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "Cmp_Name";
            this.CompanyName.HeaderText = "部门";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // UserTypeId
            // 
            this.UserTypeId.DataPropertyName = "T_Id";
            this.UserTypeId.HeaderText = "用户类型ID";
            this.UserTypeId.Name = "UserTypeId";
            this.UserTypeId.ReadOnly = true;
            this.UserTypeId.Visible = false;
            // 
            // UserBase
            // 
            this.UserBase.DataPropertyName = "T_Name";
            this.UserBase.HeaderText = "用户类型";
            this.UserBase.Name = "UserBase";
            this.UserBase.ReadOnly = true;
            // 
            // IsDel
            // 
            this.IsDel.DataPropertyName = "IsDel";
            this.IsDel.HeaderText = "是否停用";
            this.IsDel.Name = "IsDel";
            this.IsDel.ReadOnly = true;
            this.IsDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsDel.Visible = false;
            // 
            // cms_UserManager
            // 
            this.cms_UserManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Edit,
            this.tsm_Add});
            this.cms_UserManager.Name = "contextMenuStrip1";
            this.cms_UserManager.ShowImageMargin = false;
            this.cms_UserManager.Size = new System.Drawing.Size(76, 48);
            // 
            // tsm_Edit
            // 
            this.tsm_Edit.Name = "tsm_Edit";
            this.tsm_Edit.Size = new System.Drawing.Size(75, 22);
            this.tsm_Edit.Text = "编辑";
            this.tsm_Edit.Click += new System.EventHandler(this.tsm_Edit_Click);
            // 
            // tsm_Add
            // 
            this.tsm_Add.Name = "tsm_Add";
            this.tsm_Add.Size = new System.Drawing.Size(75, 22);
            this.tsm_Add.Text = "添加";
            this.tsm_Add.Click += new System.EventHandler(this.tsm_Add_Click);
            // 
            // groupBox_Select
            // 
            this.groupBox_Select.Controls.Add(this.btn_Reset);
            this.groupBox_Select.Controls.Add(this.btn_Search);
            this.groupBox_Select.Controls.Add(this.cbx_Company);
            this.groupBox_Select.Controls.Add(this.label2);
            this.groupBox_Select.Controls.Add(this.txt_UserName);
            this.groupBox_Select.Controls.Add(this.label1);
            this.groupBox_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Select.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Select.Name = "groupBox_Select";
            this.groupBox_Select.Size = new System.Drawing.Size(710, 94);
            this.groupBox_Select.TabIndex = 1;
            this.groupBox_Select.TabStop = false;
            this.groupBox_Select.Text = "筛选";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.AutoSize = true;
            this.btn_Search.Location = new System.Drawing.Point(528, 57);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(81, 31);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "查找";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbx_Company
            // 
            this.cbx_Company.FormattingEnabled = true;
            this.cbx_Company.Location = new System.Drawing.Point(303, 28);
            this.cbx_Company.Name = "cbx_Company";
            this.cbx_Company.Size = new System.Drawing.Size(150, 29);
            this.cbx_Company.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "部门";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(81, 28);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(120, 29);
            this.txt_UserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_UserManager);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 395);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox_Select);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(716, 100);
            this.panel2.TabIndex = 3;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.AutoSize = true;
            this.btn_Reset.Location = new System.Drawing.Point(623, 57);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(81, 31);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // UC_UserManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_UserManager";
            this.Size = new System.Drawing.Size(716, 495);
            this.Load += new System.EventHandler(this.UC_UserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserManager)).EndInit();
            this.cms_UserManager.ResumeLayout(false);
            this.groupBox_Select.ResumeLayout(false);
            this.groupBox_Select.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_UserManager;
        private System.Windows.Forms.GroupBox groupBox_Select;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Company;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ContextMenuStrip cms_UserManager;
        private System.Windows.Forms.ToolStripMenuItem tsm_Edit;
        private System.Windows.Forms.ToolStripMenuItem tsm_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserBase;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDel;
        private System.Windows.Forms.Button btn_Reset;
    }
}
