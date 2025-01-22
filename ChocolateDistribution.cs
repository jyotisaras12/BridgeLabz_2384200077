using System;
class ChocolateDistribution{
	static void Main(string[] args){
		Console.Write("Enter no. of chocolates: ");
		int noOfChocolates = Convert.ToInt32(Console.ReadLine());	//taking no. of chocolates as input from user
		Console.Write("Enter no. of children: ");
		int noOfChildren = Convert.ToInt32(Console.ReadLine());	//taking no. of children as input from user
		int chocolatesPerChild = noOfChocolates/noOfChildren;	//calculation of no. of chocolates per child
		int chocolatesRemaining = noOfChocolates % noOfChildren;	//calculation of remaining chocolates
		Console.WriteLine("The number of chocolates each child gets is {0} and the number of remaining chocolates is {1}",chocolatesPerChild,chocolatesRemaining);
	}
}