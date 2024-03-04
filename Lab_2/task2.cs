using System;

namespace Arrays
{ 
    class Program
    {
        static void Main()
        {
            int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i;
            try
            {
               for (i = 0; i <= 10; i++) Console.WriteLine(myArray[i]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Exception: Вихід за межі діапазону");
            }
            catch (FormatException)
            {
                Console.WriteLine("Формат введення не правильний");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Недостатньо пам'яті");
            }
        }
    }
}
