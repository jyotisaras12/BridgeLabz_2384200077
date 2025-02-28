using System;
using System.Collections.Generic;

//creating an abstract class 'Vehicle'
abstract class Vehicle {
    protected string vehicleNumber;
    protected string type;
    protected double rentalRate;

    //constructor to initialize vehicle details
    public Vehicle(string vehicleNumber, string type, double rentalRate) {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    //abstract method to calculate rental cost
    public abstract double CalculateRentalCost(int days);

    //method to display vehicle details
    public virtual void DisplayDetails() {
        Console.WriteLine("Vehicle Details:\nVehicle Number: {0}\nType: {1}\nRental Rate: {2}", vehicleNumber, type, rentalRate);
    }
}

//creating interface for insurable vehicles
interface IInsurable {
    double CalculateInsurance();
    string GetInsuranceDetails();
}

//creating 'Car' class inheriting from Vehicle and implementing IInsurable
class Car : Vehicle, IInsurable {
    private double insuranceRate = 0.02; // 2% insurance rate
    private string insurancePolicyNumber; //{get; private set;}

    //constructor to initialize Car details
    public Car(string vehicleNumber, double rentalRate, string insurancePolicyNumber) : base(vehicleNumber, "Car", rentalRate) {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    //method to calculate rental cost for cars
    public override double CalculateRentalCost(int days) {
        return rentalRate * days;
    }

    //method to calculate insurance
    public double CalculateInsurance() {
        return rentalRate * insuranceRate;
    }

    //method to get insurance details
    public string GetInsuranceDetails() {
        return "Insurance Policy: " + insurancePolicyNumber;
    }

    //method to display vehicle details
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine(GetInsuranceDetails());
    }
}

//creating 'Bike' class inheriting from Vehicle
class Bike : Vehicle, IInsurable {
	private string insurancePolicyNumber;
    private double insuranceRate = 0.02; // 2% of rental rate
	
    //constructor to initialize Bike details
    public Bike(string vehicleNumber, double rentalRate, string insurancePolicyNumber) : base(vehicleNumber, "Bike", rentalRate) {
		this.insurancePolicyNumber = insurancePolicyNumber;
	}

    //method to calculate rental cost for bikes
    public override double CalculateRentalCost(int days) {
        return rentalRate * days * 0.9; // 10% discount for bikes
    }
	
	//method to calculate insurance
    public double CalculateInsurance() {
        return rentalRate * insuranceRate;
    }

    //method to get insurance details
    public string GetInsuranceDetails() {
        return "Insurance Policy: " + insurancePolicyNumber;
    }

    //method to display vehicle details
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine(GetInsuranceDetails());
    }
}

//creating 'Truck' class inheriting from Vehicle and implementing IInsurable
class Truck : Vehicle, IInsurable {
    private double insuranceRate = 0.05; // 5% insurance rate
    private string insurancePolicyNumber;

    //constructor to initialize Truck details
    public Truck(string vehicleNumber, double rentalRate, string insurancePolicyNumber) : base(vehicleNumber, "Truck", rentalRate) {
        this.insurancePolicyNumber = insurancePolicyNumber;
    }

    //method to calculate rental cost for trucks
    public override double CalculateRentalCost(int days) {
        return rentalRate * days * 1.2; // 20% extra charge for trucks
    }

    //method to calculate insurance
    public double CalculateInsurance() {
        return rentalRate * insuranceRate;
    }

    //method to get insurance details
    public string GetInsuranceDetails() {
        return "Insurance Policy: " + insurancePolicyNumber;
    }

    //method to display vehicle details
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine(GetInsuranceDetails());
    }
}

class Program3 {
    public static void Main(string[] args) {
        //creating a list of vehicles
        List<Vehicle> vehicles = new List<Vehicle>();

        //adding a car
        Car car = new Car("C123", 1500, "CINS1234");
        vehicles.Add(car);

        //adding a bike
        Bike bike = new Bike("B456", 500, "BINS4567");
        vehicles.Add(bike);

        //adding a truck
        Truck truck = new Truck("T789", 3000, "TINS7890");
        vehicles.Add(truck);

        //iterating through the list to display vehicle details, rental cost, and insurance details
        int rentalDays = 5;
        foreach(Vehicle vehicle in vehicles) {
            vehicle.DisplayDetails();
            double rentalCost = vehicle.CalculateRentalCost(rentalDays);
            double insuranceCost = (vehicle is IInsurable) ? ((IInsurable)vehicle).CalculateInsurance() : 0;
            Console.WriteLine("Rental Cost for {0} days: {1}", rentalDays, rentalCost);
            Console.WriteLine("Insurance Cost: {0}", insuranceCost);
            Console.WriteLine(new string('-', 40));
        }
    }
}