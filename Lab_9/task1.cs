using System;

namespace MatrixOperations
{
    class Program
    {
        delegate double MatrixOperation(int i, int j, double value);

        static void Main(string[] args)
        { 
            double[,] matrix = GenerateRandomMatrix(5, 5);

            Console.WriteLine("Початкова матриця:");
            PrintMatrix(matrix);

            Console.WriteLine("Позитивні елементи головної діагоналі:");
            PrintPositiveElementsOnMainDiagonal(matrix);

            Console.WriteLine("Збільшення втричі позитивних елементів під головною діагоналлю:");
            ChangeMatrix(matrix, (i, j, value) => value > 0 && i > j ? value * 3 : value);

            Console.WriteLine("Змінена матриця:");
            PrintMatrix(matrix);
        }

        static double[,] GenerateRandomMatrix(int rows, int cols)
        {
            Random random = new Random();
            double[,] matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(-10, 10) + random.NextDouble(); //Випадкове дійсне число
                }
            }
            return matrix;
        }

        static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],10:F2} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintPositiveElementsOnMainDiagonal(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < Math.Min(rows, cols); i++)
            {
                if (matrix[i, i] > 0)
                {
                    Console.WriteLine($"[{i}, {i}]: {matrix[i, i]:F2}");
                }
            }
        }

        static void ChangeMatrix(double[,] matrix, MatrixOperation operation)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = operation(i, j, matrix[i, j]);
                }
            }
        }
    }
}
