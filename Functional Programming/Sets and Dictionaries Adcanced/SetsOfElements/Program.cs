using System;
using System.Collections.Generic;
using System.Linq;
namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = tokens[0];
            int m = tokens[1];
            List<int> set1 = new List<int>();
            List<int> set2 = new List<int>();
            for(int i=0;i<n;i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }
            IEnumerable <int> intersection = set1.Intersect(set2);
            foreach(var element in intersection)
            {
                Console.Write(element+" ");
            }
        }
    }
}
