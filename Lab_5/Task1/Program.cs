using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "persons.txt";

        try
        {
            List<Persona> personas = ReadPersonsFromFile(filePath);

            foreach (var persona in personas)
            {
                persona.DisplayInfo();
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static List<Persona> ReadPersonsFromFile(string filePath)
    {
        List<Persona> personas = new List<Persona>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                string lastName = parts[0];
                DateTime birthDate = DateTime.Parse(parts[1]);
                string faculty = parts[2];

                if (parts.Length == 3)
                {
                    personas.Add(new Applicant(lastName, birthDate, faculty));
                }
                else if (parts.Length == 4)
                {
                    int course = int.Parse(parts[3]);
                    personas.Add(new Student(lastName, birthDate, faculty, course));
                }
                else if (parts.Length == 5)
                {
                    string position = parts[3];
                    int experience = int.Parse(parts[4]);
                    personas.Add(new Teacher(lastName, birthDate, faculty, position, experience));
                }
                else
                {
                    throw new FormatException("Невірний формат даних у файлі.");
                }
            }
        }

        return personas;
    }
}
