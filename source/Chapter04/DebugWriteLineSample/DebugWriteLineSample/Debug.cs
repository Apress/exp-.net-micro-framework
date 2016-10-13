using System;
using System.Diagnostics;

namespace System.Diagnostics
{
    public static class Debug
    {
        [Conditional("DEBUG")]
        public static void WriteLine(string message)
        {
            Microsoft.SPOT.Debug.Print(message);
        }
    }
}
