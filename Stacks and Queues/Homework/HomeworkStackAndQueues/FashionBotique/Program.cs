using System;
using System.Collections.Generic;
using System.Linq;
namespace FashionBotique
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> nums = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>();
            foreach (var e in nums)
            {
                clothes.Push(e);
            }
            int count = 1;
            int currentRackFreeSpace = capacity;
            for (int i = 0; i < nums.Count; i++)
            {
                if (currentRackFreeSpace - clothes.Peek() >= 0)
                {
                    currentRackFreeSpace -= clothes.Pop();
                }
                else
                {
                    count++;
                    currentRackFreeSpace = capacity;
                    currentRackFreeSpace -= clothes.Pop();
                }
            }
            Console.WriteLine(count);
        }
    }
}
