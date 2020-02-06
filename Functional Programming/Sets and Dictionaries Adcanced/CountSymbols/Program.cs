using System;
using System.Linq;
using System.Collections.Generic;
namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> hystogram = new SortedDictionary<char, int>();
            foreach (var ch in input)
            {
                if (!hystogram.ContainsKey(ch))
                {
                    hystogram.Add(ch, 1);
                }
                else hystogram[ch]++;
            }
            foreach(var element in hystogram)
            {
                Console.WriteLine($"{element.Key}: {element.Value} time/s ");
            }
        }
    }
}