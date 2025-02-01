using System;
class MostFrequentCharacter{
	//method to find the most frequent character in a string
	public static char FindMostFrequentCharacter(string str){
		str = str.ToLower();	//converting string to lower case
		int[] frequency = new int[26];	//'frequency' array to store frequency of each alphabet
		//iterating through the string to check frequency of characters
		foreach(char ch in str){
			if(ch == ' ') continue;
			frequency[(int)ch - (int)'a']++;	//incrementing frequency
		}
		int maxFrequencyIndex = 0;
		char mostFrequentChar = '\0';
		//iterating through 'frequency' array to find character with maximum frequency
		for(int i = 0; i < frequency.Length; i++){
			if(frequency[i] > frequency[maxFrequencyIndex]){
				maxFrequencyIndex = i;
				mostFrequentChar = (char)((char)i+(char)'a');
			}
		}
		return mostFrequentChar;	//returning the most frequent character
	}
	
	//Main method
	static void Main(string[] args){
		//taking string as input from user
		Console.Write("Enter a string: ");
		string st = Console.ReadLine();
		
		//printing the most frequent character using 'FindMostFrequentCharacter' method
		Console.WriteLine("The most frequent character in string \"{0}\" is: {1}",st,FindMostFrequentCharacter(st));
	}
}
			