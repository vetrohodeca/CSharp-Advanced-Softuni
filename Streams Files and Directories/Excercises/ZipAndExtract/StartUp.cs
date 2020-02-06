using System;
using System.IO.Compression;
namespace ZipAndExtract
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\Alex\source\repos\C# Advanced Softuni\Streams Files and Directories\Excercises\ZipAndExtract",
                @"C:\Users\Alex\Desktop\MyArchive.zip");
            ZipFile.ExtractToDirectory(@"C:\Users\Alex\Desktop\MyArchive.zip", @"C:\Users\Alex\Documents");
        }
    }
}
 