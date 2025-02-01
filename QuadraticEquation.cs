using System;
class QuadraticEquation{
	//method to find roots of quadratic equation
	public double[] FindQuadraticRoot(int a, int b, int c){
		double delta = Math.Pow(b,2) + 4*a*c;	//calculation of delta
		if(delta > 0){	//real and different roots
			double x1 = (-b + delta)/(2*a);
			double x2 = (-b - delta)/(2*a);
			return new double[]{x1, x2};
		}
		else if(delta == 0){	//real and equal roots
			double x1 = -b/(2*a);
			return new double[]{x1};
		}
		else return new double[0];	//imaginary roots
	}
	
	//Main method
	static void Main(string[] args){
		//taking values of a,b and c as input from user
		Console.WriteLine("Enter values of a,b and c for quadratic equation of the form: ax^2 + bx + c");
		Console.Write("Enter value of 'a': ");	
		int a = Convert.ToInt32(Console.ReadLine());	//value of a
		Console.Write("Enter value of 'b': ");
		int b = Convert.ToInt32(Console.ReadLine());	//value of b
		Console.Write("Enter value of 'c': ");
		int c = Convert.ToInt32(Console.ReadLine());	//value of c
		
		//instantiating the 'RandomNumbers' class
		QuadraticEquation quad = new QuadraticEquation();
		
		//printing the roots using 'FindQuadraticRoot' method
		double[] roots = quad.FindQuadraticRoot(a, b, c);
		Console.WriteLine("The roots of quadratic equation {0}x^2 + {1}x + {2} = 0 are:",a,b,c);
		foreach(double root in roots){
			Console.WriteLine(root);
		}
	}
}