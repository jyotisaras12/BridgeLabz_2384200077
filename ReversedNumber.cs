using System;
class ReversedNumber{
    static void Main(){
        //taking number as input from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int num = number;
        int count = 0;	//variable to count digits of number
		//iterating through the number to count the number of digits
        while(num != 0){
            num = num / 10;
            count++;
        }
        //creating 'digits' array to store the digits
        int[] digits = new int[count];

        //iterating through the number to store the digits in the array
        num = number;
        for(int i = 0; i < count; i++){
            digits[i] = num % 10;  //to get the last digit
			num = num / 10;
        }
        //creating 'reversedDigits' array to store the digits in reverse order
        int[] reversedDigits = new int[count];
		//reversing the digits using 'digits' array
        for(int i = 0; i < count; i++){
            reversedDigits[i] = digits[i];
        }
		//printing the reversed digits
        Console.WriteLine("Reversed number is: ");
        foreach(int digit in reversedDigits){
			Console.Write(digit);
		}
		Console.WriteLine();
    }
}
