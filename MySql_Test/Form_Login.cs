using MySql_Test.Models;
using System;
using System.Windows.Forms;

namespace MySql_Test
{
    public partial class Form_Login : Form
    {
        private int _number = 0;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userAccount = txt_UserName.Text.Trim();
            string password = txt_Password.Text.Trim();

            if (userAccount == "")
            {
                MessageBox.Show("请输入用户名！");
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }

            User_Bases user = User_Bases.ListAll().Find(m => m.User_Account == userAccount && m.User_Password == password);
            if (user == null)
            {
                user = User_Bases.ListAll().Find(m => m.User_Account == userAccount);
                if (user == null)
                {
                    MessageBox.Show("用户不存在！");
                    txt_UserName.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("密码错误！");
                    txt_Password.Focus();
                    return;
                }
            }
            else
            {
                MainBase.Instance.UserType = user.User_Type;

                LoginSuccessful();

            }
        }

        private void LoginSuccessful()
        {
            label1.Visible = false;
            label2.Visible = false;
            txt_UserName.Visible = false;
            txt_Password.Visible = false;
            btn_Login.Visible = false;
            btn_Reset.Visible = false;
            lbl_LoginSuccessful.Visible = true;
            mTimer.Start();
            //this.Close();
        }

        private void mTimer_Tick(object sender, EventArgs e)
        {
            lbl_LoginSuccessful.Text += ".";
            _number++;
            if (_number > 3)
            {
                this.Close();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //清空文本框内容
            this.txt_UserName.Text = "";
            this.txt_Password.Text = "";
            this.txt_UserName.Focus();
        }
    }
}
