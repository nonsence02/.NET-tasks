using System;
using System.Collections.Generic;
using System.IO;

class Person
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> youngerThan40 = new List<Person>();
        List<Person> olderOrEqual40 = new List<Person>();

        // Зчитуємо дані з файлу
        string[] lines = File.ReadAllLines("people.txt");

        foreach (string line in lines)
        {
            string[] data = line.Split(' ');

            if (data.Length >= 5)
            {
                string lastName = data[0];
                string firstName = data[1];
                string middleName = data[2];
                int age;
                double weight;

                if (int.TryParse(data[3], out age) && double.TryParse(data[4], out weight))
                {
                    Person person = new Person
                    {
                        LastName = lastName,
                        FirstName = firstName,
                        MiddleName = middleName,
                        Age = age,
                        Weight = weight
                    };

                    // Розділяємо людей на дві групи в залежності від віку
                    if (person.Age < 40)
                    {
                        youngerThan40.Add(person);
                    }
                    else
                    {
                        olderOrEqual40.Add(person);
                    }
                }
                else
                {
                    Console.WriteLine($"Неправильний формат даних у рядку: {line}");
                }
            }
            else
            {
                Console.WriteLine($"Недостатньо даних у рядку: {line}");
            }
        }

        // Виводимо дані про людей молодших 40 років
        Console.WriteLine("Люди молодші 40 років:");
        foreach (Person person in youngerThan40)
        {
            Console.WriteLine($"{person.LastName} {person.FirstName} {person.MiddleName}, {person.Age} років, {person.Weight} кг");
        }

        // Виводимо дані про всіх інших людей
        Console.WriteLine("\nІнші люди:");
        foreach (Person person in olderOrEqual40)
        {
            Console.WriteLine($"{person.LastName} {person.FirstName} {person.MiddleName}, {person.Age} років, {person.Weight} кг");
        }
    }
}
