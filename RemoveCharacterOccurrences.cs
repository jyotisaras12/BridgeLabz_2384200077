using System;
class RemoveCharacterOccurrences{
	//method to remove occurrences of a specified character from a string
	public static string RemoveOccurrencesOfCharacter(string str, char ch){
		string newString = "";	//variable to store string without specified character
		//iterating through the string 'str' to remove character
		foreach(char character in str){
			if(character == ch) continue;
			newString += character;
		}
		return newString;	//returning the string after removing the character
	}
	
	//Main method
	static void Main(string[] args){
		//taking string and character to be removed as input from user
		Console.Write("Enter a string: ");
		string st = Console.ReadLine();
		
		Console.Write("Enter character to remove: ");
		char c = (char)Console.Read();
	
		//printing the modified string after removing the specified character using 'RemoveOccurrencesOfCharacter' method
		string modifiedString = RemoveOccurrencesOfCharacter(st,c);
		
		Console.WriteLine("The original string is: {0} \nThe modified string is: {1}",st,modifiedString);
	}
}