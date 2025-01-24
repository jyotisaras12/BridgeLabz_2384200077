using System;
class YoungestAndTallest{
	static void Main(string[] args){
		Console.Write("Enter age of Amar: ");	
		double amarAge = Convert.ToDouble(Console.ReadLine());	//taking age of Amar as input from user
		Console.Write("Enter height in cm: ");	
		double amarHeight = Convert.ToDouble(Console.ReadLine());	//taking height of Amar in cm as input from user
		Console.Write("Enter age of Akbar: ");	
		double akbarAge = Convert.ToDouble(Console.ReadLine());	//taking age of Akbar as input from user
		Console.Write("Enter height in cm: ");	
		double akbarHeight = Convert.ToDouble(Console.ReadLine());	//taking height of Akbar in cm as input from user
		Console.Write("Enter age of Anthony: ");	
		double anthonyAge = Convert.ToDouble(Console.ReadLine());	//taking age of Anthony as input from user
		Console.Write("Enter height in cm: ");	
		double anthonyHeight = Convert.ToDouble(Console.ReadLine());	//taking height of Anthony in cm as input from user
		if(amarAge<akbarAge && amarAge<anthonyAge)	//checking if Amar is the youngest
			Console.WriteLine("The youngest among the three is Amar with age {0} years",amarAge);
		else if(akbarAge<amarAge && akbarAge<anthonyAge)	//checking if Akbar is the youngest 
			Console.WriteLine("The youngest among the three is Akbar with age {0} years",akbarAge);
		else	//Anthony is the youngest
			Console.WriteLine("The youngest among the three is Anthony with age {0} years",anthonyAge);
			
		if(amarHeight>akbarHeight && amarHeight>anthonyHeight)	//checking if Amar is the tallest
			Console.WriteLine("The tallest among the three is Amar with height {0} cm",amarHeight);
		else if(akbarHeight>amarHeight && akbarHeight<anthonyHeight)	//checking if Akbar is the tallest 
			Console.WriteLine("The tallest among the three is Akbar with height {0} cm",akbarHeight);
		else	//Anthony is the tallest
			Console.WriteLine("The tallest among the three is Anthony with height {0} cm",anthonyHeight);
	}	
}
			