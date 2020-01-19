using System;
using System.Linq;
namespace MatrixShuffing
{
    class Program
    {



        public static string[,] inputMatrix(int rows, int cows)
        {
            string[,] matrix = new string[rows, cows];
            for (int i = 0; i < rows; i++)
            {
                var row = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < cows; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            return matrix;
        }
        public static void printIntMatrix(int rows, int cows, int[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void swap(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y = temp;
        }

        public static bool validateIndex(int index, int rows, int cows)
        {
            if (index < 0 || index >= rows || index >= cows)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = tokens[0];
            int cows = tokens[1];
            string[,] matrix = inputMatrix(rows, cows);
            string comands = Console.ReadLine();
            while (comands != "END")
            {
                string[] arg = comands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string operateion = arg[0];

                if (arg.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    comands = Console.ReadLine();
                    continue;
                }

                int index1 = int.Parse(arg[1]);
                int index2 = int.Parse(arg[2]);
                int index3 = int.Parse(arg[3]);
                int index4 = int.Parse(arg[4]);

                if ((index1 >= rows) || (index2 >= cows) || (index3 >= rows) || (index4 >= cows))
                {
                    Console.WriteLine("Invalid input!");
                    comands = Console.ReadLine();
                    continue;
                }
                else
                {
                    swap(ref matrix[index1, index2], ref matrix[index3, index4]);
                    comands = Console.ReadLine();
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cows; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
