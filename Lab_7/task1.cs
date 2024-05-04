using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "input.txt";

        string expression = File.ReadAllText(filePath);

        if (IsBalanced(expression))
        {
            Console.WriteLine("Дужки виразу збалансовані.");
        }
        else
        {
            Console.WriteLine("Дужки виразу не збалансовані.");
        }
    }

    static bool IsBalanced(string expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char symbol in expression)
        {
            if (symbol == '(')
            {
                stack.Push(symbol); 
            }
            else if (symbol == ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(')
                {
                    return false; 
                }
            }
        }

        return stack.Count == 0; 
    }
}
