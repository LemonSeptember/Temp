using System;
using System.IO;
using System.Windows.Forms;

namespace DirectX_Test
{
    public partial class Form_DirectX : Form
    {
        DxSpeaker DxSpeaker = new DxSpeaker();

        public Form_DirectX()
        {
            InitializeComponent();
        }

        private void Form_DirectX_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(@"D:\Users\KETIZU2\Desktop\dll\alarm", "S250HZ.wav");
            DxSpeaker.SetMediaPath(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DxSpeaker.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DxSpeaker.Stop();
        }
    }
}
