using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//http://www.geekpedia.com/tutorial176_Get-and-set-the-wave-sound-volume.html

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

            switch (e.KeyName)
            {
                case "VolumeUp":
                    break;
                case "VolumeDown":
                    break;
                case "VolumeMute":
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
