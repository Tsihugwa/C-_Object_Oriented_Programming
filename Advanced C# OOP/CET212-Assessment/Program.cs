﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CET212_Assessment
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
            // Create IO Handler (in this case a local file reader)
            var IOhandler = new XMLJourneyFileReader();

            // Pass IOhandler to form via its constructor and run the form
            Application.Run(new Form1(IOhandler));
        }
    }
}
