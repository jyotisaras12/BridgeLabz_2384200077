using System;
class AmarAkbarAnthony{
    //method to find the youngest friend
    public static string FindYoungest(int[] ages, string[] names){
        int youngestAge = ages[0];
        string youngestFriend = names[0];

        //iterating through the 'ages' array to find the youngest
        for (int i = 1; i < ages.Length; i++){
            if (ages[i] < youngestAge){
                youngestAge = ages[i];
                youngestFriend = names[i];
            }
        }
		return youngestFriend;
    }

    //method to find the tallest friend
    public static string FindTallest(double[] heights, string[] names){
        double tallestHeight = heights[0];
        string tallestFriend = names[0];

        //iterating through the 'heights' array to find the tallest
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > tallestHeight){
                tallestHeight = heights[i];
                tallestFriend = names[i];
            }
        }
        return tallestFriend;
    }

	//Main method
    static void Main(){
        //creating arrays to store ages and heights of 3 friends
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        //taking ages and heights as input from user
        for (int i = 0; i < 3; i++){
            Console.Write("Enter age of {0}: ",names[i]);
            ages[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height (in cm) of {0}: ",names[i]);
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        //printing the youngest and tallest friends using 'FindYoungest' and 'FindTallest' methods
        Console.WriteLine("The youngest friend is {0}.",FindYoungest(ages, names));
        Console.WriteLine("The tallest friend is {0}.",FindTallest(heights, names));
    }
}
