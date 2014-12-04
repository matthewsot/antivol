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

        private bool enabled = true;

        private bool Hook_KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            if (!enabled) return true;
            if (!e.KeyName.Contains("Volume") && e.KeyName != "Scroll") return true;

            if (e.KeyName == "Scroll")
            {
                //TODO: make it a taskbar thing
                WindowState = FormWindowState.Normal; //using scroll lock as the hotkey for this, as I never have any other use for it
                return false;
            }

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
                case "MediaNextTrack":
                    break;
            }
            return false;
        }

        private KeyboardHook hook;

        private void button1_Click(object sender, EventArgs e)
        {
            enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enabled = false;
        }
    }
}
