using System;
class NumberChecker1{
    //method to find the number of digits in the number 
    public static int CountDigits(int number){
        int count = 0;
        while(number > 0){
            number /= 10;  
            count++;	//incrementing the count
        }
        return count;
    }

    //method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number){
        int digitCount = CountDigits(number); //to get the number of digits
        int[] digits = new int[digitCount];	//'digits' array to store the digits
        int index = digitCount - 1;	//variable for index
		
        while(number > 0){
            digits[index] = number % 10; //to get last digit and store it
            number /= 10; //to remove the last digit
			index--;
        }
        return digits;
    }

    //method to check Duck number
    public static bool IsDuckNumber(int[] digits){
		if (digits[0] == 0)	//number begining with zero is not duck number
        {
            return false;
        }
        foreach(int digit in digits)	//checking for other digits
        {
            if (digit == 0)
            {
                return true; 
            }
        }

        return false; //if no zero is found
    }
		
    //method to check Armstrong number
    public static bool IsArmstrongNumber(int number, int[] digits){
        int sum = 0;
        int numDigits = digits.Length;
		foreach(int digit in digits){
            sum += (int)Math.Pow(digit, numDigits); //sum of digits raised to the power of the number of digits
        }
		return sum == number; //if sum is equal to the number, then it is Armstrong
    }

    //method to find the largest and second largest elements in the digits array
    public static int[] FindLargestAndSecondLargest(int[] digits){
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach(int digit in digits){
            if(digit > largest){
                secondLargest = largest;
                largest = digit;
            }
            else if(digit > secondLargest && digit != largest){
                secondLargest = digit;
            }
        }
        return new int[]{largest,secondLargest};
    }

    //method to find the smallest and second smallest elements in the digits array
    public static int[] FindSmallestAndSecondSmallest(int[] digits){
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;
		foreach(int digit in digits){
            if(digit < smallest){
                secondSmallest = smallest;
                smallest = digit;
            }
            else if(digit < secondSmallest && digit != smallest){
                secondSmallest = digit;
            }
        }
        return new int[]{smallest, secondSmallest};
    }
	
	//Main method
    static void Main(){
		//taking number as input from user
		Console.Write("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());

        //to get digits of the number
        int[] digits = StoreDigits(num);

        //to count the number of digits
        int digitCount = CountDigits(num);
        Console.WriteLine("Number of digits is: {0}",digitCount);

        //checking Duck number
        bool isDuck = IsDuckNumber(digits);
        Console.WriteLine("Is Duck Number: {0}",isDuck);

        //checking Armstrong number
        bool isArmstrong = IsArmstrongNumber(num, digits);
        Console.WriteLine("Is Armstrong Number: {0}",isArmstrong);

        //finding the largest and second largest digits
        int[] largestCheck = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest Digit: {0}, Second Largest Digit: {1}",largestCheck[0],largestCheck[1]);

        //finding the smallest and second smallest digits
        int[] smallestCheck = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest Digit: {0}, Second Smallest Digit: {1}",smallestCheck[0],smallestCheck[1]);
    }
}
