using System;
class Palindrome{
	//method to check if a string is pallindrome string
	public static bool IsPalindrome(string str){
		string reverseString = "";	//variable to store reverse of string
		//iterating through the string 'str' to reverse it
		for(int i = str.Length-1; i >= 0; i--){
			reverseString += str[i];
		}
		return (str == reverseString);	//returning true if palindrome
	}
	
	//method to take input from user
	public static string UserInput(){
		Console.Write("Enter a string: ");
		string str = Console.ReadLine();
		return str;
	}
	
	//method to print whether the string is palindrome or not
	public static void DisplayPalindromeCheck(bool result){
		if(result) Console.WriteLine("Palindrome string!");
		else Console.WriteLine("Non-Palindrome string!");
	}
			
	//Main method
	static void Main(String[] args){
		//calling 'UserInput' method to take input from the user
		string text = UserInput();
		
		//printing the result using 'IsPalindrome()' and 'DisplayPalindromeCheck()' method
		bool isPalindrome = IsPalindrome(text);
		DisplayPalindromeCheck(isPalindrome);
	}
}
