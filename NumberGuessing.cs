using System;
class NumberGuessing{
    //method to generate a random guess 
    public static int GenerateGuess(int low, int high){
        Random random = new Random();
        return random.Next(low, high + 1);
    }

    //method to get feedback from the user
    public static string GetFeedback(){
        Console.WriteLine("Is the guess \"high\", \"low\", or \"correct\"?");
        string feedback = Console.ReadLine().ToLower();
        return feedback;
    }

    //method to guess the number
    public static void GuessTheNumber(){
        int low = 1, high = 100;
        int guess;
        string feedback;

        Console.WriteLine("Think of a number between 1 and 100!");
        while(true){
            //generate a random guess
            guess = GenerateGuess(low, high);
            Console.WriteLine("My guess is: "+guess);

            //get feedback from the user
            feedback = GetFeedback();

            if (feedback == "correct"){
                Console.WriteLine("I guessed the number {0} correctly.",guess);
                break; //exit the loop if the guess is correct
            }
            else if (feedback == "high"){	//when guess is too high
                high = guess - 1; 
            }
            else if (feedback == "l"){	//when guess is too low
                low = guess + 1; 
            }
            else{
                Console.WriteLine("Invalid feedback!");
            }
        }
    }

    //Main method
    public static void Main()
    {
		//calling 'GuessTheNumber()' method
        GuessTheNumber(); 
    }
}
