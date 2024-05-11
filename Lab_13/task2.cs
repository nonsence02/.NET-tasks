using System;

class Time
{
    public int Hour { get; }
    public int Minute { get; }

    public Time(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
    }

    public static bool operator >(Time time1, Time time2)
    {
        if (time1.Hour > time2.Hour)
        {
            return true;
        }
        else if (time1.Hour < time2.Hour)
        {
            return false;
        }
        else
        {
            return time1.Minute > time2.Minute;
        }
    }

    public static bool operator <(Time time1, Time time2)
    {
        if (time1.Hour < time2.Hour)
        {
            return true;
        }
        else if (time1.Hour > time2.Hour)
        {
            return false;
        }
        else
        {
            return time1.Minute < time2.Minute;
        }
    }

    public override string ToString()
    {
        return $"{Hour:D2}:{Minute:D2}";
    }
}

class Program
{
    static void Main()
    {
        Time time1 = new Time(10, 30);
        Time time2 = new Time(9, 45);
        Time time3 = new Time(10, 30);

        Console.WriteLine($"Час 1: {time1}");
        Console.WriteLine($"Час 2: {time2}");
        Console.WriteLine($"Час 3: {time3}");

        Console.WriteLine($"Час 1 більший за час 2: {time1 > time2}");
        Console.WriteLine($"Час 1 менший за час 2: {time1 < time2}");

        Console.WriteLine($"Час 1 більший за час 3: {time1 > time3}");
        Console.WriteLine($"Час 1 менший за час 3: {time1 < time3}");
    }
}
