using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VersionTest
{
    public partial class FormVersion : Form
    {
        public FormVersion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("程序集版本：" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            MessageBox.Show("文件版本：" + Application.ProductVersion.ToString());
            //MessageBox.Show("部署版本：" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString());
        }
    }
}
