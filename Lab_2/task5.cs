using System;
using System.Data.Common;

namespace Arrays
{
    class Class
    {
        static int[,] Input(out int rows, out int columns)
        {
            Console.WriteLine("введіть розмірність масиву");
            Console.Write("rows = ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("columns = ");
            columns = int.Parse(Console.ReadLine());
            int[,] a = new int[rows, columns];
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < columns; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }
        static void Print(int[,] a, int n, int m)
        {

            for (int i = 0; i < n; ++i, Console.WriteLine())
                for (int j = 0; j < m; ++j)
                    Console.Write("{0,5} ", a[i, j]);

        }
        static void DeleteArray(int[,] a, int rows, ref int columns, int k)
        {
            for (int i = 0; i < rows; ++i)
                for (int j = k; j < columns - 1; ++j)
                    a[i, j] = a[i, j + 1];

            --columns;
        }
        static void Main()
        {
            int rows, columns;
            int[,] myArray = Input(out rows, out columns);
            Console.WriteLine("Вихідний масив:");
            Print(myArray, rows, columns);
            Console.WriteLine("Введіть номер стовбця для видалення:");
            int k = int.Parse(Console.ReadLine());
            DeleteArray(myArray, rows, ref columns, k);
            Console.WriteLine("змінений масив:");
            Print(myArray, rows, columns);
        }
    }
}