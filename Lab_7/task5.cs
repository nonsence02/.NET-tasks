using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Ініціалізуємо випадковий генератор
        Random random = new Random();

        // Створюємо ArrayList
        ArrayList arrayList = new ArrayList();

        // Додаємо випадкові значення типу int в діапазоні від 100 до 400
        for (int i = 0; i < 2080; i++)
        {
            int randomNumber = random.Next(100, 401);
            arrayList.Add(randomNumber);
        }

        // Сортуємо набір в порядку зростання
        arrayList.Sort();

        // Виводимо всі елементи набору за допомогою циклу foreach
        Console.WriteLine("Елементи набору після сортування:");
        foreach (int number in arrayList)
        {
            Console.WriteLine(number);
        }

        // Значення номера варіанту (Варіант 10)
        int variantNumber = 10;

        // Заносимо номер варіанту на відповідну позицію у наборі
        arrayList.Insert(variantNumber, variantNumber);

        // Згенерувати нове значення та перевірити чи воно є в наборі
        int newValue = random.Next(0, variantNumber + 1000);
        int index = arrayList.IndexOf(newValue);
        if (index != -1)
        {
            Console.WriteLine($"Значення {newValue} знаходиться в наборі на позиції {index}.");
        }
        else
        {
            Console.WriteLine($"Значення {newValue} не знайдено в наборі.");
        }

        // Видаляємо елемент набору, рівний випадковому значенню
        int maxIndex = arrayList.Count - 1;
        int randomIndex = random.Next(0, maxIndex + 1);
        int elementToRemove = (int)arrayList[randomIndex];
        arrayList.RemoveAt(randomIndex);
        Console.WriteLine($"Видалений елемент набору: {elementToRemove}");

        // Видаляємо всі елементи набору
        arrayList.Clear();
        Console.WriteLine($"Всі елементи набору було видалено. Кількість елементів у наборі: {arrayList.Count}");
    }
}
