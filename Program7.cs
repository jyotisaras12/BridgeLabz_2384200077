using System;
class Product{
    //instance variables 
    public string ProductName { get; set; }
    public double Price { get; set; }

    //class variable 
    public static int TotalProducts { get; private set; }
	
	//static constructor to initialize the static field
    static Product(){
        TotalProducts = 0; 
    }

    //constructor to initialize product details
    public Product(string productName, double price){
        ProductName = productName;
        Price = price;
        TotalProducts++;  //increment the total count of products
    }

    //method to display product details
    public void DisplayProductDetails(){
        Console.WriteLine("Product Name: {0}\nPrice: {1}",ProductName, Price);
        Console.WriteLine();
    }

    //method to display total number of products
    public static void DisplayTotalProducts(){
        Console.WriteLine("Total Number of Products are: "+TotalProducts);
    }
}

class Program7{
    static void Main(string[] args){
        //creating product objects
        Product product1 = new Product("Diary", 400);
        Product product2 = new Product("Pen", 50);
		Product product3 = new Product("Shoes", 1500);
  

        //displaying product details
        Console.WriteLine("Product 1 Details:");
        product1.DisplayProductDetails();

        Console.WriteLine("Product 2 Details:");
        product2.DisplayProductDetails();

        Console.WriteLine("Product 3 Details:");
        product3.DisplayProductDetails();

        //displaying total number of products created
        Product.DisplayTotalProducts();
    }
}
