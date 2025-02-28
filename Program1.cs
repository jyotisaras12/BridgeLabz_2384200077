using System;
using System.Collections.Generic;

//creating class 'Book'
public class Book{
    private string title { get; set; }
    private string author { get; set; }

    //constructor to initialize the book with title and author
    public Book(string title, string author){
        this.title = title;
        this.author = author;
    }

    //method to display book details
    public void DisplayBookDetails(){
        Console.WriteLine("Title: {0}\nAuthor: {1}\n", title, author);
    }
}

//creating class 'Library'
public class Library{
    private string libraryName { get; set; }
    private List<Book> books { get; set; }

    //constructor to initialize the library
    public Library(string libraryName){
        this.libraryName = libraryName;
        this.books = new List<Book>();	//initializes an empty list of books
    }

    //method to add a book to the library
    public void AddBook(Book book){
        books.Add(book);
    }

    //method to display all books in the library
    public void DisplayLibraryBooks(){
        Console.WriteLine("Library: " + libraryName);
        foreach(Book book in books){	//traversing through 'Book' objects
            book.DisplayBookDetails();  //calling 'DisplayBookDetails'
        }
    }
}

class Program1{
    static void Main(string[] args){
        //creating Book objects
        Book book1 = new Book("Harry Potter", "J.K. Rowling");
        Book book2 = new Book("Divine Rivals", "Rebecca Ross");
        Book book3 = new Book("Atomic Habits", "James Clear");
		Book book4 = new Book("The Pyschology of Money", "Morgan Housel");

        //creating Library objects
        Library library1 = new Library("Central Library");
        Library library2 = new Library("AB-10 Library");
		Library library3 = new Library("Department Library");
		

        //adding books to the libraries
        library1.AddBook(book1);
        library1.AddBook(book2);
        library2.AddBook(book3);
		library3.AddBook(book4);

        //displaying the books in each library
        library1.DisplayLibraryBooks();
        library2.DisplayLibraryBooks();
		library3.DisplayLibraryBooks();
    }
}
