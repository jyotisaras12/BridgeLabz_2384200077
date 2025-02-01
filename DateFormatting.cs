using System;
using System.Globalization;
class DateFormatting{
    static void Main(string[] args){
        //get the current UTC time
        DateTimeOffset date = DateTimeOffset.UtcNow;
		//dd/MM/yyyy format
        Console.WriteLine("Date in \"dd/MM/yyyy \" format: "+date.ToString("dd/MM/yyyy"));
		//yyyy-MM-dd format
        Console.WriteLine("Date in \"yyyy-MM-dd\" format: "+date.ToString("yyyy-MM-dd"));
		//MMM dd, yyyy format
        string formattedDate = date.ToString("ddd,") + date.ToString("MMM dd, yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Date in \"MMM dd, yyyy\" format: " + formattedDate);
    }
}


