using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace DirectoryTraversal
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string inputDirectory = Console.ReadLine();
            string[] files = Directory.GetFiles(inputDirectory);
            Dictionary<string, Dictionary<string, double>> info = new Dictionary<string, Dictionary<string, double>>();
            foreach (var pathFile in files)
            {
                string fileName = pathFile.Split('\\').Last();
                string fileExtension = '.' + pathFile.Split('.').Last();
                double length = new System.IO.FileInfo(pathFile).Length;
                double leninKB = length / 1024.0;
                if (!info.ContainsKey(fileExtension))
                {
                    info.Add(fileExtension, new Dictionary<string, double>());
                }
                info[fileExtension].Add(fileName, leninKB);
                info.OrderBy(s => s.Value).ThenByDescending(s => s.Key);
                foreach (var ext in fileExtension) ;
                Console.WriteLine("--" + fileName + " " + fileExtension + " - " + $"{leninKB:F3} kb");
            }
        }
    }
}
