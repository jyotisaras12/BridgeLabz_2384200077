using System;
class LargestDigit{
    static void Main(){
        //taking the number as input from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int maxDigit = 10;	//variable to store maximum digits in a number
        //creating 'digits' array of size maxDigit
		int[] digits = new int[maxDigit];
        int index = 0;	//variable to count index of array
		//iterating to get digits of the number
        while(number != 0 && index < maxDigit){
            digits[index] = number % 10;	//to get the last digit
            number = number / 10; 
            index++;	//incrementing the index counter
        }
		//initializing variables to store the largest and second-largest digits
        int largest = 0;
        int secondLargest = 0;
        //iterating through the array to find the largest and second-largest digits 
        for(int i = 0; i < index; i++){
            if (digits[i] > largest){
                secondLargest = largest;	//for second-largest digit
                largest = digits[i];	//for largest digit
            }
            else if (digits[i] > secondLargest && digits[i] < largest){
                secondLargest = digits[i];
            }
        }
		if(secondLargest == 0){
			Console.WriteLine("There is no largest digit and second-largest digit as all digits are same.");	//if digits are same, there is no second-largest digit
		}
		else{	//printing the largest and second-largest digits
            Console.WriteLine("Largest digit: {0}",largest);
            Console.WriteLine("Second largest digit: {0}",secondLargest);
        }
    }
}
