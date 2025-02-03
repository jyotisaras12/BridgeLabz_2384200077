using System;
class Student{
    //instance variables
    public int RollNumber { get; set; }   
    protected string Name { get; set; }       
    private double CGPA { get; set; }      

    //constructor to initialize student details
    public Student(int rollNumber, string name, double cgpa){
        RollNumber = rollNumber;
        Name = name;
        CGPA = cgpa;
    }

    //public method to access CGPA (getter)
    public double GetCGPA(){
        return CGPA;
    }

    //public method to modify CGPA (setter)
    public void SetCGPA(double cgpa){
            CGPA = cgpa;
    }

    //method to display student details
    public void DisplayStudentDetails(){
        Console.WriteLine("Roll Number: {0}\nName: {1}\nCGPA: {2}",RollNumber, Name, CGPA);
    }
}

class PostgraduateStudent : Student{
    //instance variable for postgraduate student
    public string ThesisTitle { get; set; }

    //constructor to initialize postgraduate student details
    public PostgraduateStudent(int rollNumber, string name, double cgpa, string thesisTitle)
        : base(rollNumber, name, cgpa){
        ThesisTitle = thesisTitle;
    }

    //method to display postgraduate student details
    public void DisplayPostgraduateDetails(){
        //accessing the protected member 'Name' from the parent class
        Console.WriteLine("Roll Number: {0}\nName: {1}\nCGPA: {2}\nThesis Title: {3}",RollNumber, Name,GetCGPA(), ThesisTitle);
    }
}

class Program10{
    static void Main(string[] args){
        //creating a Student object
        Student student = new Student(101, "Akash", 7.8);
        Console.WriteLine("Student Details:");
        student.DisplayStudentDetails();

        //modifying CGPA using public methods
        student.SetCGPA(8.3);
        Console.WriteLine("Updated Student Details:");
        student.DisplayStudentDetails();

        //creating a PostgraduateStudent object
        PostgraduateStudent pgStudent = new PostgraduateStudent(102, "Ashima", 8.8, "Machine Learning Research");
        Console.WriteLine("Postgraduate Student Details:");
        pgStudent.DisplayPostgraduateDetails();
    }
}
