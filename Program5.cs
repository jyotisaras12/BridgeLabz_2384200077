using System;
using System.Collections.Generic;

//creating an abstract class 'LibraryItem'
abstract class LibraryItem {
    protected int itemId;
    protected string title;
    protected string author;

    //constructor to initialize library item details
    public LibraryItem(int itemId, string title, string author) {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    //abstract method to get loan duration
    public abstract int GetLoanDuration();

    //method to display item details
    public virtual void GetItemDetails() {
        Console.WriteLine("Item Details:\nID: {0}\nTitle: {1}\nAuthor: {2}", itemId, title, author);
    }
}

//creating interface for reservable items
interface IReservable {
    void ReserveItem();
    bool CheckAvailability();
}

//creating 'Book' class inheriting from LibraryItem and implementing IReservable
class Book : LibraryItem, IReservable {
    private bool isAvailable = true; 

    //constructor to initialize Book details
    public Book(int itemId, string title, string author) : base(itemId, title, author) { }

    //method to get loan duration for books
    public override int GetLoanDuration() {
        return 14; //14 days loan period
    }

    //method to reserve a book
    public void ReserveItem() {
        if (isAvailable) {
            isAvailable = false;
            Console.WriteLine("Book reserved successfully.");
        } 
		else {
            Console.WriteLine("Book is already reserved.");
        }
    }

    //method to check book availability
    public bool CheckAvailability() {
        return isAvailable;
    }
}

//creating 'Magazine' class inheriting from LibraryItem
class Magazine : LibraryItem {
    //constructor to initialize Magazine details
    public Magazine(int itemId, string title, string author) : base(itemId, title, author) { }

    //method to get loan duration for magazines
    public override int GetLoanDuration() {
        return 7; // 7 days loan period
    }
}

//creating 'DVD' class inheriting from LibraryItem and implementing IReservable
class DVD : LibraryItem, IReservable {
    private bool isAvailable = true; // Availability status

    //constructor to initialize DVD details
    public DVD(int itemId, string title, string author) : base(itemId, title, author) { }

    //method to get loan duration for DVDs
    public override int GetLoanDuration() {
        return 5; // 5 days loan period
    }

    //method to reserve a DVD
    public void ReserveItem() {
        if (isAvailable) {
            isAvailable = false;
            Console.WriteLine("DVD reserved successfully.");
        } else {
            Console.WriteLine("DVD is already reserved.");
        }
    }

    //method to check DVD availability
    public bool CheckAvailability() {
        return isAvailable;
    }
}

class Program5{
    public static void Main(string[] args) {
        //creating a list of library items
        List<LibraryItem> items = new List<LibraryItem>();

        //adding a book
        Book book = new Book(123, "Divine Rivals", "Rebecca Ross");
        items.Add(book);

        //adding a magazine
        Magazine magazine = new Magazine(456, "Champak", "Atul Joshi");
        items.Add(magazine);

        // Adding a DVD
        DVD dvd = new DVD(103, "Learn C#", "Alan Will");
        items.Add(dvd);

        //iterating through the list to display item details and loan duration
        foreach (LibraryItem item in items) {
            item.GetItemDetails();
            Console.WriteLine("Loan Duration: {0} days", item.GetLoanDuration());

            //checking if the item is reservable
            if (item is IReservable) {
                IReservable reservable = (IReservable)item;
                Console.WriteLine("Availability: {0}", reservable.CheckAvailability() ? "Available" : "Not Available");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
