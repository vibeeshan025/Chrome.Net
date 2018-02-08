using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Xilium.CefGlue;

namespace CefGlue.Demo.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var path = new Uri(typeof(App).Assembly.CodeBase).LocalPath;
            var currentFolder = Path.GetDirectoryName(path);

            var subfolder = Environment.Is64BitProcess ? "x64" : "x86";
            var fullPath = Path.Combine(currentFolder, subfolder);
            var tempPath = Path.Combine(currentFolder, "Cache");

            CefBrowserLoader.Initialize(fullPath, tempPath);
        }
    }
}
