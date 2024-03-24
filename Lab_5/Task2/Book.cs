using System;

public class Book
{
    public string Author { get; }
    public string Title { get; }
    public string Code { get; }
    public int Year { get; }
    public int PageCount { get; }
    public string Genre { get; }

    public Book(string author, string title, string code, int year, int pageCount, string genre)
    {
        Author = author;
        Title = title;
        Code = code;
        Year = year;
        PageCount = pageCount;
        Genre = genre;
    }

    public override string ToString()
    {
        return $"Автор: {Author}\nНазва: {Title}\nКод: {Code}\nРік видання: {Year}\nКількість сторінок: {PageCount}\nЖанр: {Genre}";
    }
}
