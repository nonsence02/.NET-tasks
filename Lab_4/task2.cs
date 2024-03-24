using System;

class A
{
    public int a;
    public int b;
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
}
class B : A
{
    public int d;
    public B(int a, int b, int d) : base(a, b)
    {
        this.d = d;
    }
    public B(int a, int b, int d, int c2) : base(a, b)
    {
        this.d = d;
    }
    public int c2
    {
        get
        {
            return a > b ? (a + b) * d : (a - b) * d;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        A objA = new A(5, 3);
        Console.WriteLine("Значення полів класу A:");
        Console.WriteLine("a = " + objA.a);
        Console.WriteLine("b = " + objA.b);
        Console.WriteLine();

        B objB1 = new B(10, 5, 2);

        Console.WriteLine("Значення полів класу B (конструктор успадковується від класу A):");
        Console.WriteLine("a = " + objB1.a);
        Console.WriteLine("b = " + objB1.b);
        Console.WriteLine("d = " + objB1.d);
        Console.WriteLine("Значення властивості c2: " + objB1.c2);
        Console.WriteLine();

        B objB2 = new B(8, 4, 3, 20);

        Console.WriteLine("Значення полів класу B (власний конструктор):");
        Console.WriteLine("a = " + objB2.a);
        Console.WriteLine("b = " + objB2.b);
        Console.WriteLine("d = " + objB2.d);

        Console.WriteLine("Значення властивості c2: " + objB2.c2);
    }
}
