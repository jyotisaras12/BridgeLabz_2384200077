using System;
class TravelComputation {
	static void Main(string[] args) {
	Console.Write("Enter the name of person: ");	
    string name = Console.ReadLine();	//taking name of person travelling as input from user
      
	Console.Write("Enter the city from which {0} starts travelling: ",name); 
    string fromCity = Console.ReadLine();	//taking starting city as input from user
	  
	Console.Write("Enter the city via which {0} travels: ",name);
	string viaCity = Console.ReadLine();	//taking city via which the person travels as input from user
	
	Console.Write("Enter the final city: ");
	string toCity = Console.ReadLine();	//taking destination city as input from user

	Console.Write("Enter distance from {0} to {1} in miles: ",fromCity,viaCity);
    double distanceFromToVia = Convert.ToDouble(Console.ReadLine());	//taking distance between fromCity and viaCity as input from user
	  
	Console.Write("Enter time taken from {0} to {1} in minutes: ",fromCity,viaCity);
    int timeFromToVia = Convert.ToInt32(Console.ReadLine()); ////taking time taken from fromCity to viaCity as input from user
	  
	Console.Write("Enter distance from {0} to {1} in miles: ",viaCity,toCity);
    double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());	//taking distance between viaCity and toCity as input from user
	  
	Console.Write("Enter time taken from {0} to {1} in minutes: ",viaCity,toCity);
    int timeViaToFinalCity = Convert.ToInt32(Console.ReadLine()); //taking time taken from viaCity to toCity as input from user

    double totalDistance = distanceFromToVia + distanceViaToFinalCity;	//calculation of total distance 
    int totalTime = timeFromToVia + timeViaToFinalCity;	//calculation of total time taken

    Console.WriteLine("The Total Distance travelled by {0} from {1} to {2} via {3} is {4} km and the Total Time taken is {5} minutes",name,fromCity,toCity,viaCity,totalDistance,totalTime);
   }
}
