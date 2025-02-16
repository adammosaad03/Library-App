using System;
namespace LibraryManagementSystem{
  public class Book  {

      public Book(string title, string author){
        Title = title;
        Author = author;
      }

        public string Title
        {get; set;}

        public string Author
        {get; set;}

  }

}
