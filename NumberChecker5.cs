using System;
class NumberChecker5{
    //method to find the factors of a number
    public static int[] FindFactors(int number){
        int[] factors = new int[number / 2];  //array to store factors, maximum size is number/2
        int count = 0;
        for(int i = 1; i <= number / 2; i++){
            if(number % i == 0){
                factors[count] = i; 
                count++;
            }
        }
        Array.Resize(ref factors, count);  //resize the array to fit the number of factors found
        return factors;
    }

    //method to find the greatest factor of a number 
    public static int FindGreatestFactor(int[] factors){
        int greatestFactor = 0;
        foreach(int factor in factors){
            if(factor > greatestFactor) greatestFactor = factor;
        }
        return greatestFactor;
    }

    //method to find the sum of the factors 
    public static int SumOfFactors(int[] factors){
        int sum = 0;
        foreach(int factor in factors){
            sum += factor;
        }
        return sum;
    }

    //method to find the product of the factors
    public static int ProductOfFactors(int[] factors){
        int product = 1;
        foreach(int factor in factors){
            product *= factor;
        }
        return product;
    }

    //method to find the product of the cube of the factors 
    public static double ProductOfCubesOfFactors(int[] factors){
        double product = 1;
        foreach(int factor in factors){
            product *= Math.Pow(factor, 3);  
        }
        return product;
    }

    //method to check perfect number
    public static bool IsPerfectNumber(int number){
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors);
        return sum == number;
    }

    //method to check abundant number
    public static bool IsAbundantNumber(int number){
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors);
        return sum > number;
    }

    //method to check deficient number
    public static bool IsDeficientNumber(int number){
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors);
        return sum < number;
    }

    //method to check strong number
    public static bool IsStrongNumber(int number){
        int temp = number;
        int sumOfFactorials = 0;

        while (temp > 0){
            int digit = temp % 10;
            sumOfFactorials += Factorial(digit);  
            temp /= 10;
        }
        return sumOfFactorials == number;
    }

    //method to calculate factorial of a number
    public static int Factorial(int number){
        int result = 1;
        for (int i = 1; i <= number; i++){
            result *= i;
        }
        return result;
    }

    //Main method
    static void Main(string[] args){
        //taking number as input from the user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        //finding factors of the number
        int[] factors = FindFactors(num);

        //finding the greatest factor
        int greatestFactor = FindGreatestFactor(factors);
        Console.WriteLine("Greatest Factor: {0}",greatestFactor);

        //finding the sum of the factors
        int sumOfFactors = SumOfFactors(factors);
        Console.WriteLine("Sum of Factors: {0}",sumOfFactors);

        //finding the product of the factors
        int productOfFactors = ProductOfFactors(factors);
        Console.WriteLine("Product of Factors: {0}",productOfFactors);

        //finding the product of the cubes of the factors
        double productOfCubes = ProductOfCubesOfFactors(factors);
        Console.WriteLine("Product of Cubes of Factors: {0}",productOfCubes);

        //checking if the number is a perfect number
        bool isPerfect = IsPerfectNumber(num);
        Console.WriteLine("Is Perfect Number: {0}",isPerfect);

        //checking if the number is an abundant number
        bool isAbundant = IsAbundantNumber(num);
        Console.WriteLine("Is Abundant Number: {0}",isAbundant);

        //checking if the number is a deficient number
        bool isDeficient = IsDeficientNumber(num);
        Console.WriteLine("Is Deficient Number: {0}",isDeficient);

        //checking if the number is a strong number
        bool isStrong = IsStrongNumber(num);
        Console.WriteLine("Is Strong Number: {0}",isStrong);
    }
}
