# Vibeeshan.CefGlue
This is a fork of Xilium.CefGlue (https://bitbucket.org/xilium/xilium.cefglue/overview ) to get more public support, Git based instead of original Hg based. More easy to use approach than original.

## CEF (Chromium Embedded Framework) Glue for .Net
CefGlue is basically .net wrappers aroud CEF (Chromium Embedded Framework).

CEF is a BSD-licensed open source project founded by Marshall Greenblatt in 2008 and based on the Google Chromium project. Unlike the Chromium project itself, which focuses mainly on Google Chrome application development, CEF focuses on facilitating embedded browser use cases in third-party applications. CEF insulates the user from the underlying Chromium and Blink code complexity by offering production-quality stable APIs, release branches tracking specific Chromium releases, and binary distributions. Most features in CEF have default implementations that provide rich functionality while requiring little or no integration work from the user. There are currently over 100 million installed instances of CEF around the world embedded in products from a wide range of companies and industries. A partial list of companies and products using CEF is available on the CEF Wikipedia page. Some use cases for CEF include:

## Why Vibeeshan.CefGlue

| Feature              | CefSharp          | Original CefGlue                       |Vibeeshan.CefGlue                      |
| -------------------- |:------------------| ---------------------------------------|---------------------------------------|
| Framworks            | .Net 4.5.2        | **.Net Standard, .Net Core, .Net 4.0** |**.Net Standard, .Net Core, .Net 4.0** |
| Platforms            | Windows           | **Winows, Linux, macOS**               |**Winows, Linux, macOS**               |
| CPU                  | x86 or x64 at a time          | x86 or x64 at a time       |**Any CPU**                            |
| Other Dependancies   | VC++ 2012/2013 Redistributable    | **No**                 |**No**                                 |
| Binary Distribution  | **Nuget, Binaries**| No (Source Code only)                 | **Nuget, Binaries**                   |
| Documentation        | **High**          | No                                     | **High**                              |

## Build the code from scratch.

1. Run the solution in **VS 2017** or higher (Tested with community edition).
1. Set **CefGlue.Demo.WPF** or any (_CefGlue.Demo.*_) as startup project.
1. Refer the variable called **CEF_VERSION** in **CefGlue\Interop\version.g.cs** 
1. Goto http://opensource.spotify.com/cefbuilds/index.html and search for build used in **CEF_VERSION**
1. Download **Minimal Distribution** or **Sample Application** inside **Windows 32-bit Builds**
1. If you are using **Sample Application** binary copy all the files inside Release folder except cefclient.exe to your debug/release folder. If you are using **Minimal Distribution** then copy files inside Release and Resources to your debug/release folder. 
1. You can remive any *.lib, since they are not required for production.
1. Now you will be able to build and run the solution.
