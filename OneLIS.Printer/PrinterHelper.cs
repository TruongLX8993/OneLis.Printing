using System.Runtime.InteropServices;

namespace PrintLib
{
    public static class PrinterHelper
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Printer);
    }
}