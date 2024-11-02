using System;

namespace PHFramework
{
    /// <summary>
    /// 框架异常
    /// </summary>
    public class PHFrameworkException : Exception
    {
        public PHFrameworkException() : base($"[PHFramework]") { }

        public PHFrameworkException(string message) : base($"[PHFramework] {message}") { }
    }
}