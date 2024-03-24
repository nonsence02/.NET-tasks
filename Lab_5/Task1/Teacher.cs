using System;

class Teacher : Persona
{
    private string Faculty;
    private string Position;
    private int Experience;

    public Teacher(string lastName, DateTime birthDate, string faculty, string position, int experience) : base(lastName, birthDate)
    {
        Faculty = faculty;
        Position = position;
        Experience = experience;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Викладач: {LastName}");
        Console.WriteLine($"Дата народження: {BirthDate.ToShortDateString()}");
        Console.WriteLine($"Факультет: {Faculty}");
        Console.WriteLine($"Посада: {Position}");
        Console.WriteLine($"Стаж: {Experience} років");
        Console.WriteLine($"Вік: {CalculateAge()}");
    }
}
