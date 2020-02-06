using System;
using System.Collections.Generic;
using System.Linq;
namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int pushCount = commands[0];
            int popCount = commands[1];
            int numberToFind = commands[2];
            string secondLine = Console.ReadLine();
            int[] nums = secondLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < pushCount; i++)
            {
                stack.Push(nums[i]);
            }
            if(popCount==pushCount)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }
            bool isNumberInStack = false;
            int smallest = int.MaxValue;
            while (stack.Count != 0)
            {
                if (stack.Peek() < smallest)
                {
                    smallest = stack.Peek();
                }
                if (stack.Pop() == numberToFind)
                {
                    isNumberInStack = true;
                }
            }
            if (isNumberInStack)
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
