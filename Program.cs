using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //program runs the splash screen first
            Application.Run(new SplashScreen());
            //since the splash screen form has no code to open the next form when the timer elapses, the program automatically runs the login page immediately the timer elapses
            Application.Run(new LoginPage());
        }
    }
}
