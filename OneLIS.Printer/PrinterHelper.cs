﻿using System.Runtime.InteropServices;

namespace OneLIS.Printer
{
    internal static class PrinterHelper
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Printer);
    }
}