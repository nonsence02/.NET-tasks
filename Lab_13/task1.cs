using System;

class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static bool operator ==(Point point1, Point point2)
    {
        if (ReferenceEquals(point1, null))
        {
            return ReferenceEquals(point2, null);
        }

        if (ReferenceEquals(point2, null))
        {
            return false;
        }

        return point1.X == point2.X && point1.Y == point2.Y;
    }

    public static bool operator !=(Point point1, Point point2)
    {
        return !(point1 == point2);
    }

    public override bool Equals(object obj)
    {
        if (obj is Point)
        {
            return this == (Point)obj;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode();
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main()
    {
        Point point1 = new Point(1, 2);
        Point point2 = new Point(1, 2);
        Point point3 = new Point(3, 4);

        Console.WriteLine($"Точка 1: {point1}");
        Console.WriteLine($"Точка 2: {point2}");
        Console.WriteLine($"Точка 3: {point3}");

        Console.WriteLine($"point1 == point2: {point1 == point2}");
        Console.WriteLine($"point1 != point2: {point1 != point2}");
        Console.WriteLine($"point1 == point3: {point1 == point3}");
        Console.WriteLine($"point1 != point3: {point1 != point3}");
    }
}
