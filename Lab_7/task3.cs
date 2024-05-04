using System;
using System.Collections;

class Person : IComparable
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }

    public int CompareTo(object obj)
    {
        Person other = obj as Person;
        if (other == null)
        {
            throw new ArgumentException("Object is not a Person");
        }
        return this.Age.CompareTo(other.Age);
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName} {MiddleName}, {Age} years old, {Weight} kg";
    }
}

class Program
{
    static void Main()
    {
        ArrayList people = new ArrayList();

        // Зчитуємо дані з файлу
        string[] lines = System.IO.File.ReadAllLines("people.txt");

        foreach (string line in lines)
        {
            string[] data = line.Split(' ');
            if (data.Length >= 5)
            {
                Person person = new Person
                {
                    LastName = data[0],
                    FirstName = data[1],
                    MiddleName = data[2],
                    Age = int.Parse(data[3]),
                    Weight = double.Parse(data[4])
                };
                people.Add(person);
            }
            else
            {
                Console.WriteLine($"Недостатньо даних у рядку: {line}");
            }
        }

        // Сортуємо людей за віком
        people.Sort();

        // Виводимо інформацію про людей відсортовану за віком
        Console.WriteLine("Інформація про людей відсортована за віком:");
        foreach (Person person in people)
        {
            Console.WriteLine(person);
        }
    }
}
