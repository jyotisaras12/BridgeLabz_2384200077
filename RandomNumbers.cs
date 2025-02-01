using System;
class RandomNumbers{
	//method to generate 4-digit random numbers in an array
	public int[] Generate4DigitRandomArray(int size){
		int[] randomNumbers = new int[size];	//declaring array 'randomNumbers'
		Random rand = new Random();
		for(int i = 0; i < size; i++){
			randomNumbers[i] = rand.Next(1000, 10000);  //generating a random number between 1000 and 9999
		}
		return randomNumbers;	//returning the array
	}
	
	//method to find average, minimum and maximum
	public double[] FindAverageMinMax(int[] numbers){
		double sum = 0.0;	//variable to store the sum of numbers in array
		double minValue = numbers[0];	//variable to store minimum number
		double maxValue = numbers[1];	//variable to store maximum number
		//iterating through the array to find average, minimum and maximum
		for(int i = 0; i < numbers.Length; i++){
			sum += numbers[i];
			minValue = Math.Min(minValue, numbers[i]);
			maxValue = Math.Max(maxValue, numbers[i]);
		}
		double average = sum/numbers.Length;	//calculation of average
		return new double[]{average, minValue, maxValue};	//returning array
	}
	
	//Main method
	static void Main(string[] args){
		//instantiating the 'RandomNumbers' class
		RandomNumbers random = new RandomNumbers();
		int[] numbers = random.Generate4DigitRandomArray(5);	//size = 5
		double[] avgMinMax = random.FindAverageMinMax(numbers);
		//printing the output 
		Console.WriteLine("Randoms numbers are: ");
		foreach(int num in numbers){
			Console.Write(num+ " ");
		}
		Console.WriteLine();
		Console.WriteLine("Average is: {0}, Minimum number is: {1} and Maximum number is: {2}",avgMinMax[0],avgMinMax[1],avgMinMax[2]);
	}
}