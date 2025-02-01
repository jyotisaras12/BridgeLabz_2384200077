using System;
class TrigonometricFunctions{
    //method to calculate various trigonometric functions
    public double[] CalculateTrigonometricFunctions(double angle){
        //degrees to radians conversion of angle
        double radians = angle * (Math.PI / 180.0);
		
        //calculation of sine, cosine, and tangent using Math functions
        double sin = Math.Sin(radians);
        double cos = Math.Cos(radians);
        double tan = Math.Tan(radians);

        return new double[]{sin, cos, tan};	//returning the result as an array
    }
	
	//Main method
    static void Main(string[] args){
        //taking angle in degrees as input from user
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());
		
		//instantiating the 'TrigonometricFunctions' class
        TrigonometricFunctions trigonometry = new TrigonometricFunctions();
        
        //calling the method to calculate trigonometric functions
        double[] result = trigonometry.CalculateTrigonometricFunctions(angle);

        //printing the trigonometric functions
        Console.WriteLine("Sine: "+result[0]);
        Console.WriteLine("Cosine: "+result[1]);
        Console.WriteLine("Tangent: "+result[2]);
    }
}
