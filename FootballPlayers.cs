using System;
class FootballPlayers{
    //method to find the sum of all elements in the array
    static int FindSum(int[] heights){
        int sum = 0;
        foreach(var height in heights){
            sum += height;
        }
        return sum;
    }

    //method to calculate the mean height
    static double FindMean(int sum, int count){
        return (double)sum / count;
    }

    //method to find the shortest height
    static int FindShortestHeight(int[] heights){
        int shortest = heights[0];
        foreach(int height in heights){
            if(height < shortest) shortest = height;
        }
        return shortest;
    }

    //method to find the tallest height
    static int FindTallestHeight(int[] heights){
        int tallest = heights[0];
        foreach(int height in heights){
            if(height > tallest) tallest = height;
        }
        return tallest;
    }
	
	//Main method
    static void Main(string[] args){
        //creating 'heights' array to store the heights of 11 players
        Random rand = new Random();
        int[] heights = new int[11];

        //assigning random heights in the array
        for(int i = 0; i < heights.Length; i++){
            heights[i] = rand.Next(150, 251); //random height between 150 and 250
        }

        //printing the heights of all players
        Console.WriteLine("Heights of the players in cms:");
        foreach(int height in heights)
        {
            Console.WriteLine(height);
        }

        //printing sum, mean, shortest height and tallest height using 'FindSum', 'FindMean', 'FindShortestHeight' and 'FindTallestHeight' methods
        int sum = FindSum(heights);
        double mean = FindMean(sum, heights.Length);
        int shortest = FindShortestHeight(heights);
        int tallest = FindTallestHeight(heights);

        Console.WriteLine("Sum of heights is: {0} cm",sum);
        Console.WriteLine("Mean height is: {0} cm",mean);
        Console.WriteLine("Shortest height is: {0} cm",shortest);
        Console.WriteLine("Tallest height: {0} cm",tallest);
    }

}
