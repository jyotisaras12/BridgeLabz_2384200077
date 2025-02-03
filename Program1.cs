using System;
class Book{
    //declaring fields
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    //default Constructor
    public Book(){
        Title = "Atomic Habits";
        Author = "James Clear";
        Price = 150.0;
    }

    //parameterized Constructor
    public Book(string title, string author, double price){
        Title = title;
        Author = author;
        Price = price;
    }
	
	//display Book Details
    public void DisplayBookDetails()
    {
        Console.WriteLine("Book Title: {0}\nAuthor: {1}\nPrice: {2}", Title, Author, Price);
    }

}

class Program1{
    static void Main(string[] args){
        //using the default constructor
        Book book1 = new Book();
		Console.WriteLine("Book 1:");
        book1.DisplayBookDetails();

        //Console.WriteLine("Book 1:\nTitle: {0}\nAuthor: {1}\nPrice: {2}",book1.Title,book1.Author,book1.Price);

        //using the parameterized constructor
        Book book2 = new Book("Divine Rivals", "Rebecca Ross", 99.99);
		Console.WriteLine("Book 2:");
        book2.DisplayBookDetails();

        
		
		//Console.WriteLine("Book 2:\nTitle: {0}\nAuthor: {1}\nPrice: {2}",book2.Title,book2.Author,book2.Price);
    }
}
