using System;

namespace wiewie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введіть число а: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число b: ");
            b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("Число b більше = " + b);
            }
            else
            {
                Console.WriteLine("Число a більше = " + a);
            }
           

        }
    }
}

