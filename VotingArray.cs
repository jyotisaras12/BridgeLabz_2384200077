using System;
class VotingArray{
	static void Main(string[] args){
		//creating 'age' array of size 10
		int[] age = new int[10];	
		
		//iterating from 0 to the largest index of array
		for(int i = 0; i < age.Length; i++){	
			Console.Write("Enter age of student {0}: ",i+1);	
			//taking age of students as input from user
			age[i] = Convert.ToInt32(Console.ReadLine());	
		}
		//iterating through array to check voting eligibility of students
		foreach(int studentAge in age){	
			if(studentAge<0) Console.WriteLine("{0} is an invalid age.",studentAge);	//checking invalid age and printing the output
			else{
				//checking if voter is eligible to vote or not and printing the output
				if(studentAge >= 18) Console.WriteLine("The Student with age {0} is eligible to vote.",studentAge);
				else Console.WriteLine("The Student with age {0} is not eligible to vote.",studentAge);
			}
		}
	}
}