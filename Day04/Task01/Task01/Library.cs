using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    // Method to print books by a specific author
    public void PrintBooksByAuthor(string author)
    {
        var authorBooks = books.Where(book => book.Author == author);
        foreach (var book in authorBooks)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }
    }

    // Property to get the count of books in the library
    public int Count
    {
        get { return books.Count; }
    }

    //  to add a book to the library
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    //  to remove a book from the library
    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    //  to find books by title and return a list
    public List<Book> FindBook(string title)
    {
        return books.Where(book => book.Title == title).ToList();
    }
}
