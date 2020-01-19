using System;
using System.Linq;
namespace Maximal_Sum
{
    class Program
    {
        public static int[,] inputMatrix(int rows, int cows)
        {
            int[,] matrix = new int[rows, cows];
            for (int i = 0; i < rows; i++)
            {
                int[] row = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < cows; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            return matrix;
        }
        public static void printIntMatrix(int rows,int cows, int[,]matrix)
        {
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cows;j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int sum = 0;
            int maximalSum = int.MinValue;
            string input = Console.ReadLine();
            int[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = tokens[0];
            int cows = tokens[1];
            int[,] matrix = inputMatrix(rows, cows);
            int[,] maxElements =new int[3,3];
            for (int i = 0; i < rows - 2; i++)
            {
                 sum = 0;
                for (int j = 0; j < cows - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i + 1, j] + matrix[i + 2, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j + 1] +
                        matrix[i + 1, j + 2] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > maximalSum)
                    {
                        maximalSum = sum;
                        for (int k = 0; k < 3; k++)
                        {
                            for (int p = 0; p < 3; p++)
                            {
                                maxElements[k, p] = matrix[i + k, j + p];
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Sum = { maximalSum}");
            printIntMatrix(3, 3,maxElements);
        }
    }
}
