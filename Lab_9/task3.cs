using System;

// Оголошення делегата
delegate double CircleOperation(double R);

// Клас з методами для обчислення характеристик кола та кулі
class CircleCalculator
{
    // Метод для обчислення довжини кола
    public double CalculateCircumference(double R)
    {
        return 2 * Math.PI * R;
    }

    // Метод для обчислення площі круга
    public double CalculateArea(double R)
    {
        return Math.PI * R * R;
    }

    // Метод для обчислення об'єму кулі
    public double CalculateVolume(double R)
    {
        return (4.0 / 3.0) * Math.PI * R * R * R;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення екземпляра класу з методами
        CircleCalculator calculator = new CircleCalculator();

        // Створення делегата та прив'язка до методів
        CircleOperation operation = calculator.CalculateCircumference;
        operation += calculator.CalculateArea;
        operation += calculator.CalculateVolume;

        // Вхідний параметр - радіус кола R
        double R = 5.0;

        // Виклик методів через делегат та виведення результатів
        foreach (CircleOperation op in operation.GetInvocationList())
        {
            double result = op.Invoke(R);
            Console.WriteLine($"Результат: {result}");
        }
    }
}
