using System;
using System.Collections.Generic;

//creating 'Faculty' class 
class Faculty{
    public string name { get; private set; }

	//constructor to initialise Faculty details
    public Faculty(string name){
        this.name = name;
    }

	//method to display faculty
    public void ShowFaculty(){
        Console.WriteLine("Faculty Member: "+name);
    }
}

//creating 'Department' class
class Department{
    public string departmentName { get; private set; }

	//constructor to initialise Department details
    public Department(string departmentName){
        this.departmentName = departmentName;
    }

	//method to display departments
    public void ShowDepartment(){
        Console.WriteLine("Department: "+departmentName);
    }
}

//creating 'University' class
class University{
    public string universityName { get; private set; }
    private List<Department> departments; 
    private List<Faculty> faculties; 

	//constructor to initialise University details
    public University(string universityName){
        this.universityName = universityName;
        departments = new List<Department>();
        faculties = new List<Faculty>();
    }

    //method to add a department
    public void AddDepartment(string departmentName){
        departments.Add(new Department(departmentName));
    }

    //method to add a faculty member 
    public void AddFaculty(Faculty faculty){
        if(!faculties.Contains(faculty)) faculties.Add(faculty);
    }

    //method to display university details
    public void ShowUniversity(){
        Console.WriteLine("\nUniversity: {0}",universityName);
        Console.WriteLine("\nDepartments:");
        if(departments.Count == 0) Console.WriteLine("No departments available.");
        else{
            foreach(Department dept in departments){
                dept.ShowDepartment();
			}
		}

        Console.WriteLine("\nFaculty Members:");
        if(faculties.Count == 0) Console.WriteLine("No faculty members available.");
        else{
            foreach(Faculty faculty in faculties){
                faculty.ShowFaculty();
			}
		}
	}
	
	//method to delete university
	public void DeleteUniversity(University university){
        Console.WriteLine("\nDeleting University: "+universityName);
		university = null;
        departments.Clear();
        Console.WriteLine("All departments have been deleted.");
    }
}

class Program5{
    static void Main(string[] args){
        //creating University objects
        University university = new University("GLA University");

        //creating Faculty objects
        Faculty fac1 = new Faculty("Dr. Rohit Agrawal");
        Faculty fac2 = new Faculty("Mr. Atul Uttam");
        Faculty fac3 = new Faculty("Dr. Mukesh Jangid");

        //adding faculty members to the university
        university.AddFaculty(fac1);
        university.AddFaculty(fac2);
        university.AddFaculty(fac3);

        //adding Departments
        university.AddDepartment("Computer Science");
        university.AddDepartment("Mechanical Engineering");
        university.AddDepartment("Business Administration");

        //displaying University details
        university.ShowUniversity();

		//deleting university
        university.DeleteUniversity(university);
		
		//displayinh Faculty after deletion of university
        Console.WriteLine("\nFaculty members still exist after university deletion:");
        fac1.ShowFaculty();
        fac2.ShowFaculty();
        fac3.ShowFaculty();
    }
}
