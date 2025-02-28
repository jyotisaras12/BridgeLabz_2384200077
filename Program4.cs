using System;

//creating base class: Book
class Book{
    private string title { get; set; }
    private int publicationYear { get; set; }

	//constructor to initialise Book details
    public Book(string title, int publicationYear){
        this.title = title;
        this.publicationYear = publicationYear;
    }
	
	//method to display details
    public virtual void DisplayInfo(){
        Console.WriteLine("Title: {0}\nPublication Year: {1}",title, publicationYear);
    }
}

//creating subclass: Author
class Author : Book{
    private string name { get; set; }
    private string bio { get; set; }

	//constructor to initialise Author details
    public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear){
        this.name = name;
        this.bio = bio;
    }

	//method to display details
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Author: {0}\nBio: {1}",name, bio);
    }
}

class Program4{
    static void Main(string[] args){
		//creating Author object
        Author author = new Author("Atomic Habits", 2012, "James Clear", "Sharing quotes about habits and behavior change.");
        author.DisplayInfo();
    }
}
