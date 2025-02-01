using System;
using System.Globalization;
class DateComparison{
    static void Main(string[] args){
        try{
            //taking date input from the user
            Console.Write("Enter date (yyyy-MM-dd) 1: ");
            string d1 = Console.ReadLine();

            Console.Write("Enter date (yyyy-MM-dd) 1: ");
            string d2 = Console.ReadLine();

            //ensuring the input is in the correct format
            DateTime id1, id2;
            bool isValidDate1 = DateTime.TryParseExact(d1, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out id1);
            bool isValidDate2 = DateTime.TryParseExact(d2, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out id2);
            if (!isValidDate1 || !isValidDate2)
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");
                return;
            }
			//using 'DateTime.Compare()' method
            int comparison = DateTime.Compare(id1, id2);
            if (comparison < 0)
                Console.WriteLine("First date is before the second date.");
            else if (comparison > 0)
                Console.WriteLine("First date is after the second date.");
            else
                Console.WriteLine("Both dates are the same.");

            //using 'CompareTo()' method
            int compareToResult = id1.CompareTo(id2);
            Console.WriteLine("CompareTo() result: " + compareToResult);

            //using direct comparison
            if (id1 < id2)
                Console.WriteLine("Using <: First date is before the second date.");
            else if (id1 > id2)
                Console.WriteLine("Using >: First date is after the second date.");
            else
                Console.WriteLine("Using ==: Both dates are the same.");
        }
        catch (Exception ex){
            Console.WriteLine("An error occurred: {0}", ex.Message);
        }
    }
}
