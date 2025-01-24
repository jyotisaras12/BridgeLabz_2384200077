using System;
class LeapYear{
	static void Main(string[] args){
		Console.Write("Enter the year: ");	
		int year = Convert.ToInt32(Console.ReadLine());	//taking number as input from user
		if(year >= 1582){	//ensuring year >= 1582 for checking leap or non-leap year
			if(year % 400 == 0){	//an year divisible by 400 is a leap year
			Console.WriteLine("{0} is a leap year",year);
			}
			else if(year % 4 == 0 && year % 100 != 0){	//an year divisible by 4 but not by 100 is a leap year
				Console.WriteLine("{0} is a leap year",year);
			}
			else{	//all other years are non-leap years
				Console.WriteLine("{0} is not a leap year",year);
			}
		}
		else{	//year < 1582 is  not valid to check leap and non-leap
			Console.WriteLine("Not a valid year to check for leap year");
		}
	}
}
			