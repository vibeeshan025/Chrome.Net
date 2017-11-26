using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Xilium.CefGlue;

namespace CefGlue.Demo.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CefBrowserLoader.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
