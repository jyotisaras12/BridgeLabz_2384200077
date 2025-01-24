using System;
class Prime{
	static void Main(String[] args){
		Console.Write("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		bool flag=false;	//initialising boolean flag variable with false
		if(num==1) Console.WriteLine("Neither Prime nor Non-Prime");	//1 is neither prime nor non-prime
		else{	//for integers greater than 1
			for(int i=2;i<=num/2;i++){
				if(num%i==0){	//checking for factor
					flag=true;	//if factor of the number exists
					break;
				}
			}
			if(flag) Console.WriteLine("Non-Prime");	//printing the output
			else Console.WriteLine("Prime");
		}	
	}
}
