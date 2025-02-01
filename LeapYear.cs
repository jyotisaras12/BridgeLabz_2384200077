using System;
class LeapYear{
    //method to check if a year is leap year or not
    public static bool IsLeapYear(int year){
        //checking if year is greater than or equal to 1582
        if (year < 1582){
            Console.WriteLine("Year must be greater than or equal to 1582.");
            return false;
        }
        //checking leap year: divisible by 4, not divisible by 100 unless divisible by 400
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) return true; 
        else return false;
    }

	//Main method
    static void Main(){
        //taking year as input from user
        Console.Write("Enter a year: ");
        int yr = Convert.ToInt32(Console.ReadLine());

        //checking if the year is leap year or not
        if(IsLeapYear(yr)) Console.WriteLine("{0} is a Leap Year.",yr);
        else Console.WriteLine("{0} is not a Leap Year.",yr);
    }
}
