using System;

namespace Arrays
{
    class Class
    {
        static int[] Input()
        {
            Console.WriteLine("Введіть розмірність масиву");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static void Print(int[] a, int n)
        {
            for (int i = 0; i < n; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        static void DeleteArray(int[] a, ref int n, int m)
        {
            try
            {
                if (m < 0 || m >= n)
                {
                    throw new IndexOutOfRangeException("Ви ввели неправильний номер елемента для видалення.");
                }

                for (int i = m; i < n - 1; ++i)
                    a[i] = a[i + 1];
                --n;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        static void Main()
        {
            int[] myArray = Input();
            int n = myArray.Length;

            Console.WriteLine("Вихідний масив:");
            Print(myArray, n);

            try
            {
                Console.WriteLine("Введіть номер елемента для видалення:");
                int m = int.Parse(Console.ReadLine());
                DeleteArray(myArray, ref n, m);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильний формат введення номеру елемента.");
            }

            Console.WriteLine("Змінений масив:");
            Print(myArray, n);
        }
    }
}
