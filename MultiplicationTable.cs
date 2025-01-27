using System;
class MultiplicationTable{
	static void Main(string[] args){
		Console.WriteLine("Enter a number to print the table: ");
		//taking a number as input from user
		int num = Convert.ToInt32(Console.ReadLine());
		
		//creating table array of size 10
		int[] table = new int[10];	
		
		if(num>=6 && num<=9){	//checking the number entered is between 6 and 9
			//iterating from 0 to the largest index of array to store the multiplication result
			for(int i = 0; i < table.Length; i++){	
				table[i] = num * (i+1);	
			}
			//iterating through array to print the multiplication table
			for(int j = 0; j < table.Length; j++){	
				Console.WriteLine("{0} * {1} = {2}",num,j+1,table[j]);
			}
		}
		else Console.WriteLine("Number should be between 6 and 9 to print the table!");
	}
}