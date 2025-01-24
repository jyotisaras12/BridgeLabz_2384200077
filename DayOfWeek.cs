using System;
class DayOfWeek{
    static void Main(string[] args){
        if (args.Length != 3)	//ensuring only three parameters are entered by user
        {
            Console.WriteLine("Enter three arguments: Month, Day and Year");
            return;
        }
        int m = Convert.ToInt32(args[0]);	//to get month from args array
        int d = Convert.ToInt32(args[1]);	//to get day from args array
        int y = Convert.ToInt32(args[2]);	////to get year from args array
		
        int y0 = y - (14 - m) / 12;	//applying the formula to calculate the day of week
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;
		Console.WriteLine("The day of week is "+d0);	//printing the day of week
    }
}