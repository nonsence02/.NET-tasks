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

public class Square : IMeasurable, ICircumcircleIncircle
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
}

class Program
{
    static void Main(string[] args)
    {
        double sideLength = 5;
        Square square = new Square(sideLength);

        Console.WriteLine("Периметр квадрата: " + square.Perimeter());
        Console.WriteLine("Площа квадрата: " + square.Area());
        Console.WriteLine("Радіус описаного кола: " + square.R);
        Console.WriteLine("Радіус вписаного кола: " + square.r);
    }
}
