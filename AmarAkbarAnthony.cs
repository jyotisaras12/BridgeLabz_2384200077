using System;
class AmarAkbarAnthony{
    static void Main(){
        //creating arrays to store ages and heights of the 3 friends
        string[] friends = {"Amar", "Akbar", "Anthony"};
        int[] ages = new int[3];
        double[] heights = new double[3];

        //taking ages and heights as input from user
        for(int i = 0; i < 3; i++){
            Console.Write("Enter age of {0}: ",friends[i]);
            ages[i] = Convert.ToInt32(Console.ReadLine());	//taking age as user input
            Console.Write("Enter height (in meters) of {0}: ",friends[i]);
            heights[i] = Convert.ToDouble(Console.ReadLine());	//taking height in m as user input
        }
        int youngestAge = ages[0];	//variable to find the age of the youngest friend
        double tallestHeight = heights[0];	//variable to find the height of the tallest friend
        string youngestFriend = friends[0];	//variable to find the youngest friend
        string tallestFriend = friends[0];	//variable to find the tallest friend

        //iterating through the arrays to find the youngest and the tallest
        for (int i = 1; i < 3; i++){
            if(ages[i] < youngestAge){
                youngestAge = ages[i];
                youngestFriend = friends[i];
            }
			if(heights[i] > tallestHeight){
                tallestHeight = heights[i];
                tallestFriend = friends[i];
            }
        }
		//printing the youngest and tallest friends
        Console.WriteLine("The youngest friend is {0} with age {1} years.",youngestFriend,youngestAge);
        Console.WriteLine("The tallest friend is {0} with height {1} meters.",tallestFriend,tallestHeight);
    }
}
