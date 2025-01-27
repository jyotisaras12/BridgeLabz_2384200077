using System;
class FactorsArray{
    static void Main(){
        //taking number as input from user
        Console.Write("Enter a number to find its factors: ");
        int num = Convert.ToInt32(Console.ReadLine());

        //creating 'factors' array of size 10
        int maxFactor = 10;	//variable for array size
        int[] factors = new int[maxFactor];
        int index = 0;	//variable to count index of array

        //iterating from 1 to num to find the factors of the number
        for(int i = 1; i <= num; i++){
            if(num % i == 0){	//checking if i is a factor of num
                if(index == maxFactor){	//resizing array if array is full
                    maxFactor *= 2; //double the size of the array
                    int[] temp = new int[maxFactor]; //temporary array to hold new size
					//copying old elements to the temporary array
                    for (int j = 0; j < factors.Length; j++)
                    {
                        temp[j] = factors[j];
                    }
                    factors = temp; //reassigning the factors array to the temporary array
                }
                factors[index] = i; //storing the factor in the array
                index++; //incrementing index counter
            }
        }
		//printing the factors
        Console.WriteLine("Factors of {0} are :",num);
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(factors[i]);
        }
    }
}
