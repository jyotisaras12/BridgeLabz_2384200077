using System;
class Calendar{
	//method to get the name of the month
    static string GetMonthName(int month){
        string[] monthNames = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return monthNames[month - 1];
    }

    //method to check leap year
    static bool IsLeapYear(int year){
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    //method to get the number of days in a month
    static int GetNumberOfDays(int month, int year){
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year)) return 29;
        return daysInMonth[month - 1];
    }

    //method to calculate the first day of the month using Gregorian calendar algorithm
    static int GetFirstDayOfMonth(int month, int year){
        int y = year - (14 - month) / 12;
        int x = y + y / 4 - y / 100 + y / 400;
        int m = month + 12 * ((14 - month) / 12) - 2;
        return (1 + x + (31 * m) / 12) % 7; //returning 0 for Sunday, 1 for Monday, etc.
    }

    //method to print the calendar
    static void DisplayCalendar(int month, int year){
        string monthName = GetMonthName(month);
        int daysInMonth = GetNumberOfDays(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        Console.WriteLine("\n  " + monthName + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        //printing initial spaces for the first day
        for (int i = 0; i < firstDay; i++){
            Console.Write("    ");
        }

        //printing days of the month
        for (int day = 1; day <= daysInMonth; day++){
            Console.Write("{0,3} ", day);

            //moving to the next line after Saturday
            if ((day + firstDay) % 7 == 0) Console.WriteLine();
        }
        Console.WriteLine();
    }
	
	//Main method
    static void Main(){
		//taking month and year as input from user
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        //to get the calendar and print it
        DisplayCalendar(month, year);
    }
}
