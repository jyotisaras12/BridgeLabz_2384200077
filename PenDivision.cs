using System;
class PenDivision{
	static void Main(string[] args){
		int pen = 14;	//given number of pens
		int students = 3;	//given no. of students
		int penPerStudent = pen/students;	//calculation of no. of pens per student
		int penRemaining = pen % students;	//calculation of remaining undistributed pens
		Console.WriteLine("The pen per student is {0} and the remaining pen not distributed is {1}",penPerStudent,penRemaining);
	}
}