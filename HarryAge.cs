using System;
class HarryAge{
	static void Main(string[] args){
		string name = "Harry";   
		int bdayYear = 2000;	//year of birth
		int presentYear = 2024;	//current year
		int age = presentYear - bdayYear;	//age calculation
		Console.WriteLine("{0}'s age in {1} is {2}",name,presentYear,age);	//printing output
	}
}