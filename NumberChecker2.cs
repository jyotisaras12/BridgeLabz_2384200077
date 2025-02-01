using System;
class NumberChecker2{
    //method to find the count of digits in the number
    public static int CountDigits(int number){
        int count = 0;
        while (number > 0){
            number /= 10;
            count++;
        }
        return count;
    }

    //method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number){
        int digitCount = CountDigits(number);
        int[] digits = new int[digitCount];
        int index = digitCount - 1;
		while(number > 0){
            digits[index] = number % 10;
            number /= 10;
			index--;
        }
        return digits;
    }

    //method to find the sum of the digits of the number
    public static int SumOfDigits(int[] digits){
        int sum = 0;
        foreach(int digit in digits){
            sum += digit;	//sum of digits
        }
        return sum;
    }

    //method to find the sum of the squares of the digits 
    public static double SumOfSquaresOfDigits(int[] digits){
        double sum = 0;
        foreach(int digit in digits){
            sum += Math.Pow(digit, 2);  //sum of square of each digit
        }
        return sum;
    }

    //method to check Harshad number
    public static bool IsHarshadNumber(int number, int[] digits){
        int sumOfDigits = SumOfDigits(digits);  //to get the sum of digits
        return number % sumOfDigits == 0;  //checking if number is divisible by sum of its digits
    }

    //method to find the frequency of each digit in the number and store in a 2D array
    public static int[,] FindDigitFrequency(int[] digits){
        int[,] frequency = new int[10, 2];  

        foreach(int digit in digits){
            frequency[digit, 0] = digit;  //storing the digit
            frequency[digit, 1]++;        //incrementing its frequency
        }
        return frequency;
    }
	
	//Main method
	static void Main(string[] args){
        //taking number as input from user
		Console.Write("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());

        //to get digits of the number
        int[] digits = StoreDigits(num);

        //to count the number of digits
        int digitCount = CountDigits(num);
        Console.WriteLine("Number of digits is: {0}",digitCount);

        //to calculate sum of digits
        int sumDigits = SumOfDigits(digits);
        Console.WriteLine("Sum of digits is: {0}",sumDigits);

        //to calculate sum of squares of digits
        double sumSquares = SumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of squares of digits is: {0}",sumSquares);

        //to check Harshad number
        bool isHarshad = IsHarshadNumber(num, digits);
        Console.WriteLine("Is Harshad Number: {0}",isHarshad);

        //to find frequency of digits
        int[,] digitFrequency = FindDigitFrequency(digits);
        Console.WriteLine("Digit frequencies:");
        for(int i = 0; i < 10; i++){
            if(digitFrequency[i, 1] > 0){  //checking if frequency is greater than 0
                Console.WriteLine("Digit {0}: {1} ",digitFrequency[i, 0],digitFrequency[i, 1]);
            }
        }
    }
}
