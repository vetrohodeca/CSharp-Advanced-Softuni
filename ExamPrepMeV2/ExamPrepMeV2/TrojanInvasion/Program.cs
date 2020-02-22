using System;
using System.Collections.Generic;
using System.Linq;
namespace TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());
            int[] secondLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> plates = new Queue<int>(secondLine);
            Stack<int> warriors = new Stack<int>();
            for (int i = 0; i < numberOfWaves; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if ((i + 1) % 3 != 0)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        warriors.Push(input[j]);
                    }
                }
                else
                {
                    int extraPlate = int.Parse(Console.ReadLine());
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (j == 0)
                        {
                            warriors.Push(input[j] + extraPlate);
                        }
                        else warriors.Push(input[j]);
                    }
                }
            }
        }
    }
}
