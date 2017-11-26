using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Xilium.CefGlue
{
    public static class CefBrowserLoader
    {
        private static bool isLoaded = false;

        static CefBrowserLoader()
        {
            Initialize();
        }

        public static void Initialize()
        {
            if (isLoaded == false)
            {
                try
                {

                    try
                    {
                        CefRuntime.Load();
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

                    var cefSettings = new CefSettings
                    {
                        // BrowserSubprocessPath = browserSubprocessPath,
                        SingleProcess = false,
                        WindowlessRenderingEnabled = true,
                        MultiThreadedMessageLoop = true,
                        LogSeverity = CefLogSeverity.Verbose,
                        LogFile = "cef.log",
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
