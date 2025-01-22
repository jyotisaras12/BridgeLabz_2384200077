using System;
class Profit{
	static void Main(String[] args){
		double cp = 129;	//given cost price
		double sp = 191;	//given selling price
		double profit = sp - cp;	//profit calculation
		double profitPer = (profit / cp) * 100;	//profit percentage calculation
		Console.WriteLine("The Cost Price is INR {0} and Selling Price is INR {1}",cp,sp);
		Console.WriteLine("The Profit is INR {0} and the Profit Percentage is {1}",profit,profitPer);
	}
}