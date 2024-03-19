using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText("input.txt");

        Console.WriteLine("Вихідний текст:");
        Console.WriteLine(text);

        string lastWord = GetLastWord(text);

        List<string> differentWords = GetDifferentWords(text, lastWord);

        Console.WriteLine("\nСлова, які відмінні від останнього слова:");
        foreach (string word in differentWords)
        {
            Console.WriteLine(word);
        }
    }
    static string GetLastWord(string text)
    {
        text = Regex.Replace(text.Trim(), @"[\p{P}\p{S}]+$", "");

        string[] words = text.Split(' ');

        return words.LastOrDefault();
    }
    static List<string> GetDifferentWords(string text, string lastWord)
    {
        text = Regex.Replace(text, @"[\p{P}\p{S}]", "");

        string[] words = text.Split(' ');

        List<string> differentWords = words.Where(word => word != lastWord).ToList();

        return differentWords;
    }
}
