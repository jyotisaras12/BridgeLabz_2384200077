using System;
//'Book' class
public class Book{
    //attributes(fields) of the Book class
    private string title;
    private string author;
    private double price;

    //constructor to initialize the book's details
    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }

    //method to display book details
    public void DisplayDetails(){
        Console.WriteLine("Book Details:");
        Console.WriteLine("Title: "+title);
        Console.WriteLine("Author: "+author);
        Console.WriteLine("Price: "+price);
    }
}

//'ProgramBook' class
public class ProgramBook{
    static void Main(string[] args){
        //creating a Book object
        Book book1 = new Book("Harry Potter", "J. K. Rowling",215.50);
		Book book2 = new Book("Warmth","Ritvik Singh",100);
        
        //printing the details of the book using 'DisplayDetails()' method
        book1.DisplayDetails();
		book2.DisplayDetails();
    }
}
