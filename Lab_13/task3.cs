using System;

class Counter
{
    private int count;

    public Counter(int initialValue = 0)
    {
        count = initialValue;
    }

    public static Counter operator ++(Counter c)
    {
        c.count++;
        return c;
    }

    public int GetCount()
    {
        return count;
    }
}

class Program
{
    static void Main()
    {
        Counter counter = new Counter(5);

        Console.WriteLine($"Початкове значення: {counter.GetCount()}");

        counter++;

        Console.WriteLine($"Значення після інкрементування: {counter.GetCount()}");
    }
}
