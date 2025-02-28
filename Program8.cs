using System;
using System.Collections.Generic;

//creating 'Course' class
class Course{
    public string courseName { get; private set; }
    public Professor assignedProfessor { get; private set; }
    private List<Student> enrolledStudents;

	//constructor to initialise Course details
    public Course(string courseName){
        this.courseName = courseName;
        enrolledStudents = new List<Student>();
    }

    //method to assign a professor to the course
    public void AssignProfessor(Professor professor){
        this.assignedProfessor = professor;
        professor.AssignCourse(this);
    }

    //method to enroll a student in the course
    public void EnrollStudent(Student student){
        enrolledStudents.Add(student);
        student.EnrollInCourse(this);
    }

    //method to display course details
    public void DisplayCourse(){
        Console.WriteLine("\nCourse: {0}",courseName);
		if(assignedProfessor != null) Console.WriteLine("Professor: {0}",assignedProfessor.name);
		else Console.WriteLine("Not Assigned");
        Console.WriteLine("Enrolled Students:");
        if(enrolledStudents.Count == 0) Console.WriteLine("No students enrolled.");
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
    private List<Course> courses;

	//constructor to initialise Student details
    public Student(string name){
        this.name = name;
        courses = new List<Course>();
    }

    //method to enroll in a course
    public void EnrollInCourse(Course course){
        if (!courses.Contains(course)) courses.Add(course);
    }

    //method to display enrolled courses
    public void DisplayEnrolledCourses(){
        Console.WriteLine("\nStudent: {0}",name);
        Console.WriteLine("Enrolled Courses:");
        if(courses.Count == 0) Console.WriteLine("No courses enrolled.");
        else{
            foreach(Course course in courses){
                Console.WriteLine("- "+course.courseName);
			}
		}
    }
}

//creating 'Professor' class
class Professor{
    public string name { get; private set; }
    private List<Course> courses;

	//constructor to initialise Professor details
    public Professor(string name){
        this.name = name;
        courses = new List<Course>();
    }

    //method to assign professor to a course
    public void AssignCourse(Course course){
        if(!courses.Contains(course)) courses.Add(course);
    }

    //method to display courses taught by the professor
    public void DisplayAssignedCourses(){
        Console.WriteLine("\nProfessor: {0}",name);
        Console.WriteLine("Courses Teaching:");
        if(courses.Count == 0) Console.WriteLine("No courses assigned.");
        else{
            foreach(Course course in courses){
                Console.WriteLine("- "+course.courseName);
			}
		}
    }
}

//creating 'University' class
class University{
    public string universityName { get; private set; }
    private List<Course> courses; 

	//constructor to initialise University details
    public University(string universityName){
        this.universityName = universityName;
        courses = new List<Course>();
    }

    //method to adding course to university
    public void AddCourse(Course course){
        courses.Add(course);
    }

    //method to display university details
    public void DisplayUniversity(){
        Console.WriteLine("\nUniversity: {0}",universityName);
        Console.WriteLine("Courses Offered:");
        if(courses.Count == 0) Console.WriteLine("No courses available.");
        else{
            foreach(Course course in courses){
                course.DisplayCourse();
			}
		}
    }
}

class Program8{
    static void Main(string[] args){
        //creating University object
        University university = new University("GLA University");

        //creating Professor objects
        Professor prof1 = new Professor("Dr. Rohit Agrawal");
        Professor prof2 = new Professor("Dr. Mukesh Jangid");

        //creating Course objects
        Course course1 = new Course("Computer Science Engineering");
        Course course2 = new Course("Business Administration");
        Course course3 = new Course("Civil Engineering");

        //assigning Professors to Courses
        course1.AssignProfessor(prof1);
        course2.AssignProfessor(prof2);
        course3.AssignProfessor(prof1);

        //adding courses to the University
        university.AddCourse(course1);
        university.AddCourse(course2);
        university.AddCourse(course3);

        //create Student objects
        Student stud1 = new Student("Avishi");
        Student stud2 = new Student("Sejal");

        //students enrolling in Courses
        course1.EnrollStudent(stud1);
        course1.EnrollStudent(stud2);
        course2.EnrollStudent(stud1);
        course3.EnrollStudent(stud2);

        //displaying University Details
        university.DisplayUniversity();
		Console.WriteLine(new string('-', 40));

        //displaying Student Enrollment
        stud1.DisplayEnrolledCourses();
        stud2.DisplayEnrolledCourses();
		Console.WriteLine(new string('-', 40));

        //displaying Professor Assignments
        prof1.DisplayAssignedCourses();
        prof2.DisplayAssignedCourses();
    }
}

