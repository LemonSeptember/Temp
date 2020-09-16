using System;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
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

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBeep(beep);     //系统声音发音
            try
            {
                for (int b = 37; b < 32767; b += 10)
                {
                    Console.WriteLine($"{b} Hz");
                    Console.Beep(b, 100);//主板蜂鸣器发音，b是振动的Hz频率；100代表持续时间，单位是“毫秒”
                }
                //int a = Convert.ToInt32(textBox1.Text);
                //int b = 300;

                //for (int i = 1; i < a; i++)
                //{
                //    Console.Beep(b, 1000);//主板蜂鸣器发音，b是振动的Hz频率；100代表持续时间，单位是“毫秒”
                //    b += 100;
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("输入播放循环次数");
            }
        }

        private enum Data
        {
            C = 256, D = 288, E = 320, F = 341, G = 384, A = 426, B = 480, Bm = 453
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (true)
            {
                Console.Beep((int)Data.C, 600);
                Console.Beep((int)Data.D, 180);
                Console.Beep((int)Data.E, 500);
                Console.Beep((int)Data.C, 180);
                Console.Beep((int)Data.E, 400);
                Console.Beep((int)Data.C, 400);
                Console.Beep((int)Data.E, 800);
                Console.Beep((int)Data.D, 600);
                Console.Beep((int)Data.E, 180);
                Console.Beep((int)Data.F, 180);
                Console.Beep((int)Data.F, 180);
                Console.Beep((int)Data.E, 180);
                Console.Beep((int)Data.D, 180);
                Console.Beep((int)Data.F, 1600);
                //P1
                Console.Beep((int)Data.E, 600);
                Console.Beep((int)Data.F, 180);
                Console.Beep((int)Data.G, 580);
                Console.Beep((int)Data.E, 180);
                Console.Beep((int)Data.G, 400);
                Console.Beep((int)Data.E, 400);
                Console.Beep((int)Data.G, 800);
                //P2
                Console.Beep((int)Data.F, 600);
                Console.Beep((int)Data.G, 180);
                Console.Beep((int)Data.A, 180);
                Console.Beep((int)Data.A, 180);
                Console.Beep((int)Data.G, 180);
                Console.Beep((int)Data.F, 180);
                Console.Beep((int)Data.A, 1600);

                //
                Console.Beep((int)Data.G, 600);
                Console.Beep((int)Data.C, 180);
                Console.Beep((int)Data.D, 180);
                Console.Beep((int)Data.E, 180);
                Console.Beep((int)Data.F, 180);
                Console.Beep((int)Data.G, 180);
                Console.Beep((int)Data.A, 1600);
                //
                Console.Beep((int)Data.A, 600);
                Console.Beep((int)Data.D, 180);
                Console.Beep((int)Data.E, 180);
                Console.Beep((int)Data.F, 180);
                Console.Beep((int)Data.G, 180);
                Console.Beep((int)Data.A, 180);
                Console.Beep((int)Data.B, 1600);

                //
                Console.Beep((int)Data.B, 600);
                Console.Beep((int)Data.E, 180);
                Console.Beep((int)Data.F, 180);
                Console.Beep((int)Data.G, 180);
                Console.Beep((int)Data.A, 180);
                Console.Beep((int)Data.B, 180);
                Console.Beep((int)Data.C * 2, 1200);

                Console.Beep((int)Data.B, 180);
                Console.Beep((int)Data.Bm, 180);

                Console.Beep((int)Data.A, 350);
                Console.Beep((int)Data.F, 350);
                Console.Beep((int)Data.B, 350);
                Console.Beep((int)Data.G, 350);
                Console.Beep((int)Data.C * 2, 1000);

                System.Threading.Thread.Sleep(2000);
                //Console.Beep((int)Data.C * (i+1), 100);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var speechSyn = new SpeechSynthesizer();
        }
    }
}
