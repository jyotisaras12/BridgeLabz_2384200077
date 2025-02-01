using System;
class AnagramCheck{
	//method to check if two strings are anagram of each other
	public static bool IsAnagram(string str1, string str2){
		str1 = str1.ToLower();
		str2 = str2.ToLower();
		int[] frequency = new int[26];	//array to store frequency of each character
		//iterating through string 1 to increment the frequency of characters
		foreach(char ch in str1){
			if(ch == ' ') continue;
			frequency[(int)ch - (int)'a']++;
		}
		
		//iterating through string 2 to decrement the frequency of characters
		foreach(char ch in str2){
			if(ch == ' ') continue;
			frequency[(int)ch - (int)'a']--;
		}
		
		//iterating through 'frequency' array to check the frequency of each character
		foreach(int count in frequency){
			if(count != 0) return false;	//if frequency of all characters is not 0, then strings are not anagrams
		}
		return true;
	}
	
	//Main method
	static void Main(string[] args){
		//taking two strings as input from user
		Console.Write("Enter first string: ");
		string st1 = Console.ReadLine();
		
		Console.Write("Enter second string: ");
		string st2 = Console.ReadLine();
		
		//printing whether both the strings are anagram or not using 'IsAnagram' method
		Console.WriteLine("Strings \"{0}\" and \"{1}\" are anagrams of each other? {2}",st1,st2,IsAnagram(st1,st2));
	}
}
			