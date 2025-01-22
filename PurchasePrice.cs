using System;
class PurchasePrice{
	static void Main(String[] args){
		Console.Write("Enter unit price of an item: ");
		double unitPrice = Convert.ToDouble(Console.ReadLine()); //taking unit price of item as input from user
		Console.Write("Enter quantity to be bought: ");
		double quantity = Convert.ToDouble(Console.ReadLine());	//taking quantity as input from user
		double totalPrice = quantity * unitPrice;	//calculation of total price
		Console.WriteLine("The total purchase price is INR {0} if the quantity {1} and unit price is INR {2}",totalPrice,quantity,unitPrice);
	}
}