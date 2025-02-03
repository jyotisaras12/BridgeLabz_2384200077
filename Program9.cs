using System;
class Vehicle{
    //instance variables
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }

    //class variable 
    public static double RegistrationFee { get; set; } 
	
	//static constructor to initialize the static field
    static Vehicle(){
        RegistrationFee = 150; 
    }

    // Constructor to initialize vehicle details
    public Vehicle(string ownerName, string vehicleType){
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    //method to display vehicle details
    public void DisplayVehicleDetails(){
        Console.WriteLine("Owner Name: {0}\nVehicle Type: {1}\nRegistration Fee: {2}",OwnerName, VehicleType, RegistrationFee);
        Console.WriteLine();
    }

    //method to update the registration fee for all vehicles
    public static void UpdateRegistrationFee(double newFee){
        RegistrationFee = newFee;
    }
}

class Program9{
    static void Main(string[] args){
        //creating vehicle objects
        Vehicle vehicle1 = new Vehicle("Bhaskar", "Car");
        Vehicle vehicle2 = new Vehicle("Achal", "Motorcycle");

        //displaying vehicle details 
        Console.WriteLine("Vehicle Details:");
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();

        //updating the registration fee for all vehicles
        Vehicle.UpdateRegistrationFee(250);

        //displaying vehicle details after changing registration fee
        Console.WriteLine("Vehicle Details (After updating Registration Fee):");
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
    }
}
