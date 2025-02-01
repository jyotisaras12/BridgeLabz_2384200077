using System;
class PalindromeCheck{
	//method to check if a string is pallindrome string
	public static bool IsPalindrome(string str){
		string reverseString = "";	//variable to store reverse of string
		//iterating through the string 'str' to reverse it
		for(int i = str.Length-1; i >= 0; i--){
			reverseString += str[i];
		}
		return (str == reverseString);	//returning true if palindrome
	}
	
	//Main method
	static void Main(string[] args){
		//taking string as input from user
		Console.Write("Enter a string: ");
		string st = Console.ReadLine();
	
		//printing whether the string is palindrome or not using 'IsPalindrome' method
		Console.WriteLine("The string \"{0}\" is palindrome? {1}",st,IsPalindrome(st));
	}
}