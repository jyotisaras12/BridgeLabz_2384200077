using System;
class RemoveDuplicates{
	//method to remove duplicates from a string
	public static string RemoveDuplicatesFromString(string str){
		string newString = "";	//variable to store string without duplicates
		//iterating through the string 'str' to remove duplicates
		for(int i = 0; i < str.Length; i++){
			bool isDuplicate = false;
			foreach(char c in newString){
				if(str[i] == c){
					isDuplicate = true;
					break;
				}
			}
			if(!isDuplicate) newString += str[i];
		}
		return newString;	//returning the string without duplicates
	}
	
	//Main method
	static void Main(string[] args){
		//taking string as input from user
		Console.Write("Enter a string: ");
		string st = Console.ReadLine();
	
		//printing the modified string after removing the duplicates using 'RemoveDuplicatesFromString' method
		string modifiedString = RemoveDuplicatesFromString(st);
		
		Console.WriteLine("The original string is: {0} \nThe modified string is: {1}",st,modifiedString);
	}
}