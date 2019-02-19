using System;
using System.Windows.Forms;

namespace RenkYakalama
{
    static class Program
    {
        /// <summary>
        /// Main metoda aplikace.
        /// Je zavolána jako první při spuštění programu.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm());
        }
    }
}
