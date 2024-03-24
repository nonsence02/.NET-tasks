using System;

class Applicant : Persona
{
    private string Faculty;

    public Applicant(string lastName, DateTime birthDate, string faculty) : base(lastName, birthDate)
    {
        Faculty = faculty;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Абітурієнт: {LastName}");
        Console.WriteLine($"Дата народження: {BirthDate.ToShortDateString()}");
        Console.WriteLine($"Факультет: {Faculty}");
        Console.WriteLine($"Вік: {CalculateAge()}");
    }
}
