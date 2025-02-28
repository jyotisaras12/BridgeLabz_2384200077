using System;

//creating base class: Person
class Person{
    public string name { get; set; }
    public int age { get; set; }

	//constructor
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }

	//method to display role
    public virtual void DisplayRole(){
        Console.WriteLine("General Person");
    }
}

//creating subclass: Teacher
class Teacher : Person{
    private string subject { get; set; }

	//constructor
    public Teacher(string name, int age, string subject)
        : base(name, age){
        this.subject = subject;
    }

	//method to display role
    public override void DisplayRole(){
        Console.WriteLine("Teacher: {0}\nAge: {1}\nSubject: {2}", name, age, subject);
    }
}

//creating subclass: Student
class Student : Person{
    private int grade { get; set; }

	//constructor
    public Student(string name, int age, int grade)
        : base(name, age){
        this.grade = grade;
    }

    //method to display role
	public override void DisplayRole(){
        Console.WriteLine("Student: {0}\nAge: {1}\nGrade: {2}", name, age, grade);
    }
}

//creating subclass: Staff
class Staff : Person{
    private string position { get; set; }

	//constructor
    public Staff(string name, int age, string position)
        : base(name, age){
        this.position = position;
    }

	//method to display role
    public override void DisplayRole(){
        Console.WriteLine("Staff: {0}\nAge: {1}\nPosition: {2}", name, age, position);
    }
}

class Program9{
    static void Main(string[] args){
		//creating objects for 'Teacher', 'Student' and 'Staff' classes
        Teacher teacher = new Teacher("Ms. Anamika", 37, "Computer Science");
        Student student = new Student("Rishi", 17, 11);
        Staff staff = new Staff("Mr. Nandan", 45, "Clerk");

		//displaying roles
        teacher.DisplayRole();
        Console.WriteLine();
        
        student.DisplayRole();
        Console.WriteLine();
        
        staff.DisplayRole();
    }
}
