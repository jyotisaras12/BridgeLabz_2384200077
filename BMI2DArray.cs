using System;
class BMI2DArray{
	//method to calculate BMI
	public static void CalculateBMI(double[,] data){
        for(int i = 0; i < data.GetLength(0); i++){
            double weight = data[i, 0];	//first column stores weight in kg
            double heightCm = data[i, 1];	//second column stores height in cm
            double heightMeters = heightCm / 100;	//cm to m conversion of height
            
			//calculation of BMI
            double bmi = weight / Math.Pow(heightMeters,2);
            
            //storing BMI in third column
            data[i, 2] = bmi;
		}
	}
	
	//method to determine BMI status
    public static string[] GetBMIStatus(double[,] data){
        string[] status = new string[data.GetLength(0)];
		for (int i = 0; i < data.GetLength(0); i++){
            double bmi = data[i, 2]; //gettig BMI from the third column

            //determining BMI status 
            if (bmi < 18.5) status[i] = "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9) status[i] = "Normal weight";
            else if (bmi >= 25 && bmi <= 39.9) status[i] = "Overweight";
            else status[i] = "Obese";
		}
        return status;	//returning the status
    }
	
	//Main method
    static void Main(){
		//creating a 2D array to store weight, height, and BMI for each person
        double[,] data = new double[10, 3];
		
        //taking weight and height as input from user
		for(int i = 0; i < 10; i++){
            Console.WriteLine("Enter details for person {0}:",i+1);
			//taking weight as input by user
			Console.Write("Enter weight in kg: ");
			data[i, 0] = Convert.ToDouble(Console.ReadLine());
				
			//taking height in cm as input from user
			Console.Write("Enter height in cm: ");
			data[i, 1] = Convert.ToDouble(Console.ReadLine());
		}
		
        //calculation of BMI for each person by using 'CalculateBMI' method
        CalculateBMI(data);

        //finding BMI status for each person using 'GetBMIStatus' method
        string[] status = GetBMIStatus(data);

        //printing the BMI and weight status for each person
        Console.WriteLine("Details of each person:");
        for (int i = 0; i < 10; i++){
            double weight = data[i, 0];
            double heightInCm = data[i, 1];
            double bmi = data[i, 2];

            //printing details
            Console.WriteLine("Person {0}:",i+1);
            Console.WriteLine("Weight: {0} kg",weight);
            Console.WriteLine("Height: {0} cm",heightInCm);
            Console.WriteLine("BMI: {0}",bmi);
            Console.WriteLine("Status: {0}",status[i]);
            Console.WriteLine();
        }
    }
}
















