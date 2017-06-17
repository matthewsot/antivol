using System;
using System.Windows.Forms;

namespace AntiVol
{
    static class Program
    {
        public static KeyboardHook hook;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (hook = new KeyboardHook())
            {
                Application.Run(new Form1());
            }
        }
    }
}
