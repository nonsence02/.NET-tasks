using System;
using System.Collections.Generic;

public interface IRoom : IComparable<IRoom>
{
    double Area { get; } // Площа кімнати
    int Windows { get; } // Кількість вікон
}

public class ClassRoom : IRoom
{
    public double Area { get; private set; } // Площа класної кімнати
    public int Windows { get; private set; } // Кількість вікон в класній кімнаті

    public ClassRoom(double area, int windows)
    {
        Area = area;
        Windows = windows;
    }

    public int CompareTo(IRoom other)
    {
        if (other == null)
            throw new ArgumentException("Об'єкт для порівняння не може бути нульовим.");

        return Windows.CompareTo(other.Windows); // Порівнюємо за кількістю вікон
    }
}

public class MyRoom : IRoom
{
    public double Area { get; private set; } // Площа моєї кімнати
    public int Windows { get; private set; } // Кількість вікон у моїй кімнаті

    public MyRoom(double area, int windows)
    {
        Area = area;
        Windows = windows;
    }

    public int CompareTo(IRoom other)
    {
        if (other == null)
            throw new ArgumentException("Об'єкт для порівняння не може бути нульовим.");

        return Windows.CompareTo(other.Windows); // Порівнюємо за кількістю вікон
    }
}

public class RoomWindowsComparer : IComparer<IRoom>
{
    public int Compare(IRoom x, IRoom y)
    {
        if (x == null || y == null)
            throw new ArgumentException("Об'єкти для порівняння не можуть бути нульовими.");

        return x.Windows.CompareTo(y.Windows); // Порівнюємо за кількістю вікон
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть площу класної кімнати:");
        double classRoomArea = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть кількість вікон у класній кімнаті:");
        int classRoomWindows = int.Parse(Console.ReadLine());
        IRoom classRoom = new ClassRoom(classRoomArea, classRoomWindows);

        Console.WriteLine("Введіть площу вашої кімнати:");
        double myRoomArea = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть кількість вікон у вашій кімнаті:");
        int myRoomWindows = int.Parse(Console.ReadLine());
        IRoom myRoom = new MyRoom(myRoomArea, myRoomWindows);

        RoomWindowsComparer windowsComparer = new RoomWindowsComparer();
        int windowsComparisonResult = windowsComparer.Compare(classRoom, myRoom);

        if (windowsComparisonResult < 0)
        {
            Console.WriteLine("Моя кімната має більше вікон, ніж класна кімната.");
        }
        else if (windowsComparisonResult > 0)
        {
            Console.WriteLine("Моя кімната має менше вікон, ніж класна кімната.");
        }
        else
        {
            Console.WriteLine("Кількість вікон у кімнатах рівна.");
        }
    }
}
