using System;
class OTP{
    //method to generate a 6-digit OTP number using Math.Random()
    public static int GenerateOTP(){
        Random random = new Random();
        return random.Next(100000, 1000000);  //generating a number between 100000 and 999999
    }

    //method to ensure that the OTP numbers generated are unique
    public static bool AreOTPsUnique(int[] otpArray){
        for(int i = 0; i < otpArray.Length; i++){
            for(int j = i + 1; j < otpArray.Length; j++){
                if(otpArray[i] == otpArray[j])  //if two OTPs are the same
                {
                    return false;  //OTPs are not unique
                }
            }
        }
        return true;  //OTPs are unique
    }

    //Main method
    static void Main(string[] args){
        int[] otpArray = new int[10];  //array to store 10 OTPs

        //generate=ing 10 OTP numbers and storing them in the array
        for(int i = 0; i < 10; i++){
            otpArray[i] = GenerateOTP();
            Console.WriteLine("Generated OTP {0}: {1}", i + 1, otpArray[i]);
        }

        //checking if all the OTPs are unique
        bool areUnique = AreOTPsUnique(otpArray);

        if (areUnique) Console.WriteLine("All OTPs are unique.");
        else Console.WriteLine("Some OTPs are not unique.");
    }
}
