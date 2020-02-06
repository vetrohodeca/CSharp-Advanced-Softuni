﻿using System;
using System.IO;
namespace CopyBinaryFile
{
    class StartUp
    {
        static void Main(string[] args)
        {
            const int DEF_SIZE = 4096;
            using FileStream reader = new FileStream("./copyMe.png", FileMode.Open);
            FileStream writer = new FileStream("../../../copied.png", FileMode.Create);
            byte[] buffer = new byte[DEF_SIZE];
            while (reader.CanRead)
            {
                int bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                {
                    break;
                }
                writer.Write(buffer,0,buffer.Length);
            }
        }
    }
}
