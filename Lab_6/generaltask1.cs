using System;

public interface IMeasurable
{
    double Perimeter();
    double Area();
}

public interface ICircumcircleIncircle
{
    double R { get; } // радіус описаного кола
    double r { get; } // радіус вписаного кола
}

public class Square : IMeasurable, ICircumcircleIncircle, IComparable<Square>
{
    private double sideLength;

    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    // Реалізація методу для обчислення периметра квадрата
    public double Perimeter()
    {
        return 4 * sideLength;
    }

    // Реалізація методу для обчислення площі квадрата
    public double Area()
    {
        return sideLength * sideLength;
    }

    // Реалізація властивостей для радіусів описаного та вписаного кола квадрата
    public double R
    {
        get { return sideLength * Math.Sqrt(2) / 2; } // Радіус описаного кола (діагональ / 2)
    }

    public double r
    {
        get { return sideLength / 2; } // Радіус вписаного кола (сторона / 2)
    }

    // Реалізація методу CompareTo для порівняння квадратів за вибраним критерієм
    public int CompareTo(Square other)
    {
        if (other == null)
            return 1;

        // Користувач обирає, за яким критерієм порівнювати
        Console.WriteLine("Оберіть критерій порівняння:");
        Console.WriteLine("1 - Периметр");
        Console.WriteLine("2 - Площа");
        Console.WriteLine("3 - Радіус описаного кола");
        Console.WriteLine("4 - Радіус вписаного кола");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                return this.Perimeter().CompareTo(other.Perimeter());
            case 2:
                return this.Area().CompareTo(other.Area());
            case 3:
                return this.R.CompareTo(other.R);
            case 4:
                return this.r.CompareTo(other.r);
            default:
                Console.WriteLine("Неправильний вибір. Порівняння за периметром.");
                return this.Perimeter().CompareTo(other.Perimeter());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть довжину сторони першого квадрата:");
        double sideLength1 = double.Parse(Console.ReadLine());
        Square square1 = new Square(sideLength1);

        Console.WriteLine("Введіть довжину сторони другого квадрата:");
        double sideLength2 = double.Parse(Console.ReadLine());
        Square square2 = new Square(sideLength2);

        int comparisonResult = square1.CompareTo(square2);
        if (comparisonResult < 0)
        {
            Console.WriteLine("Перший квадрат менший за другий");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("Перший квадрат більший за другий");
        }
        else
        {
            Console.WriteLine("Периметри квадратів рівні");
        }
    }
}
