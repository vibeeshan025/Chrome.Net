using System;

namespace Xilium.CefGlue.Helpers.Log
{
    public class ILogger
    {
        public void TraceException(string message, Exception exception) { }

        public void Trace(string message, params object[] args) { }

        public void DebugException(string message, Exception exception) { }

        public void Debug(string message, params object[] args) { }

        public void ErrorException(string message, Exception exception) { }

        public void Error(string message, params object[] args) { }

        public void FatalException(string message, Exception exception) { }

        public void Fatal(string message, params object[] args) { }

        public void InfoException(string message, Exception exception) { }

        public void Info(string message, params object[] args) { }

        public void WarnException(string message, Exception exception) { }

        public void Warn(string message, params object[] args) { }

        public bool IsTraceEnabled { get; }

        public bool IsDebugEnabled { get; }

        public bool IsErrorEnabled { get; }

        public bool IsFatalEnabled { get; }

        public bool IsInfoEnabled { get; }

        public bool IsWarnEnabled { get; }
    }
}
