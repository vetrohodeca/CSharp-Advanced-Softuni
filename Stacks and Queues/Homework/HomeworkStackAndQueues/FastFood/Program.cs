using System;
using System.Linq;
using System.Collections.Generic;
namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] nums = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine(max);
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                queue.Enqueue(nums[i]);
            }
            bool isEnough = true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (quantity - queue.Peek() >= 0)
                {
                    quantity -= queue.Dequeue();
                }
            }
            if (queue.Count != 0)
            {
                Console.Write("Orders left: ");
                isEnough = false;
                foreach (var orders in queue)
                {
                    Console.Write($"{orders} ");
                }
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Orders complete");
            }


        }
    }
}
