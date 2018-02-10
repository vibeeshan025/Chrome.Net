using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using Xilium.CefGlue;

namespace CefGlue.Demo.WPF
{
    public static class CefBrowserLoader
    {
        private static bool isLoaded = false;

        public static void Initialize(string path, string tempPath)
        {
            if (isLoaded == false)
            {
                try
                {
                    try
                    {
                        CefRuntime.Load(path);
                    }
                    catch (DllNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    catch (CefRuntimeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    string[] args = new string[0];
                    var mainArgs = new CefMainArgs(args);
                    var cefApp = new SampleCefApp();

                    var exitCode = CefRuntime.ExecuteProcess(mainArgs, cefApp);
                    if (exitCode != -1) { return; }

                    var cachePath = Path.Combine(tempPath, "ChacheStore");
                    var logPath = Path.Combine(tempPath, "cef.log");

                    var cefSettings = new CefSettings
                    {
                        BrowserSubprocessPath = @"D:\MubasherTrade-Extra\Chrome.Net\build\Debug\BrowserProcess.exe",
                        CachePath = cachePath,
                        SingleProcess = false,
                        WindowlessRenderingEnabled = true,
                        MultiThreadedMessageLoop = true,

                        LogSeverity = CefLogSeverity.Verbose,
                        LogFile = logPath,
                    };

                    try
                    {
                        CefRuntime.Initialize(mainArgs, cefSettings, cefApp);
                    }
                    catch (CefRuntimeException ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
                }
                finally
                {
                    isLoaded = true;
                }
            }
        }

        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            // shutdown CEF
            CefRuntime.Shutdown();
        }
    }

    internal sealed class SampleCefApp : CefApp
    {
        public SampleCefApp()
        {
        }
    }
}
