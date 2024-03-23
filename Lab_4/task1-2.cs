using System;

class A
{
    public int a = 5;
    public int b = 3;
    public int C => a + b;

    public A()
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        A objA = new A();
        Console.WriteLine("Значення властивості C для класу A: " + objA.C);

        B objB1 = new B(2, 3, 4);
        Console.WriteLine("Значення властивості c2 для класу B (за допомогою успадкування): " + objB1.c2);

        B objB2 = new B(1, 2, 3, 4);
        Console.WriteLine("Значення властивості c2 для класу B (за допомогою власного конструктора): " + objB2.c2);
    }
}

class B : A
{
    public int d;

    public B(int a, int b, int d) : base()
    {
        this.a = a;
        this.b = b;
        this.d = d;
    }

    public B(int a, int b, int c, int d) : base()
    {
        this.a = a;
        this.b = b;
        this.d = d;
    }

    public int c2
    {
        get
        {
            int result;
            if (a > b)
                result = (a + b) * d;
            else
                result = (a - b) * d;
            return result;
        }
    }
}
