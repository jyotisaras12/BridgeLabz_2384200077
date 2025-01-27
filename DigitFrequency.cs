using System;
class DigitFrequency{
    static void Main(){
        //taking number as input from user
        Console.Write("Enter a number: ");
        long num = Convert.ToInt64(Console.ReadLine());
        //creating 'frequency' array to store the frequency of each digit(0-9)
        int[] frequency = new int[10];
        //iterating the number to get each digit and increase its frequency
        while(num > 0){
            int digit = (int)(num % 10);  //to get the last digit
            frequency[digit]++;  //increasing the frequency of the digit
            num /= 10;
        }
        //printing the frequency of each digit
        Console.WriteLine("Frequency of each digit in the number: ");
        for(int i = 0; i < 10; i++){
            if(frequency[i] > 0){  //displaying only the digits that appear in the number
                Console.WriteLine("Digit {0}: {1}",i,frequency[i]);
            }
        }
    }
}
