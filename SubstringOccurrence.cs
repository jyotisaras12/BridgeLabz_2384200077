using System;
class SubstringOccurrence{
	//method to find number of times a substring occurs in a string
	public static int FindSubstringOccurrenceCount(string str, string substr){
		int count = 0;	//counter for substring frequency
		int index = 0;
		while((index = str.IndexOf(substr,index)) != -1){
			count++;	//incrementing frequency of substring
            index += substr.Length;	//to continue searching after incrementing the index
		}
		return count;
	}
	
	//Main method
	static void Main(string[] args){
		//taking string and substring as input from user
		Console.Write("Enter a string: ");
		string st = Console.ReadLine();
		
		Console.Write("Enter the substring: ");
		string subst = Console.ReadLine();
	
		//printing the occurrence of substring in string using 'FindSubstringOccurrenceCount' method
		Console.WriteLine("The subtring \"{0}\" appears {1} times in string \"{2}\"",subst,FindSubstringOccurrenceCount(st,subst),st);
	}
}