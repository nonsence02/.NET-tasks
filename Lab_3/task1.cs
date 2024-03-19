using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.ExceptionServices;


namespace Arrays
{
    class Class
    {
        static void Main(string[] args)
        {
            int length = 10;
            int minValue = 1;
            int maxValue = 100;
            Random random = new Random();

            int[] array1 = GenerateRandomArray(length, minValue, maxValue, random);
            int[] array2 = GenerateRandomArray(length, minValue, maxValue, random);

            Console.WriteLine("Початкові масиви:");
            PrintArray(array1);
            PrintArray(array2);

            Array.Sort(array1);

            Console.WriteLine("\nПерший масив після сортування:");
            PrintArray(array1);
        }

        static int[] GenerateRandomArray(int length, int minValue, int maxValue, Random random)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }


    }
}