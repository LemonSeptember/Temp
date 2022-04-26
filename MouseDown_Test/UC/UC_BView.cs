using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseDown_Test.UC
{
    public partial class UC_BView : UserControl
    {
        public UC_BView()
        {
            InitializeComponent();
        }

        private void pictureBox_BView_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("B Picture");
        }

        private void panel_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("B Panel");
        }

        private void uc_CView_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine(uc_CView.Name);
        }

        private void UC_BView_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("UC_BView");
        }
    }
}
