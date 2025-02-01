using System;
class ReverseString{
	//method to reverse a string
	public static string FindStringReverse(string str){
		string reverseString = "";	//variable to store reverse of string
		//iterating through the string 'str' to reverse it
		for(int i = str.Length-1; i >= 0; i--){
			reverseString += str[i];
		}
		return reverseString;	//returning the reverse string
	}
	
	//Main method
	static void Main(string[] args){
		//taking string as input from user
		Console.Write("Enter a string: ");
		string st = Console.ReadLine();
	
		//printing the reverse of given string using 'FindStringReverse' method
		Console.WriteLine("The reverse of \"{0}\" is: \"{1}\"",st,FindStringReverse(st));
	}
}