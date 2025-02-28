using System;

//creating base class: Order
class Order{
    private int orderId { get; set; }
    private DateTime orderDate { get; set; }

	//constructor to initialise Order details
    public Order(int orderId, DateTime orderDate){
        this.orderId = orderId;
        this.orderDate = orderDate;
    }
	
	//method to show order status
    public virtual string GetOrderStatus(){
        return "Order placed";
    }
}

//creating subclass: ShippedOrder
class ShippedOrder : Order{
    private string trackingNumber { get; set; }
	
	//constructor to initialise ShippedOrder details
    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber) : base(orderId, orderDate)
    {
        this.trackingNumber = trackingNumber;
    }

	//method to show order status
    public override string GetOrderStatus(){
        return ("Order shipped with Tracking Number: " + trackingNumber);
    }
}

//creating subclass: DeliveredOrder
class DeliveredOrder : ShippedOrder{
    private DateTime deliveryDate { get; set; }

	//constructor to initialise DeliveredOrder details
    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate) : base(orderId, orderDate, trackingNumber){
        this.deliveryDate = deliveryDate;
    }

	//method to show order status
    public override string GetOrderStatus(){
        return ("Order delivered on " + deliveryDate.ToShortDateString());
    }
}

class Program6{
    static void Main(string[] args){
		//creating objects for 'Order', 'ShippedOrder' and 'DeliveredOrder' classes
        Order order = new Order(1234, DateTime.Now);
        ShippedOrder shippedOrder = new ShippedOrder(1357, DateTime.Now, "TCK123456");
        DeliveredOrder deliveredOrder = new DeliveredOrder(2468, DateTime.Now, "TCK456353", DateTime.Now.AddDays(3));

		//displaying order status
        Console.WriteLine(order.GetOrderStatus());
        Console.WriteLine(shippedOrder.GetOrderStatus());
        Console.WriteLine(deliveredOrder.GetOrderStatus());
    }
}
