using System;

abstract class Persona
{
    protected string LastName;
    protected DateTime BirthDate;

    public Persona(string lastName, DateTime birthDate)
    {
        LastName = lastName;
        BirthDate = birthDate;
    }

    public abstract void DisplayInfo();

    public int CalculateAge()
    {
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - BirthDate.Year;
        if (currentDate < BirthDate.AddYears(age))
        {
            age--;
        }
        return age;
    }
}
