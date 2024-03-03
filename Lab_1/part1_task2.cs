using System;

namespace wiewie
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, a, xmin,xmax,k;
            double res;
            Console.WriteLine("Введіть значення числа с: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення числа a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення xmin: ");
            xmin = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення xmax: ");
            xmax = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть крок: ");
            k = int.Parse(Console.ReadLine());

            for (int i = xmin; i < xmax; i += k)
            {
                res = Math.Pow(((c ^ 2) * (i ^ 2) + 2), (1 / 3)) + ((Math.Log(i ^ 2 + 1)) / (2 * Math.PI));
                Console.WriteLine("Значення х та у в точці = " + i + ", " + res);
              
            }
            
        }
    }
}

