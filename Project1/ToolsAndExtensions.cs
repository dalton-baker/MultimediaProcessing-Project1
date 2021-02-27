using System;

namespace ImageProcess
{
    public static class ToolsAndExtensions
    {
        public static int Normalize(this int value)
        {
            return Math.Max(0, Math.Min(value, 255));
        }

        public static int ToInt(this double value)
        {
            return (int)value;
        }
    }
}
