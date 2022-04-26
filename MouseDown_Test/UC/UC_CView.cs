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
    public partial class UC_CView : UserControl
    {
        public UC_CView()
        {
            InitializeComponent();
        }

        private void pictureBox_CView_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("UC_CView.Panel.Picture");
            panel_PictureBox_MouseDown((sender as PictureBox).Parent, e);
        }

        private void panel_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("UC_CView.Panel");
            UC_CView_MouseDown((sender as Panel).Parent, e);
        }

        private void UC_CView_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("UC_CView");

        }
    }
}
