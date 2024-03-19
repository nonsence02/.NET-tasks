using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть текст:");
        string inputText = Console.ReadLine();

        Console.WriteLine("Введіть рядок, який потрібно замінити:");
        string oldString = Console.ReadLine();

        Console.WriteLine("Введіть рядок, на який потрібно замінити:");
        string newString = Console.ReadLine();

        string resultText = inputText.Replace(oldString, newString);

        Console.WriteLine("\nРезультат заміни:");
        Console.WriteLine(resultText);
    }
}
