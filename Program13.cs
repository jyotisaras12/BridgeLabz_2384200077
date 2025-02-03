using System;
class Employee{
    //instance variables 
    public int EmployeeID { get; set; }     
    protected string Department { get; set; } 
    private double Salary { get; set; }       

    //constructor to initialize employee details
    public Employee(int employeeID, string department, double salary){
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    //public method to access the salary (getter)
    public double GetSalary(){
        return Salary;
    }

    //public method to modify salary (setter)
    public void ModifySalary(double newSalary){
        if (newSalary >= 0) Salary = newSalary;
        else Console.WriteLine("Salary cannot be negative.");
    }

    //method to display employee details
    public void DisplayEmployeeDetails(){
        Console.WriteLine("Employee ID: {0}\nDepartment: {1}\nSalary: {2}",EmployeeID, Department, Salary);
    }
}

class Manager : Employee{
    //constructor to initialize Manager details
    public Manager(int employeeID, string department, double salary)
        : base(employeeID, department, salary){
    }

    //method to display manager details
    public void DisplayManagerDetails(){
		Console.WriteLine("\nManager Details:\nEmployee ID: {0}\nDepartment: {1}\nSalary: {2}",EmployeeID, Department, GetSalary());
    }
}

class Program13{
    static void Main(string[] args){
        //creating an Employee object
        Employee employee = new Employee(101, "Development", 50000.0);
        Console.WriteLine("Employee Details:");
        employee.DisplayEmployeeDetails();

        //modifying the salary
        employee.ModifySalary(85000.0);
        Console.WriteLine("\nUpdated Employee Details:");
        employee.DisplayEmployeeDetails();

        //creating a Manager object
        Manager manager = new Manager(102, "Management", 90000.0);
        manager.DisplayManagerDetails();
    }
}
