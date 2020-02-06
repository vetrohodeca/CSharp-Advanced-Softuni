
using System;
using System.Collections.Generic;
using System.Linq;
namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            int[] comamands = line1.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int add = comamands[0];
            int remove = comamands[1];
            int number = comamands[2];
            Queue<int> queue = new Queue<int>();
            string line2 = Console.ReadLine();
            int[] nums = line2.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if(add==remove)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < add; i++)
            {
                queue.Enqueue(nums[i]);
            }
            for(int i=0;i<remove;i++)
            {
                queue.Dequeue();
            }
            bool isHere=false;
            int smallest = int.MaxValue;
            foreach(var element in queue)
            {
                if(element< smallest)
                {
                    smallest = element;
                }
                if(element==number)
                {
                    isHere = true;
                }
            }
            if(isHere==true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(smallest);
            }
        }
    }
}
