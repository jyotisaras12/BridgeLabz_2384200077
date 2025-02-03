using System;
class CarRental{
    //declaring fields
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }

    //default constructor
    public CarRental(){
        CustomerName = "Bhaskar";
        CarModel = "Standard";
        RentalDays = 2;
    }

    //parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays){
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
    }

    //method to calculate total cost 
    public double CalculateTotalCost(){
        double pricePerDay;

        switch(CarModel){
            case "Economy":
                pricePerDay = 30; 
                break;
            case "Standard":
                pricePerDay = 60; 
                break;
            case "Luxury":
                pricePerDay = 120; 
                break;
            case "SUV":
                pricePerDay = 100; 
                break;
            default:
                pricePerDay = 40; //default price
                break;
        }

        //calculate the total cost
        return pricePerDay * RentalDays;
    }

    // Method to display rental details
    public void DisplayRentalInfo(){
        Console.WriteLine("Customer Name: {0}\nCar Model: {1}\nRental Days: {2}\nTotal Cost: {3}",CustomerName, CarModel, RentalDays, CalculateTotalCost());
    }
}

class Program6{
    static void Main(string[] args){
        //creating car rental objects
        CarRental rental1 = new CarRental("Akash", "Economy", 6);
        CarRental rental2 = new CarRental("Ashima", "Luxury", 2);

        //displaying rental details
        Console.WriteLine("Rental 1 Details:");
        rental1.DisplayRentalInfo();

        Console.WriteLine("Rental 2 Details:");
        rental2.DisplayRentalInfo();
    }
}
