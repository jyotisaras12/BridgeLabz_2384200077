using System;
using System.Collections.Generic;

//creating an abstract class 'Vehicle'
abstract class Vehicle {
    protected string vehicleId;
    protected string driverName;
    protected double ratePerKm;

    //constructor to initialize vehicle details
    public Vehicle(string vehicleId, string driverName, double ratePerKm) {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    //abstract method to calculate fare
    public abstract double CalculateFare(double distance);

    //method to display vehicle details
    public virtual void GetVehicleDetails() {
        Console.WriteLine("Vehicle Details:\nID: {0}\nDriver: {1}\nRate per Km: {2}", vehicleId, driverName, ratePerKm);
    }
}

//creating an interface for GPS tracking
interface IGPS {
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

//creating 'Car' class inheriting from Vehicle and implementing IGPS
class Car : Vehicle, IGPS {
    private string currentLocation;

    //constructor to initialize Car details
    public Car(string vehicleId, string driverName, double ratePerKm, string startLocation): base(vehicleId, driverName, ratePerKm) {
        this.currentLocation = startLocation;
    }

    //method to calculate fare for cars
    public override double CalculateFare(double distance) {
        return distance * ratePerKm;
    }

    //method to get current location
    public string GetCurrentLocation() {
        return currentLocation;
    }

    //method to update location
    public void UpdateLocation(string newLocation) {
        currentLocation = newLocation;
    }

    //method to display vehicle details
    public override void GetVehicleDetails() {
        base.GetVehicleDetails();
        Console.WriteLine("Current Location: {0}", GetCurrentLocation());
    }
}

//creating 'Bike' class inheriting from Vehicle and implementing IGPS
class Bike : Vehicle, IGPS {
    private string currentLocation;

    //constructor to initialize Bike details
    public Bike(string vehicleId, string driverName, double ratePerKm, string startLocation): base(vehicleId, driverName, ratePerKm) {
        this.currentLocation = startLocation;
    }

    //method to calculate fare for bikes
    public override double CalculateFare(double distance) {
        return distance * ratePerKm;
    }

    //method to get current location
    public string GetCurrentLocation() {
        return currentLocation;
    }

    //method to update location
    public void UpdateLocation(string newLocation) {
        currentLocation = newLocation;
    }

    //method to display vehicle details
    public override void GetVehicleDetails() {
        base.GetVehicleDetails();
        Console.WriteLine("Current Location: {0}", GetCurrentLocation());
    }
}

//creating 'Auto' class inheriting from Vehicle and implementing IGPS
class Auto : Vehicle, IGPS {
    private string currentLocation;

    //constructor to initialize Auto details
    public Auto(string vehicleId, string driverName, double ratePerKm, string startLocation): base(vehicleId, driverName, ratePerKm) {
        this.currentLocation = startLocation;
    }

    //method to calculate fare for autos
    public override double CalculateFare(double distance) {
        return distance * ratePerKm;
    }

    //method to get current location
    public string GetCurrentLocation() {
        return currentLocation;
    }

    //method to update location
    public void UpdateLocation(string newLocation) {
        currentLocation = newLocation;
    }

    //method to display vehicle details
    public override void GetVehicleDetails() {
        base.GetVehicleDetails();
        Console.WriteLine("Current Location: {0}", GetCurrentLocation());
    }
}

class Program8 {
    public static void Main(string[] args) {
        //creating a list of vehicles
        List<Vehicle> vehicles = new List<Vehicle>();

        //adding a car
        Car car = new Car("C123", "Avishi", 20, "Agra");
        vehicles.Add(car);

        //adding a bike
        Bike bike = new Bike("B456", "Akanksha", 15, "Mathura");
        vehicles.Add(bike);

        //adding an auto
        Auto auto = new Auto("A789", "Aryan", 10, "Aligarh");
        vehicles.Add(auto);

        //iterating through the list to display vehicle details and calculate fares
        double rideDistance = 10; //distance in km
        foreach(Vehicle vehicle in vehicles) {
            vehicle.GetVehicleDetails();
            double fareAmount = vehicle.CalculateFare(rideDistance);
            Console.WriteLine("Ride Fare for {0} km: {1}", rideDistance, fareAmount);
            Console.WriteLine(new string('-', 40));
        }
    }
}
