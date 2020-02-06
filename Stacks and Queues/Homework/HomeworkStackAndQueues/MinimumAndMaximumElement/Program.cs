using System;
using System.Collections.Generic;
using System.Linq;
namespace MinimumAndMaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int minimumElement = int.MaxValue;
            int maximumElement = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for(int i=0;i<n;i++)
            {
                string input = Console.ReadLine();
                int[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int command;
                int number=0;
                if(tokens.Length==1)
                {
                     command = tokens[0];
                }
                else
                {
                     command = tokens[0];
                     number = tokens[1];
                }

                if(command==1)
                {
                    stack.Push(number);
                }  
                if(command==2)
                {
                    if(stack.Count!=0)
                    stack.Pop();
                }
                if(command==3)
                {
                    list = stack.OrderByDescending(x => x).ToList();
                    if (stack.Count!=0)
                    {
                        Console.WriteLine(list[0]);
                    }
                }
                if(command==4)
                {
                    list = stack.OrderBy(x => x).ToList();
                    if (stack.Count!=0)
                    {                       
                        Console.WriteLine(list[0]);
                    }
                }
            }
            Console.WriteLine(String.Join(", ",stack));
        }
    }
}
