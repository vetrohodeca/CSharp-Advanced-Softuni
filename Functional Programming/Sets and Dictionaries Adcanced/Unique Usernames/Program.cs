using System;
using System.Collections.Generic;
using System.Linq;
namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for(int i=0;i<n;i++)
            {
                set.Add(Console.ReadLine());
            }
            foreach(var element in set)
            {
                Console.WriteLine(element);
            }
        }
    }
}
