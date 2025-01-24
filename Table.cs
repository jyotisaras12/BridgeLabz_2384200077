using System;
class Table{
	static void Main(string[] args){
		Console.Write("Enter a number: ");	
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		if(num >= 6 && num <= 9){	//checking the number is between 6 and 9
			for(int i = 1; i <= 10; i++){	//iterating from 1 to 10 for table
			Console.WriteLine("{0} * {1} = {2}",num,i,num*i);	//printing the multiplication table
			}
		}
		else{	//for numbers not between 6 and 9
			Console.WriteLine("Number should be between 6 to 9 to print multiplication table");
		}
	}
}