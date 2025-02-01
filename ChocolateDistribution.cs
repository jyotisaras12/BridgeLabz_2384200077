using System;
class ChocolateDistribution{
	//method to divide N number of chocolates among M children
	public static int[] FindChocolateDistribution(int noOfChocolates, int noOfChildren) {
		int chocolatesPerChild = noOfChocolates / noOfChildren;	//number of chocolates each child gets
		int remainingChocolates = noOfChocolates % noOfChildren;	//remaining undistributed chocolates
		return new int[]{chocolatesPerChild, remainingChocolates};
	}
	
	//Main method
	static void Main(string[] args){
		//taking no. of chocolates as input from user
		Console.Write("Enter no. of chocolates: ");
		int chocolates = Convert.ToInt32(Console.ReadLine());	
		//taking no. of children as input from user
		Console.Write("Enter no. of children: ");
		int children = Convert.ToInt32(Console.ReadLine());	
		
		//calling the 'FindChocolateDistribution' method to calculate chocolate per child and remaining chocolates
        int[] distribution = FindChocolateDistribution(chocolates,children);
		
		//printing the no. of chocolates each child will get and remaining undistributed chocolates
		Console.WriteLine("Chocolates per child is: "+distribution[0]);
		Console.WriteLine("Remaining undistributed chocolates is: "+distribution[1]);
	}
}