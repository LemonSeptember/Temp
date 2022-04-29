using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql_Test
{
    public partial class Form_MySql : Form
    {
        public Form_MySql()
        {
            InitializeComponent();
        }

        private void Form_MySql_Load(object sender, EventArgs e)
        {
            uc_UserManager.Init();
        }
        
        private void treeView_Main_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in treeView_Main.Nodes)
            {
                node.BackColor = Color.White;
                node.ForeColor = Color.Black;
            }
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor = Color.White;


        }

    }
}
