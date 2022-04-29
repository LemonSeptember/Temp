using MySql_Test.Models;
using MySql_Test.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MySql_Test
{
    public partial class Form_SetUser : Form
    {
        private User_Bases _user;
        public Form_SetUser()
        {
            InitializeComponent();
        }

        public Form_SetUser(int userId) : this()
        {
            _user = User_Bases.ListAll().Find(m => m.User_Id == userId);
            Text = "编辑用户";
        }

        private void Form_SetUser_Load(object sender, EventArgs e)
        {
            BingCbx();
            if (_user != null)
            {
                txt_UserAccount.Text = _user.User_Account;
                txt_UserName.Text = _user.User_Name;
                cbx_Company.SelectedValue = _user.User_Company;
                cbx_UserType.SelectedValue = _user.User_Type;
            }
        }

        private void BingCbx()
        {
            List<Status_UserCompany> company_List = Status_UserCompany.ListAll();
            cbx_Company.DataSource = company_List;
            cbx_Company.DisplayMember = "Cmp_Name";
            cbx_Company.ValueMember = "Cmp_Id";

            List<Status_UserType> custom_List = Status_UserType.ListAll();
            cbx_UserType.DataSource = custom_List;
            cbx_UserType.DisplayMember = "T_Name";
            cbx_UserType.ValueMember = "T_Id";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string userAccount = txt_UserAccount.Text.Trim();
            string userName = txt_UserName.Text.Trim();
            string password = txt_Password.Text.Trim();
            int user_type = (int)cbx_UserType.SelectedValue;
            int user_company = (int)cbx_Company.SelectedValue;

            if (_user == null)
            {
                List<User_Bases> u1 = User_Bases.ListAll().FindAll(m => m.User_Account == userAccount);
                if (u1.Count > 0)
                {
                    MessageBox.Show("账号已存在");
                    return;
                }
                else
                {
                    User_Bases user = new User_Bases
                    {
                        User_Account = userAccount,
                        User_Sex = "",
                        User_Password = Tools.EncryptToMd5(password),
                        User_Name = userName,
                        User_Type = user_type,
                        User_Company = user_company,
                        IsDel = false,
                    };
                    User_Bases.Insert(user);
                    MessageBox.Show("用户添加成功");
                }
            }
            else
            {
                _user.User_Account = userAccount;
                _user.User_Name = userName;
                _user.User_Type = user_type;
                _user.User_Company = user_company;
                _user.IsDel = false;
                User_Bases.Update(_user);
                MessageBox.Show("用户修改成功");
            }

            this.Close();
        }

    }
}
