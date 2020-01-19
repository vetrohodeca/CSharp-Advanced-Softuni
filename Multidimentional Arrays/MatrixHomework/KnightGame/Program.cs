//using System;
//using System.Linq;
//namespace KnightGame
//{
//    class Program
//    {
//        static void updateClosestKnights(char [,] table, int N, int[,] numberOfClosesKnights)
//        {
//            for (int i = 1; i < N - 1; i++)
//            {
//                for (int j = 1; j < N - 1; j++)
//                {
//                    if (table[i, j] == 'K')
//                       {
//                        if (table[i + 1, j] == 'K') numberOfClosesKnights[i, j]++;
//                        if (table[i + 1, j + 1] == 'K') numberOfClosesKnights[i, j]++;
//                        if (table[i - 1, j] == 'K') numberOfClosesKnights[i, j]++;
//                        if (table[i - 1, j + 1] == 'K') numberOfClosesKnights[i, j]++;
//                        if (table[i - 1, j - 1] == 'K') numberOfClosesKnights[i, j]++;
//                        if (table[i + 1, j - 1] == 'K') numberOfClosesKnights[i, j]++;
//                        if (table[i, j + 1] == 'K') numberOfClosesKnights[i, j]++;
//                        if (table[i, j - 1] == 'K') numberOfClosesKnights[i, j]++;
//                    }

//                }//bez rankata
//            }

//            for (int j=1;j<N-1;j++)
//            {
//                if(table[0,j]=='K')
//                {
//                    if (table[0, j - 1] == 'K') numberOfClosesKnights[0, j]++;
//                    if (table[0, j + 1] == 'K') numberOfClosesKnights[0, j]++;
//                    if (table[1, j - 1] == 'K') numberOfClosesKnights[0, j]++;
//                    if (table[1, j + 1] == 'K') numberOfClosesKnights[0, j]++;
//                    if (table[1, j] == 'K') numberOfClosesKnights[0, j]++;
//                }

//            }

//            for (int j = 1; j < N - 1; j++)
//            {
//                if (table[N - 1, j] == 'K')
//                {
//                    if (table[N - 1, j - 1] == 'K') numberOfClosesKnights[N - 1, j]++;
//                    if (table[N - 1, j + 1] == 'K') numberOfClosesKnights[N - 1, j]++;
//                    if (table[N - 2, j - 1] == 'K') numberOfClosesKnights[N - 1, j]++;
//                    if (table[N - 2, j + 1] == 'K') numberOfClosesKnights[N - 1, j]++;
//                    if (table[N - 2, j] == 'K') numberOfClosesKnights[N - 1, j]++;
//                }
//            }
//            for (int i = 1; i < N - 1; i++)
//            {
//                if (table[i,0]=='K')
//                {
//                    if (table[i - 1, 0] == 'K') numberOfClosesKnights[i, 0]++;
//                    if (table[i + 1, 0] == 'K') numberOfClosesKnights[i, 0]++;
//                    if (table[i, 1] == 'K') numberOfClosesKnights[i, 0]++;
//                    if (table[i - 1, 1] == 'K') numberOfClosesKnights[i, 0]++;
//                    if (table[i + 1, 1] == 'K') numberOfClosesKnights[i, 0]++;
//                }
//            }
//            for (int i = 1; i < N - 1; i++)
//            {
//                if (table[i,N-1]=='K')
//                {
//                    if (table[i - 1, N - 1] == 'K') numberOfClosesKnights[i,N - 1]++;
//                    if (table[i + 1, N - 1] == 'K') numberOfClosesKnights[i,N - 1]++;
//                    if (table[i, N - 2] == 'K') numberOfClosesKnights[i,N - 1]++;
//                    if (table[i - 1, N - 2] == 'K') numberOfClosesKnights[i,N - 1]++;
//                    if (table[i + 1, N - 2] == 'K') numberOfClosesKnights[i,N - 1]++;
//                }
//            }

//            if (table[0, 0] == 'K')
//            {
//                if (table[0, 1] == 'K') numberOfClosesKnights[0, 0]++;
//                if (table[1, 1] == 'K') numberOfClosesKnights[0, 0]++;
//                if (table[1, 0] == 'K') numberOfClosesKnights[0, 0]++;
//            }

//            if (table[0, N - 1] == 'K')
//            {
//                if (table[1, N - 1] == 'K') numberOfClosesKnights[0, N - 1]++;
//                if (table[0, N - 2] == 'K') numberOfClosesKnights[0, N - 1]++;
//                if (table[1, N - 2] == 'K') numberOfClosesKnights[0, N - 1]++;
//            }

