using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sound
{
    public partial class FormSound : Form
    {
        public FormSound()
        {
            InitializeComponent();
        }


        private void FormSound_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer2.settings.autoStart = false;
            axWindowsMediaPlayer3.settings.autoStart = false;
            axWindowsMediaPlayer4.settings.autoStart = false;

            axWindowsMediaPlayer1.settings.playCount = 5;
            axWindowsMediaPlayer2.settings.setMode("loop", true);

            axWindowsMediaPlayer1.URL = @"D:\Users\KETIZU2\Desktop\sound\Alarm01.wav";
            axWindowsMediaPlayer2.URL = @"D:\Users\KETIZU2\Desktop\sound\Alarm02.wav";
            axWindowsMediaPlayer3.URL = @"D:\Users\KETIZU2\Desktop\sound\Alarm03.wav";
            axWindowsMediaPlayer4.URL = @"D:\Users\KETIZU2\Desktop\sound\Alarm04.wav";

            //axWindowsMediaPlayer1.settings.setMode()
        }

        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string pszSound, int hmod, int fdwSound);

        public const int SND_FILENAME = 0x00020000;
        public const int SND_ASYNC = 0x0001;

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            //axWindowsMediaPlayer1.URL = @"D:\Users\KETIZU2\Desktop\sound\Alarm01.wav";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();
            //axWindowsMediaPlayer2.URL = @"D:\Users\KETIZU2\Desktop\sound\Alarm02.wav";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.play();
            //axWindowsMediaPlayer3.URL = @"D:\Users\KETIZU2\Desktop\sound\Alarm03.wav";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.Ctlcontrols.play();
            //axWindowsMediaPlayer4.URL = @"D:\Users\KETIZU2\Desktop\sound\Alarm04.wav";
        }
        //发出不同类型的声音的参数如下：  
        //Ok = 0x00000000,  
        //Error = 0x00000010,  
        //Question = 0x00000020,  
        //Warning = 0x00000030,  
        //Information = 0x00000040  

        // 然后在程序中调用  
    }
}
