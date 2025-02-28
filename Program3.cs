using System;

//creating base class: Vehicle
class Vehicle{
    private int maxSpeed { get; set; }
    private string fuelType { get; set; }

	//constructor to initialise Vehicle details
    public Vehicle(int maxSpeed, string fuelType){
        this.maxSpeed = maxSpeed;
        this.fuelType = fuelType;
    }

	//method to display details
    public virtual void DisplayInfo(){
        Console.WriteLine("Max Speed: {0} km/h\nFuel Type: {1}", maxSpeed, fuelType);
    }
}

//creating subclass: Car
class Car : Vehicle{
    private int seatCapacity { get; set; }

	//constructor to initialise Car details
    public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType){
        this.seatCapacity = seatCapacity;
    }
	
	//method to display details
    public override void DisplayInfo(){
        base.DisplayInfo();
		Console.WriteLine("Seat Capacity: "+seatCapacity);
    }
}

//creating subclass: Truck
class Truck : Vehicle{
    public int payloadCapacity { get; set; }

	//constructor to initialise Truck details
    public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType){
        this.payloadCapacity = payloadCapacity;
    }

	//method to display details
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: {0} kg", payloadCapacity);
    }
}

//creating subclass: Motorcycle
class Motorcycle : Vehicle{
    private bool hasSidecar { get; set; }

	//constructor to initialise Motorcycle details
    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType){
        this.hasSidecar = hasSidecar;
    }

	//method to display details
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: "+hasSidecar);
    }
}

class Program3{
    static void Main(string[] args){
		//creating array containing objects of 'Car', 'Truck' and 'Motorcycle' class
        Vehicle[] vehicles = new Vehicle[]{
            new Car(200, "Petrol", 5),
            new Truck(120, "Diesel", 5000),
            new Motorcycle(180, "Petrol", false)
        };
		//displaying the details
        foreach(Vehicle vehicle in vehicles){
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
