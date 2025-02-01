using System;
class NumberChecker3{
    //method to find the count of digits in the number
    public static int CountDigits(int number){
        int count = 0;
        while(number > 0){
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
        while (number > 0){
            digits[index] = number % 10;
            number /= 10;
            index--;
        }
        return digits;
    }

    //method to reverse the digits array
    public static int[] ReverseDigits(int[] digits){
        int[] reversedDigits = new int[digits.Length];
        int index = 0;
        for(int i = digits.Length - 1; i >= 0; i--){
            reversedDigits[index++] = digits[i];
        }
        return reversedDigits;
    }

    //method to compare two arrays 
    public static bool AreArraysEqual(int[] array1, int[] array2){
        if (array1.Length != array2.Length) return false;
		for (int i = 0; i < array1.Length; i++){
            if (array1[i] != array2[i]) return false;
        }
        return true;
    }

    //method to check palindrome number
    public static bool IsPalindrome(int number){
        int[] digits = StoreDigits(number);
        int[] reversedDigits = ReverseDigits(digits);
        return AreArraysEqual(digits, reversedDigits);
    }

    //method to check Duck Number
    public static bool IsDuckNumber(int number){
        int[] digits = StoreDigits(number);
        foreach(int digit in digits){
            if(digit == 0) return true;
        }
        return false;
    }

    //Main method
    static void Main(string[] args){
        //taking number as input from the user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        //to get digits of the number
        int[] digits = StoreDigits(num);

        //to count the number of digits
        int digitCount = CountDigits(num);
        Console.WriteLine("Number of digits is: {0}",digitCount);

        //checking if the number is a palindrome
        bool isPalindrome = IsPalindrome(num);
        Console.WriteLine("Is Palindrome: {0}",isPalindrome);

        //checking if the number is a Duck Number
        bool isDuckNumber = IsDuckNumber(num);
        Console.WriteLine("Is Duck Number: {0}",isDuckNumber);

        //to reverse the digits 
        int[] reversedDigits = ReverseDigits(digits);
        Console.WriteLine("Reversed Digits are: ");
		foreach(int revDigit in reversedDigits){
			Console.Write(revDigit);
		}
		Console.WriteLine();

        //comparing original digits array and reversed digits array
        bool areEqual = AreArraysEqual(digits, reversedDigits);
        Console.WriteLine("Are original and reversed digits equal? {0}",areEqual);
    }
}
