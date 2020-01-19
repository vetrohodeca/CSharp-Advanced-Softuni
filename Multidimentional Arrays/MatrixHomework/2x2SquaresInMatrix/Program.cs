using System;
using System.Linq;
namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void inputMatrix(int rows, int cows, char[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                char[] row = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < cows; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
        }
        static void Main(string[] args)
        {
            int counter = 0;
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(input.Length!=2)
            {
                return;
            }
            int rows = input[0];
            int cows = input[1];
            char[,] matrix = new char[rows, cows];
            inputMatrix(rows, cows, matrix);
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cows - 1; j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i , j+1] && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
