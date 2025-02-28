using System;
using System.Collections.Generic;

//creating 'Course' class
class Course{
    public string courseName { get; private set; }
    private List<Student> enrolledStudents; 

	//constructor to initialise Course details
    public Course(string courseName){
        this.courseName = courseName;
        enrolledStudents = new List<Student>();
    }

    //method to enroll a student in the course
    public void EnrollStudent(Student student){
        if(!enrolledStudents.Contains(student)){
            enrolledStudents.Add(student);
            student.AddCourse(this);
        }
    }

    //method to display students in the course
    public void ShowStudents(){
        Console.WriteLine("\nCourse: {0}",courseName);
        if (enrolledStudents.Count == 0) Console.WriteLine("No students enrolled.");
        else{
            foreach(Student student in enrolledStudents){
                Console.WriteLine("- "+student.name);
            }
        }
    }
}

//creating 'Student' class
class Student{
    public string name { get; private set; }
    private List<Course> enrolledCourses; 
	
	//constuctor to initialise Student details
    public Student(string name){
        this.name = name;
        enrolledCourses = new List<Course>();
    }

    //method to add course to the student
    public void AddCourse(Course course){
        if(!enrolledCourses.Contains(course)) enrolledCourses.Add(course);
    }

    //method to display courses enrolled by the student
    public void ShowCourses(){
        Console.WriteLine("\nStudent: {0}",name);
        if(enrolledCourses.Count == 0) Console.WriteLine("Not enrolled in any courses.");
        else{
            foreach (Course course in enrolledCourses){
                Console.WriteLine("- "+course.courseName);
            }
        }
    }
}

//creating 'School' class
class School{
    public string schoolName { get; private set; }
    private List<Student> students;

	//constructor to initialise School details
    public School(string schoolName){
        this.schoolName = schoolName;
        students = new List<Student>();
    }

    //method to add a student to the school
    public void AddStudent(Student student){
        if (!students.Contains(student)) students.Add(student);
    }

    //method to display all students in the school
    public void ShowStudents(){
        Console.WriteLine("School: {0}",schoolName);
        if(students.Count == 0) Console.WriteLine("No students enrolled.");
        else{
            foreach (Student student in students){
                Console.WriteLine("- "+student.name);
            }
        }
    }
}

class Program4{
    static void Main(string[] args){
        //creating School objects
        School school1 = new School("Army Public School");

        //creating Student objects
        Student student1 = new Student("Jyoti");
		Student student2 = new Student("Archana");
        Student student3 = new Student("Mainak");
		Student student4 = new Student("Astha");
		Student student5 = new Student("Vishnu");

        //adding students to the schools
        school1.AddStudent(student1);
		school1.AddStudent(student2);
        school1.AddStudent(student3);
		school1.AddStudent(student4);
		school1.AddStudent(student5);

        //creating Course objects
        Course phy = new Course("Physics");
        Course chem = new Course("Chemistry");
        Course maths = new Course("Mathematics");

        //enrolling students in the courses
        phy.EnrollStudent(student1);
        phy.EnrollStudent(student2);
		phy.EnrollStudent(student5);
		chem.EnrollStudent(student2);
        chem.EnrollStudent(student3);
        chem.EnrollStudent(student4);
		maths.EnrollStudent(student2);
        maths.EnrollStudent(student5);

        //displaying School's students
        school1.ShowStudents();
		Console.WriteLine(new string('-', 50));

        //displaying students enrolled in courses
		Console.WriteLine("Students enrolled in different courses:");
        phy.ShowStudents();
        chem.ShowStudents();
        maths.ShowStudents();
		Console.WriteLine(new string('-', 50));

        //displaying courses for each student
        Console.WriteLine("Courses opted by student:");
        student1.ShowCourses();
        student2.ShowCourses();
        student3.ShowCourses();
		student4.ShowCourses();
		student5.ShowCourses();
    }
}
