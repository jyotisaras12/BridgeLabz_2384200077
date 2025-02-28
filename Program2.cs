using System;

//creating base class: Employee
class Employee{
    private string name { get; set; }
    private int id { get; set; }
    private double salary { get; set; }

	//constructor to initialise Employee details
    public Employee(string name, int id, double salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
	
	//method to display details of Employee
    public virtual void DisplayDetails(){
        Console.WriteLine("Name: {0}\nID: {1}\nSalary: {2}",name, id, salary);
    }
}

//creating subclass: Manager
class Manager : Employee{
    private int teamSize { get; set; }
	
	//constructor to initialise Manager details
    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary){
        this.teamSize = teamSize;
    }
	
	//method to deisplay details of Manager
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Team Size: "+teamSize);
    }
}

//creating subclass: Developer
class Developer : Employee{
    private string programmingLanguage { get; set; }

	//constructor to initialise Developer details
    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary){
        this.programmingLanguage = programmingLanguage;
    }
	
	//method to display details of Developer
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Programming Language: "+programmingLanguage);
    }
}

//creating subclass: Intern
class Intern : Employee{
    private string internshipDuration { get; set; }

	//constructor to initialise Intern details
    public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary){
        this.internshipDuration = internshipDuration;
    }

	//method to display details of Intern
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: "+internshipDuration);
    }
}

class Program2{
    static void Main(string[] args){
		//creating objects for 'Manager', 'Developer' and 'Intern' classes referencing 'Employee'
        Employee manager = new Manager("Bhaskar", 148, 90000, 10);
        Employee developer = new Developer("Avishi", 112, 55000, "C#");
        Employee intern = new Intern("Sejal", 166, 20000, "3 months");
	
		//displaying employee details
        manager.DisplayDetails();
        Console.WriteLine();
        developer.DisplayDetails();
        Console.WriteLine();
        intern.DisplayDetails();
    }
}
