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
            for(int i = 1; i < a+1; i++)
            {
                Console.WriteLine(i +  " ");
            }
            

        }
    }
}

