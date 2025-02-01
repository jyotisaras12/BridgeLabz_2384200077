using System;
class StudentVoteChecker{
    //method to check if a student is eligible to vote or not
    public bool CanStudentVote(int age){
        //checking if the age is a negative number
        if(age < 0) return false; //negative age is invalid
        else if(age >= 18) return true; //eligible to vote
        else return false; //not eligible to vote
	}
	//Main method
	static void Main(string[] args){
        //defining 'studentAges' array to store the ages of 10 students
        int[] studentAges = new int[10];
		
		//instantiation of 'StudentVoteChecker' class
		StudentVoteChecker voteChecker = new StudentVoteChecker();

        //iterating through the array to take age as input
        for (int i = 0; i < 10; i++){
			Console.Write("Enter the age of student {0}: ",i + 1);
			studentAges[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		//iterating through the array to check if student is eligible to vote or not
		for (int i = 0; i < 10; i++){
			if(voteChecker.CanStudentVote(studentAges[i])) Console.WriteLine("Student {0} can vote.",i + 1);
            else Console.WriteLine("Student {0} cannot vote.",i + 1);
		}
	}
}
        