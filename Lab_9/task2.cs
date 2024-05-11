using System;
using System.IO;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "test.txt";
            ReadFiles(filePath, PrintFileContent, PrintNumbers, ReplaceSymbols);
        }

        static void ReadFiles(string filePath, Action<string> printFileContent, Action<string> printNumbers, Action<string> replaceSymbols)
        {
            try
            {
                // Читання з файлу
                string fileContent = File.ReadAllText(filePath);

                // Вивід вмісту файлу
                printFileContent(fileContent);

                // Вивід чисел
                printNumbers(fileContent);

                // Заміна символів
                replaceSymbols(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }

        static void PrintFileContent(string content)
        {
            Console.WriteLine("Вміст файлу:");
            Console.WriteLine(content);
        }

        static void PrintNumbers(string content)
        {
            Console.WriteLine("Числа в файлі:");
            string[] words = content.Split(' ');
            foreach (var word in words)
            {
                if (int.TryParse(word, out int number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void ReplaceSymbols(string filePath)
        {
            try
            {
                // Заміна символів
                string fileContent = File.ReadAllText(filePath);
                fileContent = fileContent.Replace(',', ' ');
                fileContent = fileContent.Replace('.', ' ');
                fileContent = fileContent.Replace('*', ' ');
                fileContent = fileContent.Replace('(', ' ');
                fileContent = fileContent.Replace(')', ' ');

                // Запис у файл
                File.WriteAllText(filePath, fileContent);

                // Вивід зміненого вмісту файлу
                Console.WriteLine("Змінений вміст файлу:");
                Console.WriteLine(fileContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}
