using System;
using System.Collections.Generic;

//creating 'Product' class
class Product{
    public string name { get; private set; }
    public double price { get; private set; }

	//constructor to initialise Product details
    public Product(string name, double price){
        this.name = name;
        this.price = price;
    }

    //displaying product details
    public void DisplayProduct(){
        Console.WriteLine("Product: {0}, Price (in Rs.): {1}",name,price);
    }
}

//creating 'Order' class
class Order{
    private static int orderCounter = 1;
    public int orderID { get; private set; }
    public Customer customer { get; private set; }
    private List<Product> products;
	
	//constructor to initialise Order details
    public Order(Customer customer){
        orderID = orderCounter++;
        this.customer = customer;
        products = new List<Product>();
    }

    //method to add product to order
    public void AddProduct(Product product){
        products.Add(product);
    }

    //method to display order details
    public void DisplayOrder(){
        Console.WriteLine("Order ID: {0}, Customer: {1}\n", orderID, customer.name);
        Console.WriteLine("Products in order:");
        if(products.Count == 0) Console.WriteLine("No products in this order.");
        else{
            foreach (Product product in products){
                product.DisplayProduct();
			}
		}

        Console.WriteLine("\nTotal Price (in Rs.): "+CalculateTotalPrice());
    }

    //method to calculate total price of order
    public double CalculateTotalPrice(){
        double total = 0;
        foreach(Product product in products){
            total += product.price;
		}
        return total;
    }
}

//creating 'Customer' class
class Customer{
    public string name { get; private set; }
    private List<Order> orders; 
	
	//constructor to initialise Customer
    public Customer(string name){
        this.name = name;
        orders = new List<Order>();
    }

    //method to place an order
    public Order PlaceOrder(){
        Order newOrder = new Order(this);
        orders.Add(newOrder);
        return newOrder;
    }

    //method to display all orders of a customer
    public void DisplayOrders(){
        Console.WriteLine("\nOrders for Customer: {0}",name);
        if(orders.Count == 0) Console.WriteLine("No orders placed.");
        else{
            foreach(Order order in orders){
                order.DisplayOrder();
			}
		}
    }
}

//creating 'Ecommerce' class
class ECommerce{
    private List<Customer> customers;
    private List<Product> products;

	//constructor to initialise ECommerce details
    public ECommerce(){
        customers = new List<Customer>();
        products = new List<Product>();
    }

    //method to add a customer to the platform
    public void AddCustomer(Customer customer){
        customers.Add(customer);
    }

    //method to add a product to the platform
    public void AddProduct(Product product){
        products.Add(product);
    }

    //method to display available products
    public void ShowProducts(){
        Console.WriteLine("\nAvailable Products:");
        if(products.Count == 0) Console.WriteLine("No products available.");
        else{
            foreach(Product product in products){
                product.DisplayProduct();
			}
		}
    }
}

class Program7{
    static void Main(string[] args){
        //crerating ECommerce object
        ECommerce eCommerce = new ECommerce();

        //creating Products
        Product prod1 = new Product("Headphones", 2000);
        Product prod2 = new Product("Smart watch", 3100);
        Product prod3 = new Product("Diary", 500);

        //addong products to the platform
        eCommerce.AddProduct(prod1);
        eCommerce.AddProduct(prod2);
        eCommerce.AddProduct(prod3);

        //creating Customers
        Customer cust1 = new Customer("Avishi");
        Customer cust2 = new Customer("Sejal");

        //adding customers to the platform
        eCommerce.AddCustomer(cust1);
        eCommerce.AddCustomer(cust2);

        //showing available products
        eCommerce.ShowProducts();
		Console.WriteLine(new string('-', 50));

        //customer 1 places an order
        Order cust1Order = cust1.PlaceOrder();
        cust1Order.AddProduct(prod1);
        cust1Order.AddProduct(prod2);

        //customer 2 places an order
        Order cust2Order = cust2.PlaceOrder();
        cust2Order.AddProduct(prod3);

        //displaying orders for each customer
        cust1.DisplayOrders();
		Console.WriteLine(new string('-', 50));
        cust2.DisplayOrders();
    }
}
