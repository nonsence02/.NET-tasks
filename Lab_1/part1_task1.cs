using System;

namespace wiewie
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, a, x;
            double res;
            Console.WriteLine("Введіть значення числа с: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення числа a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення числа x: ");
            x = int.Parse(Console.ReadLine());

            res = Math.Pow((c*x-a),(1/3))+((Math.Log(x))/(2*Math.Sin((Math.PI/3)+x)));

            Console.WriteLine("Значення функції = ");
            Console.Write(res);
            
        }
    }
}
