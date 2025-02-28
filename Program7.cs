using System;

//creating base class: Course
class Course{
    private string courseName { get; set; }
    private int duration { get; set; } //duration in weeks

	//constructor
    public Course(string courseName, int duration){
        this.courseName = courseName;
        this.duration = duration;
    }

	//method to display information
    public virtual void DisplayInfo(){
        Console.WriteLine("Course: {0}\nDuration: {1} weeks", courseName, duration);
    }
}

//creating subclass: OnlineCourse
class OnlineCourse : Course{
    private string platform { get; set; }
    private bool isRecorded { get; set; }

	//constructor
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration){
        this.platform = platform;
        this.isRecorded = isRecorded;
    }

	//method to display information
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Platform: {0}\nRecorded: {1}", platform, isRecorded);
    }
}

//creating subclass: PaidOnlineCourse
class PaidOnlineCourse : OnlineCourse{
    private double fee { get; set; }
    private double discount { get; set; }

	//constructor
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) 
        : base(courseName, duration, platform, isRecorded){
        this.fee = fee;
        this.discount = discount;
    }
	
	//method to display information
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Fee: {0}\nDiscount: {1}%", fee, discount);
    }
}

class Program7{
    static void Main(string[] args){
		//creating objects for 'Course', 'OnlineCourse' and 'PaidOnlineCourse' classes
        Course course = new Course("Introduction to C# Programming", 5);
        OnlineCourse onlineCourse = new OnlineCourse("Web Development", 10, "Udemy", true);
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("Advanced C#", 10, "Coursera", false, 499, 10);

		//displaying information
        course.DisplayInfo();
        Console.WriteLine();
        
        onlineCourse.DisplayInfo();
        Console.WriteLine();
        
        paidCourse.DisplayInfo();
    }
}
