using System;
namespace Arrays
{
    class Program
    {
        static int[][] MakeArray(int[][] Array) 
        {
            for (int i = 0; i < Array.Length; i++)
            {
                int j = (i + 1) * 2;
                Array[i] = new int[j];
                for (j = 0; j < Array[i].Length; j++)
                {
                    Console.Write("a[{0}][{1}]= ", i, j);
                    Array[i][j] = i + j;
                }
            }
            return Array;
        }
        static void Main()
        {
            try
            {
                int[][] MyArray;
                Console.Write("Уведіть кількість рядків: ");
                int n = int.Parse(Console.ReadLine());
                MyArray = new int[n][];
                MyArray = MakeArray(MyArray);
                
                PrintArray("вихідний масив:", MyArray);
                for (int i = 0; i < MyArray.Length; i++)

                    Array.Sort(MyArray[i]);

                PrintArray("змінений масив", MyArray);
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
                Console.WriteLine("недостатньо пам'яті для створення нового об'єкта");
            }
        }
        static void PrintArray(string a, int[][] mas)
        {
            Console.WriteLine(a);

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)

                    Console.Write("{0} ", mas[i][j]);
                Console.WriteLine();
            }
        }
    }
}
         
        
                
                    
    




