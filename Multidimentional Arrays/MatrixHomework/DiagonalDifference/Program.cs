using System;
using System.Linq;
namespace DiagonalDifference
{
    class Program
    {
        static void inputMatrix(int size, int[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {
                var col = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cow = 0; cow < size; cow++)
                {
                    matrix[row, cow] = col[cow];    
                }
            }
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            inputMatrix(size,matrix);
            int secondDiagonalSum = 0;
            int firstDiagonalSum = 0;
            for (int i = 0; i < size; i++)
            {
                    firstDiagonalSum += matrix[i, i];          
            }
            for (int i = 0; i < size; i++)
            {
                secondDiagonalSum += matrix[i, size-i-1];
            }
            int difference = Math.Abs(firstDiagonalSum - secondDiagonalSum);
            Console.WriteLine(difference);
        }
    }
}
