using System;
class EuclideanDistance{
    //method to calculate Euclidean distance
    public static double CalculateDistance(double x1, double y1, double x2, double y2){
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    //method to find the equation of a line and return slope and intercept as an array
    public static double[] GetLineEquation(double x1, double y1, double x2, double y2){
        double slope = (y2 - y1) / (x2 - x1);
        double intercept = y1 - slope * x1;
        return new double[] { slope, intercept };
    }

	//Main method
    static void Main(){
		//taking input from user
        Console.WriteLine("Enter x1, y1: ");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter x2, y2: ");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        //calculation of distance
        double distance = CalculateDistance(x1, y1, x2, y2);

        //to get line equation as an array
        double[] lineEquation = GetLineEquation(x1, y1, x2, y2);

        Console.WriteLine("Euclidean Distance: {0}",distance);
        Console.WriteLine("Equation of Line: y = {0}x + {1}",lineEquation[0],lineEquation[1]);
    }
}
