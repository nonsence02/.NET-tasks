using System;
using System.CodeDom.Compiler;
using System.Linq;


namespace Arrays
{
    class Class
    {
        static void InputA(double[] a)
        {
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Введіть елемент масиву " + i + " = ");

                a[i] = Convert.ToDouble(Console.ReadLine());

            }
            

        }
        static void Print(double[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static int FindMinimal(double[] A, double minimal, int index)
        {
            for(int i=0; i < A.Length; i++)
            {
                if (A[i] < minimal)
                {
                    minimal = A[i];
                    index = i;
                }
            }
            return index;
        }
        static int FindMaxNegative(double[] A, double maxneg,int index)
        {
            
            for(int i = 0; i < A.Length; i++)
            {
                if (A[i]>=maxneg & A[i] < 0)
                {
                    maxneg = A[i];
                    index = i;

                }
            }
           return index;
            
        }
        static double[] FindNumberBetween(int indexmin, int indexmax, double[] A, double[] C)
        {
            int k = 0;
            if(indexmin < indexmax)
            {
                for(int i = indexmax; i >= indexmin; i--)
                {
                   
                    C[k] = A[i];
                    k++;
                }
            }
            else
            {
                for (int i = indexmin; i >= indexmax; i--)
                {
                   
                    C[k] = A[i];
                    k++;
                }
            }
            return C;
        }




        static void Main(string[] args)
        {
            int lang,indexmax = -1,indexmin = -1;
            double minimal = 0,maxneg = -2000000000;
            Console.WriteLine("Введіть кількість елементів масиву А: ");
            lang = int.Parse(Console.ReadLine());
            double[] a = new double[lang];
            InputA(a);
            Print(a);
            indexmax = FindMaxNegative(a, maxneg,indexmax);
            indexmin = FindMinimal(a,minimal,indexmin);
            int langc = Math.Abs(indexmax - indexmin);
            double[] c = new double[langc + 1];
            c = FindNumberBetween(indexmin, indexmax, a, c);
            Console.WriteLine("Елементи між максимальним з негативних і мінімальним: ");
            Print(c);



        }
        

    }
}