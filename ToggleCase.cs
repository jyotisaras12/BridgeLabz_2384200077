using System;
class ToggleCase{
	//method to convert upper case to lower case and vice-versa
	public static string ToggleCharacterCase(string str){
		string toggleString = "";
		//iterating through the string 'str' to change the case
		for(int i = 0; i < str.Length; i++){
			if((int)str[i] >= 65 && (int)str[i] <= 90){	//checking if character is upper case
				toggleString += (char)((int)str[i] - (int)'A' + (int)'a');
			}
			else if((int)str[i] >= 97 && (int)str[i] <= 122){	//checking if character is lower case
				toggleString += (char)((int)str[i] - (int)'a' + (int)'A');
			}
			else toggleString += str[i];
		}
		return toggleString;	//returning the toggle case string
	}
	
	//Main method
	static void Main(string[] args){
		//taking string as input from user
		Console.Write("Enter a string: ");
		string st = Console.ReadLine();
	
		//printing the string with toggled case using 'ToggleCharacterCase' method
		Console.WriteLine("The toggle case of string \"{0}\" is: {1}",st, ToggleCharacterCase(st));
	}
}