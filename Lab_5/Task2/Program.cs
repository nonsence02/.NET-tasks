using System;
using System.Collections.Generic;

class Program
{
    static Library library = new Library();

    static void Main(string[] args)
    {
        bool exit = false;

        library.AddBook(new Book("Шевченко Т.Г.", "Кобзар", "B001", 1840, 352, "Поезія"));
        library.AddBook(new Book("Гоголь Н.В.", "Мертві душі", "B002", 1842, 352, "Роман"));
        library.AddBook(new Book("Шекспір В.", "Ромео і Джульєтта", "B003", 1597, 256, "Драма"));
        library.AddBook(new Book("Орвелл Дж.", "1984", "B004", 1949, 328, "Антиутопія"));
        library.AddBook(new Book("Толстой Л.Н.", "Війна і мир", "B005", 1869, 1225, "Роман"));

        while (!exit)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Перегляд всіх книг");
            Console.WriteLine("2. Пошук книги за кодом");
            Console.WriteLine("3. Додати книгу");
            Console.WriteLine("4. Видалити книгу");
            Console.WriteLine("5. Вихід");
            Console.Write("Виберіть опцію: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DisplayAllBooks();
                    break;
                case "2":
                    SearchBookByCode();
                    break;
                case "3":
                    AddBook();
                    break;
                case "4":
                    RemoveBook();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DisplayAllBooks()
    {
        Console.WriteLine("Усі книги в бібліотеці:");
        foreach (var book in library.books)
        {
            Console.WriteLine(book);
        }
    }

    static void SearchBookByCode()
    {
        Console.Write("Введіть код книги: ");
        string code = Console.ReadLine();
        Book foundBook = library.FindBookByCode(code);
        if (foundBook != null)
        {
            Console.WriteLine($"Знайдено книгу за кодом '{code}':\n{foundBook}");
        }
        else
        {
            Console.WriteLine($"Книга з кодом '{code}' не знайдена.");
        }
    }

    static void AddBook()
    {
        Console.WriteLine("Додавання нової книги:");

        Console.Write("Прізвище ім'я по-батькові автора: ");
        string author = Console.ReadLine();

        Console.Write("Назва книги: ");
        string title = Console.ReadLine();

        Console.Write("Код: ");
        string code = Console.ReadLine();

        Console.Write("Рік видання: ");
        int year;
        while (!int.TryParse(Console.ReadLine(), out year) || year < 0)
        {
            Console.WriteLine("Невірний формат року. Введіть ціле додатнє число.");
        }

        Console.Write("Кількість сторінок: ");
        int pageCount;
        while (!int.TryParse(Console.ReadLine(), out pageCount) || pageCount < 0)
        {
            Console.WriteLine("Невірний формат кількості сторінок. Введіть ціле додатнє число.");
        }

        Console.Write("Жанр: ");
        string genre = Console.ReadLine();

        Book newBook = new Book(author, title, code, year, pageCount, genre);
        library.AddBook(newBook);

        Console.WriteLine("Книга успішно додана до бібліотеки.");
    }

    static void RemoveBook()
    {
        Console.Write("Введіть код книги, яку бажаєте видалити: ");
        string code = Console.ReadLine();
        Book foundBook = library.FindBookByCode(code);
        if (foundBook != null)
        {
            library.RemoveBook(foundBook);
            Console.WriteLine($"Книга з кодом '{code}' успішно видалена.");
        }
        else
        {
            Console.WriteLine($"Книга з кодом '{code}' не знайдена.");
        }
    }
}
