class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Adding books to the library
        library.AddBook(new Book { Title = "Book 1", Author = "Author 1", Year = 2020 });
        library.AddBook(new Book { Title = "Book 2", Author = "Author 2", Year = 2021 });
        library.AddBook(new Book { Title = "Book 3", Author = "Author 1", Year = 2019 });

        // Printing books by a specific author
        Console.WriteLine("Books by Author 1:");
        library.PrintBooksByAuthor("Author 1");

        // Getting the count of books in the library
        Console.WriteLine($"Total books in the library: {library.Count}");

        // Removing a book from the library
        Book bookToRemove = library.FindBook("Book 2").FirstOrDefault();
        if (bookToRemove != null)
        {
            library.RemoveBook(bookToRemove);
            Console.WriteLine("Book 2 removed from the library.");
        }

        // Finding books by title
        Console.WriteLine("Books with title 'Book 1':");
        var foundBooks = library.FindBook("Book 1");
        foreach (var book in foundBooks)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }
    }
}
