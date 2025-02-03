using System;
class Book{
    //declaring fields
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; } 

    //default constructor
    public Book(){
        Title = "Atomic Habits";
        Author = "James Clear";
        Price = 150.0;
        IsAvailable = true;
    }

    //parameterized constructor
    public Book(string title, string author, double price, bool isAvailable){
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = isAvailable;
    }

    //method to borrow a book
    public void BorrowBook(){
        if(IsAvailable){
            Console.WriteLine("You have borrowed '{0}' by {1}.", Title, Author);
            IsAvailable = false; //book unavailable after borrowing
        }
        else{
            Console.WriteLine("Sorry, '{0}' by {1} is not available for borrowing.",Title, Author);
        }
    }

    //method to display book details
    public void DisplayBookInfo(){
        Console.WriteLine("Title: {0}\nAuthor: {1}\nPrice: {2}\nAvailable: {3}",Title, Author, Price, IsAvailable);
    }
}

class Program5{
    static void Main(string[] args){
        //creating book objects
        Book book1 = new Book("Divine Rivals", "Rebecca Ross", 99.99, true);
        Book book2 = new Book("Harry Potter", "J.K. Rowling", 250, false);

        //displaying book details
        Console.WriteLine("Book 1 Details:");
        book1.DisplayBookInfo();

        Console.WriteLine("Book 2 Details:");
        book2.DisplayBookInfo();

        // Borrowing books
        book1.BorrowBook();  //book 1 is available
        book2.BorrowBook();  //book 2 is not available  
    }
}
