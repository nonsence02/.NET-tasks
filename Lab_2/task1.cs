using System;
// Масиви (одновимірний масив).
namespace Arrays
{
    class Program
    {
        static int[,] InputArray()
        {
            Console.WriteLine("Введіть кількість рядків: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовбців: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] Array = new int[rows,columns];
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for(int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.WriteLine("Введіть елемент " + i +  " " + j);
                    Array[i,j] = int.Parse(Console.ReadLine());
                }
            }


            return Array;
        }

        static void PrintArray(string a, int[,] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write("{0} ", mas[i, j]);
                Console.WriteLine();
            }
        }
        static void Change(int[,] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    if (mas[i, j] % 2 == 0)
                    {
                        sum += mas[i, j];

                    }
            Console.WriteLine("Сума парних елементів = " + sum);

        }
        static void Main()
        {
            try
            {
                int[,] MyArray = InputArray();
                  
                PrintArray("вихідний масив:", MyArray);
                Change(MyArray);
                PrintArray("підсумковий масив", MyArray);
            }
            catch (FormatException)
            {
                Console.WriteLine("невірний формат вводу даних");
            }
            catch (OverflowException)
            {
                Console.WriteLine("переповнення");
            }
            catch (OutOfMemoryException)

            {
                Console.WriteLine("недостатньо пам'яті для створення об'єкта");
            }
        }
    }
}




    