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
            Console.Write("Введіть кількість співробітників: ");
            int length = int.Parse(Console.ReadLine());

            int heightMinValue = 150; 
            int heightMaxValue = 200;
            int weightMinValue = 50;
            int weightMaxValue = 100;

            Random random = new Random();

            int[] heightArray = GenerateRandomArray(length, heightMinValue, heightMaxValue, random);
            int[] weightArray = GenerateRandomArray(length, weightMinValue, weightMaxValue, random);

            Console.WriteLine("\nПочаткові дані:");
            PrintEmployeeData(heightArray, weightArray);

            Array.Sort(heightArray, weightArray);

            Console.WriteLine("\nВідсортовані дані за зростом:");
            PrintEmployeeData(heightArray, weightArray);
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

        static void PrintEmployeeData(int[] heightArray, int[] weightArray)
        {
            for (int i = 0; i < heightArray.Length; i++)
            {
                Console.WriteLine($"Співробітник {i + 1}: Зріст - {heightArray[i]} см, Вага - {weightArray[i]} кг");
            }
        }


    }
}