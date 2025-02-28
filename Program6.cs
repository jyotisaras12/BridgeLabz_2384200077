using System;
using System.Collections.Generic;

//creating an abstract class 'FoodItem'
abstract class FoodItem {
    protected string itemName;
    protected double price;
    protected int quantity;

    //constructor to initialize food item details
    public FoodItem(string itemName, double price, int quantity) {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    //abstract method to calculate total price
    public abstract double CalculateTotalPrice();

    //method to display item details
    public virtual void GetItemDetails() {
        Console.WriteLine("Food Item Details:\nName: {0}\nPrice: {1}\nQuantity: {2}", itemName, price, quantity);
    }
}

//creating interface for discountable items
interface IDiscountable {
    double ApplyDiscount();
    string GetDiscountDetails();
}

//creating 'VegItem' class inheriting from FoodItem and implementing IDiscountable
class VegItem : FoodItem, IDiscountable {
    private double discountRate = 0.10; // 10% discount

    //constructor to initialize VegItem details
    public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    //method to calculate total price for veg items
    public override double CalculateTotalPrice() {
        return price * quantity;
    }

    //method to apply discount
    public double ApplyDiscount() {
        return CalculateTotalPrice() * discountRate;
    }

    //method to get discount details
    public string GetDiscountDetails() {
        return "Discount: 10% on Veg Items";
    }

    //method to display item details
    public override void GetItemDetails() {
        base.GetItemDetails();
        Console.WriteLine(GetDiscountDetails());
    }
}

//creating 'NonVegItem' class inheriting from FoodItem and implementing IDiscountable
class NonVegItem : FoodItem, IDiscountable {
    private double additionalCharge = 20; // Extra charge for non-veg items
    private double discountRate = 0.05; // 5% discount

    //constructor to initialize NonVegItem details
    public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    //method to calculate total price for non-veg items
    public override double CalculateTotalPrice() {
        return (price * quantity) + additionalCharge;
    }

    //method to apply discount
    public double ApplyDiscount() {
        return CalculateTotalPrice() * discountRate;
    }

    //method to get discount details
    public string GetDiscountDetails() {
        return "Discount: 5% on Non-Veg Items";
    }

    //method to display item details
    public override void GetItemDetails() {
        base.GetItemDetails();
        Console.WriteLine(GetDiscountDetails());
    }
}

class Program6 {
    public static void Main(string[] args) {
        //creating a list of food items
        List<FoodItem> foodItems = new List<FoodItem>();

        //adding a veg item
        VegItem salad = new VegItem("Salad", 150, 2);
        foodItems.Add(salad);

        //adding a non-veg item
        NonVegItem chickenBurger = new NonVegItem("Chicken Burger", 250, 1);
        foodItems.Add(chickenBurger);

        //iterating through the list to display item details, total price, and discount
        foreach(FoodItem item in foodItems) {
            item.GetItemDetails();
            double totalPrice = item.CalculateTotalPrice();
            double discount = (item is IDiscountable) ? ((IDiscountable)item).ApplyDiscount() : 0;
            Console.WriteLine("Total Price (before discount): {0}", totalPrice);
            Console.WriteLine("Final Price (after discount): {0}", totalPrice - discount);
            Console.WriteLine(new string('-', 40));
        }
    }
}
