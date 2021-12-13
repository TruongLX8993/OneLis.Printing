using System;
using System.Drawing.Printing;
using System.IO;
using PrintLib;

namespace Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintBarCode();
            PrintSequence();
        }

        private static void PrintBarCode()
        {
            var xml = File.ReadAllText("Sample.xml");
            var barCodePrinter = new BarCodePrinter("TSC TE200", File.ReadAllText("Sample.xslt"), new PageConfig()
            {
                PageSize = new PageSize(283, 70),
                IsLandscape = true
            });
            barCodePrinter.Print(xml);
            // var pdfContent = barCodePrinter.GetPdf(xml);
            // pdfContent.SaveFilePdf($"test-{Guid.NewGuid().ToString()}.pdf");
            // barCodePrinter.Print(File.ReadAllText("Sample.xml"));
        }

        private static void PrintSequence()
        {
            var xml =
                "<Sequence><HoTen>truonglx</HoTen><STT>1234</STT><GioLaySTT>12:00:00</GioLaySTT><HangDoi>123</HangDoi></Sequence>";
            var sequencePrinter = new SequencePrinter("TX 80", new PageConfig(), File.ReadAllText("Sequence.xslt"));
            sequencePrinter.Print(xml);
        }
    }
}