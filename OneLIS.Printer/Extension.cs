using System.IO;

namespace PrintLib
{
    public static class Extension
    {
        public static void SaveFilePdf(this byte[] data, string filePath)
        {
            File.WriteAllBytes(filePath, data);
        }
    }
}