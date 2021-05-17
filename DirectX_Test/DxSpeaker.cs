using Microsoft.DirectX.DirectSound;
using System;
using System.Windows.Forms;

namespace DirectX_Test
{
    public class DxSpeaker
    {
        private Device dev;
        private SecondaryBuffer snd;

        public void SetMediaPath(string path)
        {
            Form form = Application.OpenForms[0];
            form.Invoke((EventHandler)delegate
            {
                dev = new Device();
                dev.SetCooperativeLevel(Application.OpenForms[0], CooperativeLevel.Normal);
                snd = new SecondaryBuffer(path, dev);
            });
        }

        public void Play()
        {
            snd.Play(0, BufferPlayFlags.Looping);
        }

        public void Stop()
        {
            snd.Stop();
        }
    }
}
