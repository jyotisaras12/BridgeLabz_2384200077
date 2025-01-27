using System;
class MeanHeight{
	static void Main(string[] args){
		//creating 'heights' array of size 11
		double[] heights = new double[11];	
		double sum = 0.0;	//variable sum to store sum of heights
		double meanHeight = 0.0;	//variable meanHeight to calculate mean height of players
		
		//iterating from 0 to the largest index of array
		for(int i = 0; i < heights.Length; i++){	
			Console.Write("Enter height of player {0}: ",i+1);	
			//taking height of players as input from user
			heights[i] = Convert.ToDouble(Console.ReadLine());	
		}
		//iterating through array to calculate the sum of heights of all players
		foreach(double height in heights){	
			sum += height;
		}
		meanHeight = sum/11;	//calculation of mean height
		Console.WriteLine("The mean height of players present in a football team is {0}",meanHeight);	//printing the output
	}
}