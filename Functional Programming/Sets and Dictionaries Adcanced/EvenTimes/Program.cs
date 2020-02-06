using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> nums = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!nums.ContainsKey(number))
                {
                    nums.Add(number, 1);
                }
                else nums[number]++;
            }
            foreach (var key in nums.Keys)
            {
                if (nums[key] % 2 == 0 && nums[key] != 0)
                {
                    Console.WriteLine(key);
                }
            }
        }
    }
}