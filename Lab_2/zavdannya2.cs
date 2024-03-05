using System;


namespace Arrays
{
    class Class
    {
        //Рахує середнє арифметичне ряду, записує у вектор і ретурнить
        static double[] CalculateAvarage(double[,] Matrix, int rows, int columns)
        {
            double[] Vector1 = new double [columns];
            for (int i = 0;i < rows; i++)
            {
                for(int j = 0;j < columns; j++)
                {
                    Vector1[i] += Matrix[i, j];
                }
                Vector1[i] = Vector1[i] / columns;
            }
            return Vector1;
        }
        //віднімає від кожного елементу матриці середнє арифметичне ряду і повертає матрицю
        static double[,] CalculateMatrix(double[,] Matrix, int rows, int columns, double[] Vector)
        {
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Matrix[i, j] = Matrix[i, j] - Vector[i];
                }
            }


            return Matrix;
        }

       
        static double[,] InputMatrix(ref int rows, ref int columns)
        {

            double[,] a = new double[rows, columns];
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

        static void PrintMatrix(ref double[,] a, int rows, int columns)
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
        
        static void Main()
        {
            double[,] Matrix;
            int rows, columns;
            double[] Vector;
            Console.WriteLine("Введіть розмір матриці");
            Console.Write("Enter rows = ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Enter columns = ");
            columns = int.Parse(Console.ReadLine());
            Matrix = InputMatrix(ref rows, ref columns);
            Vector = CalculateAvarage(Matrix, rows, columns);
            Matrix = CalculateMatrix(Matrix, rows, columns, Vector);
            PrintMatrix(ref Matrix, rows, columns);
           
           
        }

    }
}