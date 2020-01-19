using System;
using System.Linq;
namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[][] jagged = new double[N][];
            for (int i = 0; i < N; i++)
            {
                double[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jagged[i] = new double[nums.Length];
                for (int j = 0; j < nums.Length; j++)
                {
                    jagged[i][j] = nums[j];
                }
            }//input

            for (int i = 0; i < N - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                        jagged[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] /= 2;
                    }
                    for (int j = 0; j < jagged[i + 1].Length; j++)
                    {
                        jagged[i + 1][j] /= 2;
                    }

                }//analyze
            }
            string command = Console.ReadLine();
            string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (tokens[0] != "End")
            {
                if (tokens[0] == "Add")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    int value = int.Parse(tokens[3]);
                    if (row < N && row >= 0 && col < jagged[row].Length && col >= 0)
                    {
                        jagged[row][col] += value;
                    }
                }
                if (tokens[0] == "Subtract")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    int value = int.Parse(tokens[3]);
                    if (row < N && row >= 0 && col < jagged[row].Length && col >= 0)
                    {
                        jagged[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
                tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            // end
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        Console.Write(jagged[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            // output
        }
    }
}
