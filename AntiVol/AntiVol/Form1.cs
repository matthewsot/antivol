using System;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace AntiVol
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Program.hook.KeyIntercepted += Hook_KeyIntercepted;
        }

        private bool Hook_KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            if (!e.KeyName.Contains("Volume")) return true;

            //Thanks! https://stackoverflow.com/questions/2534595/get-master-sound-volume-in-c-sharp
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            switch (e.KeyName)
            {
                case "VolumeUp":
                    defaultDevice.AudioEndpointVolume.VolumeStepUp();
                    break;
                case "VolumeDown":
                    defaultDevice.AudioEndpointVolume.VolumeStepDown();
                    break;
                case "VolumeMute":
                    defaultDevice.AudioEndpointVolume.Mute = !defaultDevice.AudioEndpointVolume.Mute;
                    break;
            }
            return false;
        }

        private KeyboardHook hook;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
