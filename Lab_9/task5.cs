using System;

// Оголошення делегатів
delegate int UseOperation(int a, int b);
delegate void GetGreeting();

class Program
{
    // Методи, що повертають результат і нічого не повертають відповідно
    static int Sum(int a, int b) => a + b;
    static int Difference(int a, int b) => a - b;
    static int Product(int a, int b) => a * b;
    static int Quotient(int a, int b) => b != 0 ? a / b : throw new ArgumentException("Ділення на нуль неможливе.");

    static void GoodMorning() => Console.WriteLine("Доброго ранку!");
    static void GoodDay() => Console.WriteLine("Добрий день!");
    static void GoodEvening() => Console.WriteLine("Добрий вечір!");
    static void GoodNight() => Console.WriteLine("Доброї ночі!");

    static void Main(string[] args)
    {
        // Створення екземплярів делегатів
        UseOperation operation;
        GetGreeting greeting;

        // Визначення поточного часу
        int hour = DateTime.Now.Hour;

        // Вибір методу привітання в залежності від поточного часу
        if (hour >= 6 && hour < 12)
            greeting = GoodMorning;
        else if (hour >= 12 && hour < 18)
            greeting = GoodDay;
        else if (hour >= 18 && hour < 22)
            greeting = GoodEvening;
        else
            greeting = GoodNight;

        // Виклик методу привітання
        greeting();

        // Запит двох цілих чисел від користувача
        Console.WriteLine("Введіть перше число:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int num2 = int.Parse(Console.ReadLine());

        // Запит операції від користувача
        Console.WriteLine("Введіть операцію (+, -, *, /):");
        string op = Console.ReadLine();

        // Вибір методу в залежності від введеної операції
        switch (op)
        {
            case "+":
                operation = Sum;
                break;
            case "-":
                operation = Difference;
                break;
            case "*":
                operation = Product;
                break;
            case "/":
                operation = Quotient;
                break;
            default:
                throw new ArgumentException("Невірна операція.");
        }

        // Виклик методу вибраної операції та виведення результату
        int result = operation(num1, num2);
        Console.WriteLine($"Результат: {result}");
    }
}
