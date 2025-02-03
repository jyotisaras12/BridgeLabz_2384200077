using System;
class Circle{
    //declaring field
    public double Radius { get; set; }

    //default constructor
    public Circle() : this(10.5){ //calls the parameterized constructor with a default value of 10.5
        Console.WriteLine("Default constructor called!");
    }

    //parameterized constructor 
    public Circle(double radius){
        Radius = radius;
        Console.WriteLine("Parameterized constructor called!");
    }
	
	//display Radius
    public void DisplayRadius(){
       Console.WriteLine("Radius: {0}",Radius);
    }
}

class Program2{
    static void Main(string[] args){
        //using the default constructor
        Circle circle1 = new Circle();
        Console.WriteLine("Circle 1:");
		circle1.DisplayRadius();

        //using the parameterized constructor
        Circle circle2 = new Circle(15.0);
        Console.WriteLine("Circle 2:");
		circle2.DisplayRadius();
    }
}
