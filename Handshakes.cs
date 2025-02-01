using System;
class Handshakes{
	//method for calculation of the maximum number of possible handshakes
	public int NoOfHandshakes(int noOfStudents){	
		int handshakes = (noOfStudents * (noOfStudents-1))/2;	//calculation of maximum no. of handshakes possible
		return handshakes;	//returning the value of handshakes
	}
	//Main method
	static void Main(String[] args){
		//taking no. of students as input from user
		Console.Write("Enter no. of students: ");	
		int n = Convert.ToInt32(Console.ReadLine()); 
		
		//instantiating the 'Handshakes' class
		Handshakes maxHandshakes = new Handshakes();	
		
		//printing the maximum no. of handshakes possible using 'NoOfHandshakes' method
		Console.WriteLine("The maximum number of possible handshakes is: {0}",maxHandshakes.NoOfHandshakes(n));
	}
}