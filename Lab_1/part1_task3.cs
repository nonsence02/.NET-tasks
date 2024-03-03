using System;

namespace wiewie
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, a, xmin,xmax,dx;
            double res;
            Console.WriteLine("Введіть значення числа с: ");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення числа a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення xmin: ");
            xmin = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення xmax: ");
            xmax = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть крок: ");
            dx = int.Parse(Console.ReadLine());

            for (int i = xmin; i < xmax; i += dx)
            {
                res = Math.Pow(Math.Cos(a * i), (1 / 3)) + ((k * Math.Cos(a * i)) / Math.Log(a * i));
                Console.WriteLine("Значення х та у в точці = " + i + ", " + res);
              
            }
            
        }
    }
}
