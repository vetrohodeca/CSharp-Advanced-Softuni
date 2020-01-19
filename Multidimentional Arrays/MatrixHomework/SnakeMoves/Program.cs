using System;
using System.Linq;
namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = arg[0];
            int cows = arg[1];
            string word = Console.ReadLine();
            int len = word.Length;
            char[,] matrix = new char[rows, cows];
            int counter = 0;
            for (int i = 0; i < rows; i++)
            {
                if(i%2==0)
                {
                    for (int j = 0; j < cows; j++)
                    {
                        matrix[i,j]=(word[counter % len]);
                        counter++;
                    }
                }
                else
                {
                    for (int j = cows-1; j >=0; j--)
                    {
                        matrix[i,j]=(word[counter % len]);
                        counter++;
                    }
                }
            }
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cows;j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