//            if (table[N - 1, 0] == 'K')
//            {
//                if (table[N - 1, 1] == 'K') numberOfClosesKnights[N - 1, 0]++;
//                if (table[N - 2, 0] == 'K') numberOfClosesKnights[N - 1, 0]++;
//                if (table[N - 2, 1] == 'K') numberOfClosesKnights[N - 1, 0]++;
//            }
//            if (table[N - 1, N - 1] == 'K')
//            {
//                if (table[N - 1, N - 2] == 'K') numberOfClosesKnights[N - 1, N - 1]++;
//                if (table[N - 2, N - 1] == 'K') numberOfClosesKnights[N - 1, N - 1]++;
//                if (table[N - 2, N - 2] == 'K') numberOfClosesKnights[N - 1, N - 1]++;
//            }

//        }
//        static void Main(string[] args)
//        {
//            int N = int.Parse(Console.ReadLine());
//            char[,] table = new char[N, N];
//            for(int i=0;i<N;i++)
//            {
//                var row = Console.ReadLine().ToCharArray();
//                for(int j=0;j<N;j++)
//                {
//                    table[i,j] = row[j];
//                }// input;
//            }
//            int counter = 0;
//            int[,] numberOfClosesKnights=new int [N,N];
//            for (int i = 1; i < N - 1; i++)
//            {
//                for (int j = 1; j < N - 1; j++)
//                {
//                    numberOfClosesKnights[i, j] = 0;
//                }
//            }

//            updateClosestKnights(table, N, numberOfClosesKnights);



//            for (int i=0;i<N;i++)
//            {
//                for(int j=0;j<N;j++)
//                {
//                    Console.Write(numberOfClosesKnights[i,j]);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

using System;

namespace KnightGame
{
    public class KnightGame
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];
            for (int i = 0; i < matrix.Length; i++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();
                matrix[i] = new char[n];
                matrix[i] = inputRow;
            }

            int currentKnightsInDanger = 0;
            int maxKnightsInDanger = -1;
            int mostDangerousKnightRow = 0;
            int mostDangerousKnightCol = 0;
            int count = 0;

            while (true)
            {
                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                    {
                        if (matrix[rowIndex][colIndex].Equals('K'))
                        {
                            // vertical and left
                            if (IsCellInMatrix(rowIndex - 2, colIndex - 1, matrix))
                            {
                                if (matrix[rowIndex - 2][colIndex - 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // vertical and right
                            if (IsCellInMatrix(rowIndex - 2, colIndex + 1, matrix))
                            {
                                if (matrix[rowIndex - 2][colIndex + 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // vertical and left
                            if (IsCellInMatrix(rowIndex + 2, colIndex - 1, matrix))
                            {
                                if (matrix[rowIndex + 2][colIndex - 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // vertical and right
                            if (IsCellInMatrix(rowIndex + 2, colIndex + 1, matrix))
                            {
                                if (matrix[rowIndex + 2][colIndex + 1].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal up and left
                            if (IsCellInMatrix(rowIndex - 1, colIndex - 2, matrix))
                            {
                                if (matrix[rowIndex - 1][colIndex - 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal up and right
                            if (IsCellInMatrix(rowIndex - 1, colIndex + 2, matrix))
                            {
                                if (matrix[rowIndex - 1][colIndex + 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal down and left
                            if (IsCellInMatrix(rowIndex + 1, colIndex - 2, matrix))
                            {
                                if (matrix[rowIndex + 1][colIndex - 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }

                            // horizontal down and right
                            if (IsCellInMatrix(rowIndex + 1, colIndex + 2, matrix))
                            {
                                if (matrix[rowIndex + 1][colIndex + 2].Equals('K'))
                                {
                                    currentKnightsInDanger++;
                                }
                            }
                        }

                        if (currentKnightsInDanger > maxKnightsInDanger)
                        {
                            maxKnightsInDanger = currentKnightsInDanger;
                            mostDangerousKnightRow = rowIndex;
                            mostDangerousKnightCol = colIndex;
                        }
                        currentKnightsInDanger = 0;
                    }
                }
                if (maxKnightsInDanger != 0)
                {
                    matrix[mostDangerousKnightRow][mostDangerousKnightCol] = 'O';
                    count++;
                    maxKnightsInDanger = 0;
                }
                else
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }

        public static bool IsCellInMatrix(int row, int col, char[][] matrix)
        {
            if (0 <= row && row < matrix.Length && 0 <= col && col < matrix[row].Length)
            {
                return true;
            }

            return false;
        }
    }
}
