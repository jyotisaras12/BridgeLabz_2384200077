using System;

//creating base class: Device
class Device{
    private string deviceId { get; set; }
    private string status { get; set; }

	//constructor to initialise Device details
    public Device(string deviceId, string status){
        this.deviceId = deviceId;
        this.status = status;
    }
	
	//method to display status
    public virtual void DisplayStatus(){
        Console.WriteLine("Device ID: {0}\nStatus: {1}", deviceId, status);
    }
}

//creating subclass: Thermostat
class Thermostat : Device{
    private double tempSetting { get; set; }

	//constructor to initialise Thermostat details
    public Thermostat(string deviceId, string status, double tempSetting) : base(deviceId, status){
        this.tempSetting = tempSetting;
    }

	//method to display status
    public override void DisplayStatus(){
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: {0} C", tempSetting);
    }
}

class Program5{
    static void Main(string[] args){
		//creating Thermostat object
        Thermostat thermostat = new Thermostat("TH123", "Online", 24.5);
		//displaying status
        thermostat.DisplayStatus();
    }
}
