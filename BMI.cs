using System;
class BMI{
    static void Main(){
        //taking number of persons as input from user
        Console.Write("Enter the number of persons: ");
        int numPersons = Convert.ToInt32(Console.ReadLine());
		//creating arrays to store the weight, height, BMI, and weight status for each person
        double[] weights = new double[numPersons];
        double[] heights = new double[numPersons];
        double[] bmis = new double[numPersons];
        string[] weightStatus = new string[numPersons];
		//iterating from 0 to numPersons-1 to get input for each person
        for (int i = 0; i < numPersons; i++){
            Console.WriteLine("Enter details for person {0}: ",i + 1);
            Console.Write("Weight (in kg): ");
            weights[i] = Convert.ToDouble(Console.ReadLine());	//taking weight as input from user
            Console.Write("Height (in meters): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());	//taking height as input from user
			//Calculation of BMI
			bmis[i] = weights[i] / (heights[i] * heights[i]);
			//finding the weight status based on BMI
            if (bmis[i] < 18.5) weightStatus[i] = "Underweight";
			else if (bmis[i] >= 18.5 && bmis[i] < 25) weightStatus[i] = "Normal weight";
            else if (bmis[i] >= 25 && bmis[i] < 40) weightStatus[i] = "Overweight";
            else weightStatus[i] = "Obese";
        }
        //printing the BMI and weight status for each person
        Console.WriteLine("BMI and Weight Status for all persons: ");
        for(int i = 0; i < numPersons; i++){
            Console.WriteLine("Person {0}: ",i + 1);
            Console.WriteLine("Height: {0} meters",heights[i]);
            Console.WriteLine("Weight: {0} kg",weights[i]);
            Console.WriteLine("BMI: {0}",bmis[i]);
            Console.WriteLine("Weight Status: {0}",weightStatus[i]);
        }
    }
}
