using System;
class Grades{
	static void Main(string[] args){
		Console.Write("Enter marks in Physics out of 100: ");	
		double phy = Convert.ToDouble(Console.ReadLine());	//taking physics marks as input from user
		Console.Write("Enter marks in Chemistry out of 100: ");	
		double chem = Convert.ToDouble(Console.ReadLine());	//taking chemistry marks as input from user
		Console.Write("Enter marks in Maths out of 100: ");	
		double maths = Convert.ToDouble(Console.ReadLine());	//taking mathematics marks as input from user
		double percent = ((phy + chem + maths)/300.0)*100;	//calculation of percentage
		char grade;
		string remarks;
		if(percent >= 80){	//grade A criteria
			grade = 'A';
			remarks = "Level 4, above agency-normalised standards!";
		}
		else if(percent >= 70 && percent < 80){	//grade B criteria
			grade = 'B';
			remarks = "Level 3, at agency-normalised standards!";
		}
		else if(percent >= 60 && percent < 70){	//grade C criteria
			grade = 'C';
			remarks = "Level 2, below, but approaching agency-normalised standards!";
		}
		else if(percent >= 50 && percent < 60){	//grade D criteria
			grade = 'D';
			remarks = "Level 1, well below agency-normalised standards!";
		}
		else if(percent >= 40 && percent < 50){	//grade E criteria
			grade = 'E';
			remarks = "Level 1-, too below agency-normalised standards!";
		}
		else{	//R grade for percent<40
			grade = 'R';
			remarks = "Remedial standards!";
		}
		Console.WriteLine("The percentage is {0}, grade is {1} and remark is {2}",percent,grade,remarks);	//printing the percentage, grade and remark
	}
}
			