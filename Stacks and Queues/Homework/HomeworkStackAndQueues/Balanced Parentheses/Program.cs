using System;
using System.Linq;
using System.Collections.Generic;
namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '[' || input[i] == '{' || input[i] == '(')
                {
                    stack.Push(input[i]);
                }
                    if (input[i] == ']')
                    {
                        if (!stack.Any()|| stack.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
               
                    if (input[i] == ')')
                    {
                            if (!stack.Any()|| stack.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                    }
                
             
                    if (input[i] == '}')
                    {
                        if (!stack.Any()||stack.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                

            }
            Console.WriteLine("YES");
        }
    }
}
