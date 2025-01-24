using System;
class BMI{
	static void Main(string[] args){
		Console.Write("Enter weight in kg: ");	
		double weight = Convert.ToDouble(Console.ReadLine());	//taking weight in kg as input from user
		Console.Write("Enter height in cm: ");	
		double height = Convert.ToDouble(Console.ReadLine());	//taking height in cm as input from user
		double heightM = height / 100;	//cm to m conversion of height
		double bmi = weight / (heightM * heightM);	//calculation of BMI
		string status;	
		if(bmi <= 18.4){	//condition for underweight
			status = "Underweight";
		}	
		else if(bmi >= 18.4 && bmi <= 24.9){	//condition for normal
			status = "Normal";
		}
		else if(bmi >= 25 && bmi <= 39.9){	//condition for overweight
			status = "Overweight";
		}
		else{	//for obese
			status = "Obese";
		}
		Console.WriteLine("The person's status according to BMI is "+status);	//printing the status
	}	
}
			