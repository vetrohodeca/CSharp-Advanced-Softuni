using System;
using System.Collections.Generic;
using System.Linq;
namespace RecordUniqueSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet <string > hashset = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string input = Console.ReadLine();
                hashset.Add(input);
            }
            foreach(var element in hashset)
            {
                Console.WriteLine(element);
            }
        }
    }
}
