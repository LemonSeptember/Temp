using MySql_Test.Models;
using MySql_Test.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MySql_Test.UC
{
    public partial class UC_UserManager : UserControl
    {
        public UC_UserManager()
        {
            InitializeComponent();
        }

        private void UC_UserManager_Load(object sender, EventArgs e)
        {

        }

        internal void Init()
        {
            BingCbx();
            BingDgv();
        }

        private void BingCbx()
        {
            List<Status_UserCompany> company_List = Status_UserCompany.ListAll();


            company_List.Insert(0, new Status_UserCompany
            {
                Cmp_Id = 0,
                Cmp_Name = "—查询所有—",
            });
            cbx_Company.DataSource = company_List;
            cbx_Company.DisplayMember = "Cmp_Name";
            cbx_Company.ValueMember = "Cmp_Id";
        }

        private void BingDgv()
        {
            string userName = txt_UserName.Text.Trim();
            int companyId = (int)cbx_Company.SelectedValue;
            List<User_Parameters> user_Parameters = User_Parameters.ListAll();
            if (companyId == 0)
            {
                dgv_UserManager.DataSource = user_Parameters.FindAll(m => StringExtensions.Contains(m.User_Name, userName, StringComparison.OrdinalIgnoreCase) && m.IsDel == false);
            }
            else
            {
                dgv_UserManager.DataSource = user_Parameters.FindAll(m => StringExtensions.Contains(m.User_Name, userName, StringComparison.OrdinalIgnoreCase) && m.Cmp_Id == companyId && m.IsDel == false);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            BingDgv();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            cbx_Company.SelectedIndex = 0;
            txt_UserName.Focus();
            BingDgv();
        }

        private void dgv_UserManager_MouseDown(object sender, MouseEventArgs e)
        {
            dgv_UserManager.ClearSelection();
            if (e.Button == MouseButtons.Right)
            {
                tsm_Edit.Visible = false;
                tsm_Add.Visible = false;
            }
        }

        private void dgv_UserManager_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsm_Edit.Visible = true;
                if (e.RowIndex > -1)
                {
                    dgv_UserManager.Rows[e.RowIndex].Selected = true;
                    tsm_Add.Visible = true;
                }
            }
        }

        private void tsm_Edit_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_UserManager.SelectedRows[0].Cells["UserID"].Value;
            using (Form_SetUser form_SetUser = new Form_SetUser(id))
            {
                form_SetUser.ShowDialog();
            }
        }

        private void tsm_Add_Click(object sender, EventArgs e)
        {
            using (Form_SetUser form_SetUser = new Form_SetUser())
            {
                form_SetUser.ShowDialog();
            }
        }

    }
}
