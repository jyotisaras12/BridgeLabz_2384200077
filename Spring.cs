using System;
class Spring{
	//method to check for Spring season
	public bool SpringCheck(int month, int day){
		//creating a DateTime object for month and day passed as parameters
		DateTime inputDate = new DateTime(DateTime.Now.Year, month, day);	
		DateTime springStart = new DateTime(DateTime.Now.Year, 3, 20); // March 20: start of the spring
        DateTime springEnd = new DateTime(DateTime.Now.Year, 6, 20);	// June 20: end of the spring
		
		//checking if the date entered by user falls in spring
		if (inputDate >= springStart && inputDate <= springEnd)	return true;
        else return false;
	}
	
	//Main method
	static void Main(string[] args){
		if (args.Length != 2)	//ensuring only 2 arguments for month and day are passed by user
        {
            Console.WriteLine("Please provide arguments for month and day");
            return;
        }
		int m = Convert.ToInt32(args[0]);	//to take month from args array
        int d = Convert.ToInt32(args[1]);	//to take day from args array
		
		//instantiating the 'Spring' class
		Spring spring = new Spring();
		
		//printing true for spring and false for not spring using 'SpringCheck' method
		Console.WriteLine(spring.SpringCheck(m,d));
	}
}