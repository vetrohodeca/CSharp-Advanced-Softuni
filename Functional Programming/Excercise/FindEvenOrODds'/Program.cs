using System;
using System.Collections.Generic;
using System.Linq;
namespace FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string query = Console.ReadLine();
            Predicate<int> predicate = query == "odd" ?
                new Predicate<int>((n) => n % 2 != 0) : new
                Predicate<int>((n) => n % 2 == 0);
            List<int> Res = new List<int>();
            for(int i=input[0];i<=input[1];i++)
            {
                if(predicate(i))
                {
                    Res.Add(i); 
                }
            }
            Console.WriteLine(string.Join(" ",Res));
        }
    }
}
