using System;
using System.Linq;
using System.Collections.Generic;
namespace Space_Station_Establishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            bool hasBlackHoles = hasMatrixBlackHoles(matrix);
            int[] blackHoleIndexes = new int[4];
            if (hasBlackHoles == true)
            {
                blackHoleIndexes = blackHoleIndexesOfBlackHoles(matrix);
            }
            int[] StefanPosition = findIndexOfS(matrix);
            int starsColleceted = 0;
            while (true)
            {
                matrix[StefanPosition[0], StefanPosition[1]] = '-';
                string command = Console.ReadLine();
                if (command == "right")
                {
                    StefanPosition[1]++;
                    if (!(isValidPosition(StefanPosition, matrix)))
                    {
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {starsColleceted}");
                        break;
                    }
                    else
                    {
                        if (matrix[StefanPosition[0],StefanPosition[1]] == 'O')
                        {
                            matrix[StefanPosition[0], StefanPosition[1]] = '-';
                            changeIndexes(blackHoleIndexes, StefanPosition);                      
                        }
                        if (matrix[StefanPosition[0], StefanPosition[1]] >= '0' && matrix[StefanPosition[0], StefanPosition[1]] <= '9')
                        {
                            starsColleceted += (int)matrix[StefanPosition[0], StefanPosition[1]] - '0';
                        }
                        if(starsColleceted>=50)
                        {
                            matrix[StefanPosition[0], StefanPosition[1]] = 'S';
                            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                            Console.WriteLine($"Star power collected: {starsColleceted}");
                            break;
                        }
                    }

                }
                if (command == "left")
                {
                    StefanPosition[1]--;
                    if (!(isValidPosition(StefanPosition, matrix)))
                    {
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {starsColleceted}");
                        break;
                    }
                    else
                    {
                         if (matrix[StefanPosition[0], StefanPosition[1]] == 'O') 
                        {
                            matrix[StefanPosition[0], StefanPosition[1]] = '-';
                            changeIndexes(blackHoleIndexes, StefanPosition);
                        }
                        if (matrix[StefanPosition[0], StefanPosition[1]] >= '0' && matrix[StefanPosition[0], StefanPosition[1]] <= '9')
                        {
                            starsColleceted += (int)matrix[StefanPosition[0], StefanPosition[1]] - '0';
                        }
                        if (starsColleceted >= 50)
                        {
                            matrix[StefanPosition[0], StefanPosition[1]] = 'S';
                            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                            Console.WriteLine($"Star power collected: {starsColleceted}");
                            break;
                        }
                    }
                }
                if (command == "down")
                {
                    StefanPosition[0]++;
                    if (!(isValidPosition(StefanPosition, matrix)))
                    {
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {starsColleceted}");
                        break;
                    }
                    else
                    {
                        if (matrix[StefanPosition[0], StefanPosition[1]] == 'O')
                        {
                            matrix[StefanPosition[0], StefanPosition[1]] = '-';
                            changeIndexes(blackHoleIndexes, StefanPosition);
                        }
                        if (matrix[StefanPosition[0], StefanPosition[1]] >= '0' && matrix[StefanPosition[0], StefanPosition[1]] <= '9')
                        {
                            starsColleceted += (int)matrix[StefanPosition[0], StefanPosition[1]] - '0';
                        }
                        if (starsColleceted >= 50)
                        {
                            matrix[StefanPosition[0], StefanPosition[1]] = 'S';
                            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                            Console.WriteLine($"Star power collected: {starsColleceted}");
                            break;
                        }
                    }
                }
                if (command == "up")
                {
                    StefanPosition[0]--;
                    if (!(isValidPosition(StefanPosition, matrix)))
                    {
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        Console.WriteLine($"Star power collected: {starsColleceted}");
                        break;
                    }
                    else
                    {
                        if (matrix[StefanPosition[0], StefanPosition[1]] == 'O')
                        {
                             matrix[StefanPosition[0], StefanPosition[1]] = '-';
                            changeIndexes(blackHoleIndexes, StefanPosition);
                        }
                        if (matrix[StefanPosition[0], StefanPosition[1]] >= '0' && matrix[StefanPosition[0], StefanPosition[1]] <= '9')
                        {
                            starsColleceted += (int)matrix[StefanPosition[0], StefanPosition[1]] - '0';
                        }
                        if (starsColleceted >= 50)
                        {
                            matrix[StefanPosition[0], StefanPosition[1]] = 'S';
                            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                            Console.WriteLine($"Star power collected: {starsColleceted}");
                            break;
                        }
                    }
                }
            }
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void changeIndexes(int[] blackHoleIndexes, int[] stefanIndexes)
        {
            if(blackHoleIndexes[0]==stefanIndexes[0]&&blackHoleIndexes[1]==stefanIndexes[1])
            {
                stefanIndexes[0] = blackHoleIndexes[2];
                stefanIndexes[1] = blackHoleIndexes[3];
            }
            else
                {
                stefanIndexes[0] = blackHoleIndexes[0];
                stefanIndexes[1] = blackHoleIndexes[1];
            }
        }
        static bool isValidPosition(int[] stefanIndexes, char[,] matrix)
        {
            if (stefanIndexes[0] >= 0 && stefanIndexes[1] >= 0 && stefanIndexes[0] < matrix.GetLength(0) && stefanIndexes[1] < matrix.GetLength(0))
            {
                return true;
            }
            return false;
        }
        static bool hasMatrixBlackHoles(char[,] matrix)
        {
            foreach (var element in matrix)
            {
                if (element == 'O')
                {
                    return true;
                }
            }
            return false;
        }
        static int[] findIndexOfS(char[,] matrix)
        {
            int[] arr = new int[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'S')
                    {
                        arr[0] = i;
                        arr[1] = j;
                    }
                }
            }
            return arr;
        }
        static int[] blackHoleIndexesOfBlackHoles(char[,] matrix)
        {
            int[] arr = new int[4];
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'O')
                    {
                        arr[count] = i;
                        arr[count + 1] = j;
                        count += 2;
                    }
                }
            }
            return arr;
        }
    }
}
