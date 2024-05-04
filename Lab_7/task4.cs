using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Створюємо стек для зберігання чисел з файлу
        Stack<string> numbersStack = new Stack<string>();

        // Читаємо числа з файлу, розділені пробілами, та додаємо їх до стеку
        string[] numbers = File.ReadAllText("numbers.txt").Split(' ');
        foreach (string number in numbers)
        {
            numbersStack.Push(number);
        }

        // Відкриваємо файл для запису
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            // Записуємо числа зі стеку у файл у зворотньому порядку
            while (numbersStack.Count > 0)
            {
                writer.Write(numbersStack.Pop());
                writer.Write(" ");
            }
        }

        Console.WriteLine("Числа успішно переписано в зворотньому порядку у файл output.txt.");
    }
}
