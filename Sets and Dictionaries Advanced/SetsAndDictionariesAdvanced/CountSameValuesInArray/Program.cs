using System;
using System.Linq;
using System.Collections.Generic;
namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var dictionary = new Dictionary<double, int>();
            foreach(var number in numbers)
            {
                if (dictionary.ContainsKey(number))
                {
                    dictionary[number]++;
                }
                else dictionary[number] = 1;
            }
            foreach (var (key,value)in dictionary)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
