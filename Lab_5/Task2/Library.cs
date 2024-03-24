using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    public List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }
    public Book FindBookByCode(string code)
    {
        return books.FirstOrDefault(book => book.Code == code);
    }

    public IEnumerable<Book> CompareBooks(Func<Book, Book, int> comparer)
    {
        return books.OrderBy(b => b, new BookComparer(comparer));
    }

    private class BookComparer : IComparer<Book>
    {
        private readonly Func<Book, Book, int> _comparer;

        public BookComparer(Func<Book, Book, int> comparer)
        {
            _comparer = comparer;
        }

        public int Compare(Book x, Book y)
        {
            return _comparer(x, y);
        }
    }
}
