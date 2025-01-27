using System;
class BMI2DArray{
    static void Main(){
        //taking number of persons as input from user
        Console.Write("Enter the number of persons: ");
        int numPersons = Convert.ToInt32(Console.ReadLine());
		//creating a 2D array to store weight, height, and BMI for each person
        double[][] personData = new double[numPersons][];
        //creating an array to store the weight status for each person
        string[] weightStatus = new string[numPersons];
		for(int i = 0; i < numPersons; i++){
			personData[i] = new double[3];
            Console.WriteLine("Enter details for person {0}:",i+1);
			//to input weight and check only positive weight is entered by user
			double weight = -1;
			while(weight <= 0){
				Console.Write("Weight (in kg): ");
				weight = Convert.ToDouble(Console.ReadLine());
				if(weight <= 0) Console.WriteLine("Please enter a positive value for weight.");
			}
			//to input height and check only positive height is entered by user
			double height = -1;
			while(height <= 0){
				Console.Write("Height (in meters): ");
				height = Convert.ToDouble(Console.ReadLine());
				if (height <= 0) Console.WriteLine("Please enter a positive value for height.");
			}
			//storing weight and height in the 2D array
			personData[i][0] = weight;
			personData[i][1] = height;
			//calculation of BMI
			personData[i][2] = weight / (height * height);
			//finding status of a person
			if(personData[i][2] < 18.5) weightStatus[i] = "Underweight";
            else if(personData[i][2] >= 18.5 && personData[i][2] < 25) weightStatus[i] = "Normal weight";
            else if(personData[i][2] >= 25 && personData[i][2] < 30) weightStatus[i] = "Overweight";
            else weightStatus[i] = "Obese";
		}
        //printing the BMI and weight status for each person
        Console.WriteLine("BMI and Weight Status for all persons:");
        for(int i = 0; i < numPersons; i++){
            Console.WriteLine("Person {0}:",i + 1);
            Console.WriteLine("Height: {0} meters",personData[i][1]);
            Console.WriteLine("Weight: {0} kg",personData[i][0]);
            Console.WriteLine("BMI: {0}",personData[i][2]);
            Console.WriteLine("Weight Status: {0}",weightStatus[i]);
        }
    }
}
















