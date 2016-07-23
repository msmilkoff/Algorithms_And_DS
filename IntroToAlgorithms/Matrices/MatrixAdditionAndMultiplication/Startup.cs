namespace _01.MatrixAdditionAndMultiplication
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter dimentions: ");
            int n = int.Parse(Console.ReadLine());
            var matrixA = new int[n, n];
            var matrixB = new int[n, n];

            Console.WriteLine("Enter first matrix elements:");
            ReadMatrix(matrixA, n);

            Console.WriteLine("Enter second matrix elements:");
            ReadMatrix(matrixB, n);

            var addedMatrices = SumMatrices(matrixA, matrixB);
            Console.WriteLine("\nAddition Result:");
            PrintMatrix(addedMatrices);

            var multipliedMatrices = MultiplyMatrices(matrixA, matrixB);
            Console.WriteLine("\nMultiplication Result:");
            PrintMatrix(multipliedMatrices);
        }

        private static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            int n = matrixA.GetLength(0);
            int m = matrixA.GetLength(1);
            int[,] result = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return result;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }

                Console.WriteLine();
            }
        }

        public static int[,] SumMatrices(int[,] a, int[,] b)
        {
            // We're working with square matrices.
            int n = a.GetLength(0);
            int[,] result = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }

        public static void ReadMatrix(int[,] matrix, int dimentions)
        {
            // Reading row-by-row
            for (int i = 0; i < dimentions; i++)
            {
                for (int j = 0; j < dimentions; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
