using System;

//creating interface: Refuelable
interface Refuelable{
    void Refuel();
}

//creating base class: Vehicle
class Vehicle{
    public int maxSpeed { get; set; }
    public string model { get; set; }

	//constructor
    public Vehicle(int maxSpeed, string model){
        this.maxSpeed = maxSpeed;
        this.model = model;
    }

	//method to display information
    public virtual void DisplayInfo(){
        Console.WriteLine("Vehicle Model: {0}\nMax Speed: {1} km/h", model, maxSpeed);
    }
}

//creating subclass: ElectricVehicle
class ElectricVehicle : Vehicle{
    private int batteryCapacity { get; set; }

	//constructor
    public ElectricVehicle(int maxSpeed, string model, int batteryCapacity)
        : base(maxSpeed, model){
        this.batteryCapacity = batteryCapacity;
    }

	//method to display information
    public override void DisplayInfo(){
        Console.WriteLine("Electric Vehicle Model: {0}\nMax Speed: {1} km/h\nBattery Capacity: {2} kWh", model, maxSpeed, batteryCapacity);
    }

	//method 'Charge()'
    public void Charge(){
        Console.WriteLine("Charging the electric vehicle!");
    }
}

//creating subclass: PetrolVehicle implementing Refuelable
class PetrolVehicle : Vehicle, Refuelable{
    private int fuelTankCapacity { get; set; }

    public PetrolVehicle(int maxSpeed, string model, int fuelTankCapacity)
        : base(maxSpeed, model){
        this.fuelTankCapacity = fuelTankCapacity;
    }

	//method to display information
    public override void DisplayInfo(){
        Console.WriteLine("Petrol Vehicle Model: {0}\nMax Speed: {1} km/h\nFuel Tank Capacity: {2} liters", model, maxSpeed, fuelTankCapacity);
    }

	//method 'Refuel()'
    public void Refuel(){
        Console.WriteLine("Refueling the petrol vehicle!");
    }
}

class Program11{
    static void Main(string[] args){
		//creating objects for 'ElectricVehicle' and 'PetrolVehicle' classes
        ElectricVehicle ev = new ElectricVehicle(140, "Tata Tiago", 100);
        PetrolVehicle pv = new PetrolVehicle(200, "Maruti Suzuki Swift", 70);

		//displaying information
        ev.DisplayInfo();
        ev.Charge();
        Console.WriteLine();
        
        pv.DisplayInfo();
        pv.Refuel();
    }
}
