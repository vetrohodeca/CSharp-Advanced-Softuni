using System;
using System.Collections.Generic;
using System.Linq;
namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOfCommands = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int[] currentIndex = new int[2];
            currentIndex = findIndexesOfF(matrix);
            int x = currentIndex[0];
            int y = currentIndex[1];
            for (int i = 0; i < countOfCommands; i++)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    move(matrix, currentIndex, "up");
                   
                    if (matrix[currentIndex[0], currentIndex[1]] == 'T')
                    {
                        move(matrix, currentIndex, "down");
                    }
                    if (matrix[currentIndex[0], currentIndex[1]] == 'B')
                    {
                        move(matrix, currentIndex, "up");
                    }
                    if (matrix[currentIndex[0], currentIndex[1]] == 'F')
                    {
                        playerWon(matrix, x, y, n, currentIndex);
                        return;
                    }
                }
                if (command == "down")
                {
                    move(matrix, currentIndex, "down");
                   
                    if (matrix[currentIndex[0], currentIndex[1]] == 'T')
                    {
                        move(matrix, currentIndex, "up");
                    }
                    if (matrix[currentIndex[0], currentIndex[1]] == 'B')
                    {
                        move(matrix, currentIndex, "down");
                    }
                    if (matrix[currentIndex[0], currentIndex[1]] == 'F')
                    {
                        playerWon(matrix, x, y, n, currentIndex);
                        return;
                    }
                }
                if (command == "left")
                {
                    move(matrix, currentIndex, "left");
                   
                    if (matrix[currentIndex[0], currentIndex[1]] == 'T')
                    {
                        move(matrix, currentIndex, "right");
                        continue;
                    }
                    if (matrix[currentIndex[0], currentIndex[1]] == 'B')
                    {
                        move(matrix, currentIndex, "left");
                    }
                    if (matrix[currentIndex[0], currentIndex[1]] == 'F')
                    {
                        playerWon(matrix, x, y, n, currentIndex);
                        return;
                    }
                }
                if (command == "right")
                {
                    move(matrix, currentIndex, "right");
                   
                    if (matrix[currentIndex[0], currentIndex[1]] == 'T')
                    {
                        move(matrix, currentIndex, "left");
                        continue;
                    }
                        if (matrix[currentIndex[0], currentIndex[1]] == 'B')
                    {
                        move(matrix, currentIndex, "right");
                    }
                    if (matrix[currentIndex[0], currentIndex[1]] == 'F')
                    {
                        playerWon(matrix, x, y, n, currentIndex);
                        return;
                    }
                }
            }

            Console.WriteLine("Player lost!");
            matrix[currentIndex[0], currentIndex[1]] = 'f';
            matrix[x, y] = '-';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void move(char[,] matrix, int[] currentIndexes,string command)
        {
            int size = matrix.GetLength(0);
            if(command=="up")
            {
                if (currentIndexes[0] == 0)
                {
                    currentIndexes[0] = size - 1;
                }
                else currentIndexes[0] -= 1;
            }
            if(command=="down")
            {
                if (currentIndexes[0] == size-1)
                {
                    currentIndexes[0] = 0;
                }
                else currentIndexes[0] += 1;
            }
            if(command=="left")
            {
                if (currentIndexes[1] == 0)
                {
                    currentIndexes[1] = size-1;
                }
                else currentIndexes[1] -= 1;
            }
            if(command=="right")
            {
                if (currentIndexes[1] == size - 1)
                {
                    currentIndexes[1] = 0;
                }
                else currentIndexes[1] += 1;
            }
        }
        static int[] findIndexesOfF(char[,] matrix)
        {
            int[] indexes = new int[2];
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j]=='f')
                    {
                        indexes[0] = i;
                        indexes[1] = j;
                    }
                }
            }
            return indexes;
        }
        static void playerWon(char[,]matrix, int firstIndexRow, int firstIndexCol,int n, int[] currentIndex)
        {
            matrix[currentIndex[0], currentIndex[1]] = 'f';
            Console.WriteLine("Player won!");
            matrix[firstIndexRow, firstIndexCol] = '-';
            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[k, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
