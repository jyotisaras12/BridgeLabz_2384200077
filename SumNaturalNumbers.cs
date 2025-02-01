using System;
class SumNaturalNumbers{
    //method to find the sum of n natural numbers using recursion
    public static int SumUsingRecursion(int n){
        //base condition: when n reaches 1, return 1
        if (n == 1) return 1;
        //calculation of sum using recursion
        return n + SumUsingRecursion(n - 1);
    }

    //method to find the sum using the formula n * (n + 1) / 2
    public static int SumUsingFormula(int n){
        return n * (n + 1) / 2;
    }

	//Main method
    static void Main(){
        //taking number as input from user
        Console.Write("Enter a natural number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        //checking if input is a valid natural number
        if(num > 0){
            //calculation of sum using recursion
            int sumRecursion = SumUsingRecursion(num);
            //calculation of sum using formula
            int sumFormula = SumUsingFormula(num);

            //printing the results
            Console.WriteLine("Sum of the first {0} natural numbers using recursion is: {1}",num,sumRecursion);
            Console.WriteLine("Sum of the first {0} natural numbers using formula is: {1}",num,sumFormula);

            //comparing the results if they are equal
            if(sumRecursion == sumFormula) Console.WriteLine("Sum using recursion and formula is equal.");
            else Console.WriteLine("Sum using recursion and formula is not equal.");
        }
        else{
            //not a valid natural number
            Console.WriteLine("Invalid input! Please enter a valid natural number.");
        }
    }
}
