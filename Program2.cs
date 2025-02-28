using System;
using System.Collections.Generic;

//creating an abstract class 'Product'
abstract class Product {
    protected int productId;
    protected string name;
    protected double price;

    //constructor to initialize product details
    public Product(int productId, string name, double price) {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    //abstract method to calculate discount
    public abstract double CalculateDiscount();

    //method to display product details
    public virtual void DisplayDetails() {
        Console.WriteLine("Product Details:\nProduct ID: {0}\nName: {1}\nPrice: {2}", productId, name, price);
    }

    //method to update product price
    public void SetPrice(double newPrice) {
        if (newPrice > 0) {
            price = newPrice;
        } else {
            Console.WriteLine("Invalid price!");
        }
    }

    //method to get product price
    public double GetPrice() {
        return price;
    }
}

//creating interface for taxable products
interface ITaxable {
    double CalculateTax();
    string GetTaxDetails();
}

//creating 'Electronics' class inheriting from Product and implementing ITaxable
class Electronics : Product, ITaxable {
    private double taxRate = 0.12; //12% tax

    //constructor to initialize Electronics details
    public Electronics(int id, string name, double price) : base(id, name, price){ }

    //method to calculate discount for electronics
    public override double CalculateDiscount() {
        return price * 0.10; //10% discount
    }

    //method to calculate tax
    public double CalculateTax() {
        return price * taxRate;
    }

    //method to get tax details
    public string GetTaxDetails() {
        return "Tax Rate: 18%";
    }

    //method to display product details
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine(GetTaxDetails());
    }
}

//creating 'Clothing' class inheriting from Product and implementing ITaxable
class Clothing : Product, ITaxable {
    private double taxRate = 0.05; // 5% tax

    //constructor to initialize Clothing details
    public Clothing(int id, string name, double price) : base(id, name, price) { }

    //method to calculate discount for clothing
    public override double CalculateDiscount() {
        return price * 0.15; //15% discount
    }

    //method to calculate tax
    public double CalculateTax() {
        return price * taxRate;
    }

    //method to get tax details
    public string GetTaxDetails() {
        return "Tax Rate: 5%";
    }

    //method to display product details
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine(GetTaxDetails());
    }
}

//creating 'Groceries' class inheriting from Product
class Groceries : Product {
    //constructor to initialize Groceries details
    public Groceries(int id, string name, double price) : base(id, name, price) { }

    //method to calculate discount for groceries
    public override double CalculateDiscount() {
        return price * 0.05; //5% discount
    }
}

class Program2{
    public static void Main(string[] args) {
        //creating a list of products
        List<Product> products = new List<Product>();

        //adding an electronic product
        Electronics phone = new Electronics(123, "Smartphone", 25000);
        products.Add(phone);

        //adding a clothing product
        Clothing tShirt = new Clothing(456, "T-Shirt", 800);
        products.Add(tShirt);

        //adding a grocery product
        Groceries rice = new Groceries(789, "Rice", 200);
        products.Add(rice);

        //iterating through the list to display product details and final price
        foreach(Product product in products){
            product.DisplayDetails();
            double tax = 0;
			if (product is ITaxable) {
				tax = ((ITaxable)product).CalculateTax();
			}
            double discount = product.CalculateDiscount();
            double finalPrice = product.GetPrice() + tax - discount;
            Console.WriteLine("Final Price (after tax & discount): {0}", finalPrice);
            Console.WriteLine(new string('-', 60));
        }
    }
}
