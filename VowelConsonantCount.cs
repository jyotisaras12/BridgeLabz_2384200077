using System;
class VowelConsonantCount{
	//method to count the number of vowels and consonants in a string
	public static int[] CountVowelsAndConsonants(string str){
		str = str.ToLower();	//converting string to lower case
		int vowelCount = 0;	//counter for vowels
		int consonantCount = 0;	//counter for consonants
		//iterating through the string 'str' to count vowels and consonants
		for(int i = 0; i < str.Length; i++){
			char ch = str[i];	//taking a character from the string
			//condition for vowel
			if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')	
				vowelCount++;	//incrementing vowel counter
			else consonantCount++;	//incrementing consonants counter
		}
		return new int[]{vowelCount,consonantCount};	//returning array that contains vowels count and consonants count
	}
	
	//Main method
	static void Main(string[] args){
		//taking string as input from user
		Console.Write("Enter a string: ");
		string st = Console.ReadLine();
		
		//using 'CountVowelsAndConsonants' method to store output in 'count' array
		int[] count = CountVowelsAndConsonants(st);
		
		//printing the number of vowels and consonants
		Console.WriteLine("The number of vowels in \"{0}\" is: {1}\nThe number of consonants in \"{0}\" is: {2}",st,count[0],count[1]);
	}
}