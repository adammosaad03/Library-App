using System;
using System.Collections.Generic;

namespace LibraryManagementSystem{
  class Program {
    static void Main() {
      // Initialize library
  Library library = new Library();

      // Add some sample books
      Book book1 = new Book("1984", "George Orwell" );
      Book book2 = new Book("To Kill a Mockingbird", "Harper Lee" );
      Book book3 = new Book("To Kill the interview", "Adam Mosaad" );
      Book book4 = new Book("OOP The Hard Parts", "Will Sentance" );
      Book book5 = new Book("C# Fundamentals", "Steve Just" );
      library.AddBook(book1);
      library.AddBook(book2);
      library.AddBook(book3);
      library.AddBook(book4);
      library.AddBook(book5);
      // Search for a book
    List<Book> results = library.SearchByTitle("1984");
        foreach(Book book in results){
          Console.WriteLine($"Title: {book.Title} Author: {book.Author}");
        }
      // Display all books
      List<Book> all = library.DisplayAllBooks();

      foreach(Book book in all){
        Console.WriteLine($"Title: {book.Title} Author: {book.Author}");
      }
    }
  }
}
