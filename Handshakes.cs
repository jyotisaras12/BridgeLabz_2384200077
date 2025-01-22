using System;
class Handshakes{
	static void Main(String[] args){
		Console.Write("Enter no. of students: ");	
		int noOfStudents = Convert.ToInt32(Console.ReadLine()); //taking no. of students as input from user
		int handshakes = (noOfStudents * (noOfStudents-1))/2;	//calculation of maximum no. of handshakes possible
		Console.WriteLine("The maximum number of possible handshakes is {0}",handshakes);
	}
}