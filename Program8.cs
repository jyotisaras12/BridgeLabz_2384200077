using System;
class Course{
    //instance variables
    public string CourseName { get; set; }
    public int Duration { get; set; }  
    public double Fee { get; set; }    

    //class variable 
    public static string InstituteName { get; set; } 
	
	//static constructor to initialize the static field
    static Course(){
        InstituteName = "GLA University"; 
    }

    //constructor to initialize the course details
    public Course(string courseName, int duration, double fee){
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }

    //method to display course details
    public void DisplayCourseDetails(){
        Console.WriteLine("Course Name: {0}\nDuration: {1} days\nFee: ${2}\nInstitute: {3}",CourseName, Duration, Fee, InstituteName);
        Console.WriteLine();
    }

    //method to update the institute name for all courses
    public static void UpdateInstituteName(string newName){
        InstituteName = newName;
    }
}

class Program8{
    static void Main(string[] args){
        //creating course objects
        Course course1 = new Course(".NET Full Stack", 120, 1000);
        Course course2 = new Course("Machine Learning", 250, 2500);

        //displaying course details
        Console.WriteLine("Course Details:");
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();

        //updating the institute name
        Course.UpdateInstituteName("University Of Delhi");

        //displaying course details after changing institute name
        Console.WriteLine("Course Details (After updating Institute Name):");
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}
