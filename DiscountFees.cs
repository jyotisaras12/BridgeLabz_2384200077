using System;
class DiscountFees{
	static void Main(string[] args){
		double fee = 125000;	//given university fee
		double discount = 10;	//given discount percent
		double discountedPrice = (discount/100)*fee;	//calculation of discounted price
		double finalFee = fee - discountedPrice;	//calculation of fee after discount
		Console.WriteLine("The discount amount is INR {0} and final discounted fee is {1}",discountedPrice,finalFee);
	}
}