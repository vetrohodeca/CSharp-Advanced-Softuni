using System;

namespace KnightGame
{
    public class KnightGame
    {
        static bool isValidIndex(int index1, int index2, int size)
        {
            return index1 >= 0 && index2 >= 0 && index1 < size && index2 < size;
        }
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            char[,] table = new char[N, N];
            for (int i = 0; i < N; i++)
            {
                var row = Console.ReadLine().ToCharArray();
                for (int j = 0; j < N; j++)
                {
                    table[i, j] = row[j];
                }// input;
            }
            int counter = 0;
            int maxDanagerous = -1;
            int maxDanagerousRow = 0;
            int maxDanagerousCol = 0;
            int cuurentDangareous = 0;
            while (true)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        cuurentDangareous = 0;
                        if (table[i, j] == 'K')
                        {
                            if (isValidIndex(i - 2, j + 1, N))
                            {
                                if (table[i - 2, j + 1] == 'K')
                                {
                                    cuurentDangareous++;
                                }
                            }

                            if (isValidIndex(i - 1, j + 2, N))
                            {
                                if (table[i - 1, j + 2] == 'K')
                                {
                                    cuurentDangareous++;
                                }
                            }

                            if (isValidIndex(i + 1, j + 2, N))
                            {
                                if (table[i + 1, j + 2] == 'K')
                                {
                                    cuurentDangareous++;
                                }
                            }

                            if (isValidIndex(i + 2, j + 1, N))
                            {
                                if (table[i + 2, j + 1] == 'K')
                                {
                                    cuurentDangareous++;
                                }
                            }

                            if (isValidIndex(i + 2, j - 1, N))
                            {
                                if (table[i + 2, j - 1] == 'K')
                                {
                                    cuurentDangareous++;
                                }
                            }

                            if (isValidIndex(i + 1, j - 2, N))
                            {
                                if (table[i + 1, j - 2] == 'K')
                                {
                                    cuurentDangareous++;
                                }
                            }

                            if (isValidIndex(i - 1, j - 2, N))
                            {
                                if (table[i - 1, j - 2] == 'K')
                                {
                                    cuurentDangareous++;
                                }
                            }

                            if (isValidIndex(i - 2, j - 1, N))
                            {
                                if (table[i - 2, j - 1] == 'K')
                                {
                                    cuurentDangareous++;
                                }
                            }
                            if (cuurentDangareous > maxDanagerous)
                            {
                                maxDanagerous = cuurentDangareous;
                                maxDanagerousRow = i;
                                maxDanagerousCol = j;
                            }
                        }
                    }
                }
                if (maxDanagerous == 0)
                {
                    Console.WriteLine(counter);
                    return;
                }
                else
                {
                    table[maxDanagerousRow, maxDanagerousCol] = '0';
                    maxDanagerous = 0;
                    counter++;
                }
            }
        }
    }
}
