using System;
using System.Collections.Generic;

//creating 'Company' class
class Company{
    public string name { get; private set; }
    private List<Department> departments;
    
	//constructor to initialise Company details
    public Company(string name){
        this.name = name;
        departments = new List<Department>();
    }
    
	//method to add departments
    public void AddDepartment(Department department){
        departments.Add(department);
    }
    
	//method to display the company
    public void DisplayCompany(){
        Console.WriteLine("\nCompany: {0}",name);
        foreach(Department dept in departments){
            dept.DisplayDepartment();
        }
    }
}

//creating 'Department' class
class Department{
    public string name { get; private set; }
    private List<Employee> employees;
    
	//constructor to initialise Department details
    public Department(string name){
        this.name = name;
        employees = new List<Employee>();
    }
    
	//method to add employees in a department
    public void AddEmployee(Employee employee){
        employees.Add(employee);
    }
    
	//method to display department
    public void DisplayDepartment(){
        Console.WriteLine("\nDepartment: {0}\n",name);
        foreach(Employee emp in employees){
            Console.WriteLine("Employee: {0}",emp.name);
        }
    }
}

//creating 'Employee' class
class Employee{
    public string name { get; private set; }
    
	//constructor to initialise Employee details
    public Employee(string name){
        this.name = name;
    }
}

class Program3{
    static void Main(string[] args){
        //creating Company objects
        Company company1 = new Company("Capgemini");
		Company company2 = new Company("Infosys");
        
        //creating department objects
        Department dept1 = new Department("Engineering");
        Department dept2 = new Department("Human Resources");
		Department dept3 = new Department("Management");
        
        //adding employees to departments
        dept1.AddEmployee(new Employee("Alisha"));
        dept1.AddEmployee(new Employee("Sejal"));
        dept2.AddEmployee(new Employee("Shivam"));
        dept3.AddEmployee(new Employee("Manvi"));
		dept3.AddEmployee(new Employee("Astha"));
        
        //adding departments to the company
        company1.AddDepartment(dept1);
        company1.AddDepartment(dept2);
        company2.AddDepartment(dept3);
		
        // Displaying company structure
        company1.DisplayCompany();
		Console.WriteLine(new string('-', 30));
		company2.DisplayCompany();
    }
}
