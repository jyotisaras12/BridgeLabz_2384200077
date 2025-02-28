using System;
using System.Collections.Generic;

//creating abstract class 'Employee'
abstract class Employee{
    protected int employeeId;
    protected string name;
    protected int baseSalary;

    //abstract method to calculate salary
    public abstract double CalculateSalary();

    //constructor to initialize Employee details
    public Employee(int employeeId, string name, int baseSalary){
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    //method to display employee details
    public virtual void DisplayDetails(){
        Console.WriteLine("Employee Details:\nEmployee Id: {0}\nName: {1}\nSalary: {2}",employeeId, name, CalculateSalary());
    }
}

//creating interface for department
interface IDepartment{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

//creating 'FullTimeEmployee' class inheriting from Employee and implementing IDepartment
class FullTimeEmployee : Employee, IDepartment{
    private string department;

    //constructor to initialize FullTimeEmployee details
    public FullTimeEmployee(int id, string name, int salary) : base(id, name, salary) { }

    //method to calculate salary for full-time employees
    public override double CalculateSalary(){
        return baseSalary;
    }

    //method to assign department to the employee
    public void AssignDepartment(string department){
        this.department = department;
    }

    //method to get department details
    public string GetDepartmentDetails(){
        return ("Department: " + department);
    }

    //method to display employee details
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine(GetDepartmentDetails());
    }
}

//creating 'PartTimeEmployee' class inheriting from Employee and implementing IDepartment
class PartTimeEmployee : Employee, IDepartment{
    private string department;
    private int workingHours;
    private double hourlyRate;

    //constructor to initialize PartTimeEmployee details
    public PartTimeEmployee(int id, string name, int workingHours, double hourlyRate): base(id, name, 0){ //base salary is not fixed for part-time employees
        this.workingHours = workingHours;
        this.hourlyRate = hourlyRate;
    }

    //method to calculate salary
    public override double CalculateSalary(){
        return workingHours * hourlyRate;
    }

    //method to assign department to the employee
    public void AssignDepartment(string department){
        this.department = department;
    }

    //method to get department details
    public string GetDepartmentDetails(){
        return ("Department: " + department);
    }

    //method to display employee details 
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine(GetDepartmentDetails());
    }
}

class Program1{
    public static void Main(string[] args){
        //creating a list of employees
        List<Employee> employees = new List<Employee>();
        
        //adding a full-time employee
        FullTimeEmployee emp1 = new FullTimeEmployee(123, "Vishesh", 67000);
        emp1.AssignDepartment("IT");
        employees.Add(emp1);

        //adding a part-time employee
        PartTimeEmployee emp2 = new PartTimeEmployee(456, "Prabha", 90, 100);
        emp2.AssignDepartment("Management"); 
        employees.Add(emp2);

        //iterating through the list to display employee details
        foreach(Employee emp in employees){
            emp.DisplayDetails();
            Console.WriteLine(new string('-', 40));
        }
    }
}