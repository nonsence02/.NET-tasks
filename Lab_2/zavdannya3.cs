using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.ExceptionServices;


namespace Arrays
{
    class Class
    {
       static void Main(string[] args)
        {
            string variant;
            double x;
            double z;
            Console.WriteLine("Введіть значення х");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть варіант: ");
            variant = Console.ReadLine();
            switch(variant)
            {
                case "first":
                case "First":
                case "FIRST":
                      z= Math.Pow(Math.Sin(x),2);
                      Console.WriteLine("z = " + z);
                      break;
                case "second":
                case "Second":
                case "SECOND":
                    if(x> 0)
                    {
                        z = Math.Pow(Math.Log(x),2);
                        Console.WriteLine("z = " + z);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("x не може бути менше нуля!");
                        break;
                    }
                case "Third":
                case "third":
                case "THIRD":
                    z = 1 / (Math.Cos(Math.Pow(x, 3)));
                    Console.WriteLine("z = " + z);
                    break;
                default: Console.WriteLine("Неправильний варіант!");
                    break;

            }
        }
        

    }
}