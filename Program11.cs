using System;
class Book{
    //instance variables
    public string ISBN { get; set; }       
    protected string Title { get; set; }    
    private string Author { get; set; }    

    //constructor to initialize book details
    public Book(string isbn, string title, string author){
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    //public method to access author (getter)
    public string GetAuthor(){
        return Author;
    }

    //public method to modify author (setter)
    public void SetAuthor(string author){
        Author = author;
    }

    //method to display book details
    public void DisplayBookDetails(){
        Console.WriteLine("ISBN: {0}\nTitle: {1}\nAuthor: {2}",ISBN,Title,Author);
    }
}

class EBook : Book{
    //instance variable for EBook
    public double FileSize { get; set; }   

    //constructor to initialize EBook details
    public EBook(string isbn, string title, string author, double fileSize)
        : base(isbn, title, author){
        FileSize = fileSize;
    }

    //method to display EBook details
    public void DisplayEBookDetails(){
		Console.WriteLine("ISBN: {0}\nTitle: {1}\nAuthor: {2}\nFile Size: {3} MB",ISBN,Title,GetAuthor(),FileSize);
    }
}

class Program11{
    static void Main(string[] args){
        //creating a Book object
        Book book = new Book("123-456-789", "C# Programming", "Harry Milton");
        Console.WriteLine("Book Details:");
        book.DisplayBookDetails();

        //modifying the author name using public setter
        book.SetAuthor("Shane Wilston");
        Console.WriteLine("Updated Book Details:");
        book.DisplayBookDetails();

        //creating an EBook object
        EBook eBook = new EBook("123-123-123", "Machine Learning", "Taylor Wane", 12.6);
        Console.WriteLine("EBook Details:");
        eBook.DisplayEBookDetails();
    }
}
