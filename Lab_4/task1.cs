using System;
class MyClass
{
    public int a = 10;
    public int b = 5;
    public int C
    {
        get
        {
            return a + b;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        Console.WriteLine("Значення властивості C: " + obj.C);
    }
}
