using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class FormMediaPlayer : Form
    {
        public FormMediaPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            }
            axWindowsMediaPlayer1.Ctlcontrols.pause();

            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 60;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 60;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);           // 当前时间（double）  
            Console.WriteLine(axWindowsMediaPlayer1.Ctlcontrols.currentPositionString);     // 当前时间（00:00）

            Console.WriteLine(axWindowsMediaPlayer1.currentMedia.duration);                 // 总时间（double）
            Console.WriteLine(axWindowsMediaPlayer1.currentMedia.durationString);           // 总时间（00:00）
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
