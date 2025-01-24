using System;
class VotingEligibility{
	static void Main(string[] args){
		Console.Write("Enter age of a person: ");	
		double age = Convert.ToDouble(Console.ReadLine());	//taking age of a person as input from user
		if (age >= 18){	//checking if the person is eligible to vote
			Console.WriteLine("The person's age is {0} and can vote.",age);	
		}
		else{	//not eligible to vote
			Console.WriteLine("The person's age is {0} and cannot vote.",age);	
		}
	}
}
			