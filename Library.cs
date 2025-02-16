using System.Collections.Generic;
using System;
namespace LibraryManagementSystem{
  class Library { 




      protected List<Book> books = new List<Book>();
    
  
  public void AddBook(Book book){

    books.Add(book);

  }  
  
  public List<Book> SearchByTitle(string name){
      List<Book> results = new List<Book>();
    foreach(Book book in books){
      if(book.Title.Contains(name)){
          results.Add(book);
      }
    }
    return results;

  }
  
  public List<Book> DisplayAllBooks(){
    List<Book> all = new List<Book>();
     foreach(Book book in books){
        all.Add(book);
  }
  return all;
     }
  

  
  }

  
  }
