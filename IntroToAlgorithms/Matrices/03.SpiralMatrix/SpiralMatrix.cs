namespace _03.SpiralMatrix
{
    using System;

    public class SpiralMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];

            FillSpiralMatrix(matrix, n);
            PrintMatrix(matrix);

        }

        private static void FillSpiralMatrix(int[,] matrix, int n)
        {
            int maxRotations = n * n;
            int row = 0;
            int col = 0;
            string direction = "right";

            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
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
