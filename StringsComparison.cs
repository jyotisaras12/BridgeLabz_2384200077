using System;
class StringsComparison{ 
	//method to compare two strings
	public static int ComparisonOfStrings(string str1, string str2){
		int i = 0;
		while(i < str1.Length && i < str2.Length){
			if(str1[i] < str2[i]) return 1;	//string 1 appears before string 2
			else if (str2[i] < str1[i]) return 2;	//string 2 appears before string 1
			i++;
		}
		if(i < str1.Length) return 2;	//if length of string 2 is greater than that of string 1
		if(i < str2.Length) return 1;	//if length of string 2 is greater than that of string 1
		return 0;	//if both the strings are same
	}
	
	//Main method
	static void Main(string[] args){
		//taking strings as input from user
		Console.Write("Enter string 1: ");
		string str1 = Console.ReadLine();
		
		Console.Write("Enter string 2: ");
		string str2 = Console.ReadLine();
		
		//printing the output using 'ComparisonOfStrings' method
		int smallerOrder = ComparisonOfStrings(str1,str2);
		
		if(smallerOrder == 1) Console.WriteLine("\"{0}\" occurs before \"{1}\" in lexicographical order.",str1,str2);
		if(smallerOrder == 2) Console.WriteLine("\"{0}\" occurs before \"{1}\" in lexicographical order.",str2,str1);
		if(smallerOrder == 0) Console.WriteLine("\"{0}\" and \"{1}\" occurs at same place in lexicographical order.",str1,str2);		
	}
}
		