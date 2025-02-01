using System;
//'Circle' class
public class Circle{
    //attributes(fields) of the Circle class
    private double radius;

    //constructor to initialize the circle's radius
    public Circle(double radius){
        this.radius = radius;
    }

	//method to calculate circumference
	public double Circumference(){
		return (2 * Math.PI * radius);
	}
	
	//method to calculate area of the circle
	public double Area(){
		return (Math.PI * Math.Pow(radius, 2));
	}
		
    //method to display circumference and area of circle
    public void DisplayResult(){
		double circumference = Circumference();
		double area = Area();
        Console.WriteLine("The radius of the circle is: "+radius);
        Console.WriteLine("The circumference of the circle is: "+circumference);
        Console.WriteLine("The area of the circle is: "+area);
    }
}

//'ProgramCircle' class
public class ProgramCircle{
    static void Main(string[] args){
        //taking radius of the circle as input from user
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        //creating a Circle object
        Circle circle = new Circle(radius);

        //printing the details of the circle using 'DisplayDetails()' method
        circle.DisplayResult();
    }
}
