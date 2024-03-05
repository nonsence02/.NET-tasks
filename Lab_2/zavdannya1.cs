using System;


namespace Arrays
{
    class Class
    {

        static int[] CalculateVector(int[] Vector, int[,] Matrix, int rows, int columns)
        {
            int[] Vector1 = new int [columns];
            for (int i = 0;i < rows; i++)
            {
                for(int j = 0;j < columns; j++)
                {
                    Vector1[i] += Matrix[i, j] * Vector[j];
                }
            }
            return Vector1;
        }

        static int[] InputVector(int columns)
        {
            int[] Vector = new int[columns];
            Console.WriteLine("Введіть значення вектору: ");
            for (int i = 0;i < columns; i++)
            {
                Console.WriteLine("Vector{0}= ");
                Vector[i] = int.Parse(Console.ReadLine());  
            }
            return Vector;
        }

        static int[,] InputMatrix(ref int rows, ref int columns)
        {

            int[,] a = new int[rows, columns];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0;j < columns; j++)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i,j] = int.Parse(Console.ReadLine()) ;    
                }
            }

            return a;
        }

        static void PrintMatrix(ref int[,] a, int rows, int columns)
        { 
            for (int i = 0; i < columns; i++)
            { 
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintVector(ref int[] vec)
        {
            for(int i = 0; i <vec.Length; i++)
            {
                Console.Write(vec[i] + " ");
            }
        }

        static void Main()
        {
            int[,] Matrix;
            int rows, columns;
            int[] Vector;
            Console.WriteLine("Введіть розмір матриці");
            Console.Write("Enter rows = ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Enter columns = ");
            columns = int.Parse(Console.ReadLine());
            Vector = InputVector(columns);
            Matrix = InputMatrix(ref rows, ref columns);
            PrintMatrix(ref Matrix, rows, columns);
            Vector = CalculateVector(Vector,Matrix,rows, columns);
            PrintVector(ref Vector);
        }

    }
}