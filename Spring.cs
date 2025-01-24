using System;
class Spring{
	static void Main(string[] args){
		if (args.Length != 2)	//ensuring only 2 arguments for month and day are passed by user
        {
            Console.WriteLine("Please provide arguments for month and day");
            return;
        }
		int month = Convert.ToInt32(args[0]);	//to take month from args array
        int day = Convert.ToInt32(args[1]);	//to take day from args array
		DateTime inputDate = new DateTime(DateTime.Now.Year, month, day);	//creating a DateTime object for month and day entered by user
		DateTime springStart = new DateTime(DateTime.Now.Year, 3, 20); // March 20: start of the spring
        DateTime springEnd = new DateTime(DateTime.Now.Year, 6, 20);   // June 20: end of the spring
		if (inputDate >= springStart && inputDate <= springEnd)	//checking if the date entered by user falls in spring
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
		
	}
}