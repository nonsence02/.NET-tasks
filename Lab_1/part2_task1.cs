using System;

namespace wiewie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,res;
            Console.WriteLine("Введіть число а: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число b: ");
            b = int.Parse(Console.ReadLine());
            res = a + b;
            Console.WriteLine("Сума = " + res);

        }
    }
}

