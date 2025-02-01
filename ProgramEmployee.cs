using System;
//'Employee' class
public class Employee{
    //attributes(fields) of the Employee class
    private string name;
    private int id;
    private double salary;

    //constructor to initialize the employee's details
    public Employee(string name, int id, double salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    //method to display employee details
    public void DisplayDetails(){
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: "+name);
        Console.WriteLine("ID: "+id);
        Console.WriteLine("Salary: "+salary);
    }
}

//'ProgramEmployee' class
public class ProgramEmployee{
    static void Main(string[] args){
        //creating an Employee object
        Employee emp1 = new Employee("Akash Kumar", 101, 60000.00);
        Employee emp2 = new Employee("Pragati Shukla", 105, 85500.00);
        
        //printing the details of the employee using 'DisplayDetails()' method
        emp1.DisplayDetails();
		emp2.DisplayDetails();
    }
}
