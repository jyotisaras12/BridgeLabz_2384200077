using System;
class DiscountFeesInput{
	static void Main(string[] args){
		Console.Write("Enter the fees: ");
		double fee = Convert.ToDouble(Console.ReadLine());	//taking fee as input from user
		Console.Write("Enter the discount percent: ");
		double discountPercent = Convert.ToDouble(Console.ReadLine());	//taking discountPercent as input from user
		double discountedPrice = (discountPercent/100)*fee;	//calculation of discounted amount
		double finalFees = fee - discountedPrice;	//calculation of fee after discount
		Console.WriteLine("The discount amount is INR {0} and final discounted fee is {1}",discountedPrice,finalFees);
	}
}