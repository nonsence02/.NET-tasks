using System;

class Student : Persona
{
    private string Faculty;
    private int Course;

    public Student(string lastName, DateTime birthDate, string faculty, int course) : base(lastName, birthDate)
    {
        Faculty = faculty;
        Course = course;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Студент: {LastName}");
        Console.WriteLine($"Дата народження: {BirthDate.ToShortDateString()}");
        Console.WriteLine($"Факультет: {Faculty}");
        Console.WriteLine($"Курс: {Course}");
        Console.WriteLine($"Вік: {CalculateAge()}");
    }
}
