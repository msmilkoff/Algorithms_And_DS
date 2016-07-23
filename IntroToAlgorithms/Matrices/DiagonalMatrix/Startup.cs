namespace _02.DiagonalMatrix
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             Problem description:
             Fill the following matrix:
             0  20  19  17  14
             1   0  18  16  13 
             2   5  0   15  12
             3   6  8   0   11
             4   7  9   10   0
             */

            int n = 5;
            var matrix = new int[n, n];

            FillMatrix(matrix, n);

            PrintMatrix(matrix);
        }

        private static void FillMatrix(int[,] matrix, int n)
        {
            // Filling the matrix above the main diagonal
            int cellValue1 = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    matrix[j, i] = cellValue1;
                    cellValue1++;
                }
            }

            // Filling the matrix below the main diagonal
            int cellValue2 = 20;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    matrix[j, i] = cellValue2;
                    cellValue2--;
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
