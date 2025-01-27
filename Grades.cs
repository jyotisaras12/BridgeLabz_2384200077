using System;
class Grades{
    static void Main(){
        //taking number of students as input from user
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());
        //creating arrays to store marks, percentages, and grades
        double[] physicsMarks = new double[numStudents];
        double[] chemistryMarks = new double[numStudents];
        double[] mathsMarks = new double[numStudents];
        double[] percent = new double[numStudents];
        string[] grades = new string[numStudents];
		//iterating from 0 to numStudents-1 to take input for each student
        for (int i = 0; i < numStudents; i++){
            Console.WriteLine("Enter marks for student {0}:",i + 1);
            //taking marks for Physics as user input
            double physics;
			do{
                Console.Write("Enter marks for Physics (0-100): ");
                physics = Convert.ToDouble(Console.ReadLine());
                if(physics < 0 || physics > 100) Console.WriteLine("Marks should be positive and between 0 and 100.");
            } while(physics < 0 || physics > 100);

            //taking marks for Chemistry as user input
			double chemistry;
			do{
                Console.Write("Enter marks for Chemistry (0-100): ");
                chemistry = Convert.ToDouble(Console.ReadLine());
                if(chemistry < 0 || chemistry > 100) Console.WriteLine("Marks should be positive and between 0 and 100.");
            } while(chemistry < 0 || chemistry > 100);
			//taking marks for Maths as user input
			double maths;
            do{
                Console.Write("Enter marks for Maths (0-100): ");
                maths = Convert.ToDouble(Console.ReadLine());
                if(maths < 0 || maths > 100) Console.WriteLine("Marks should be positive and between 0 and 100.");
            } while(maths < 0 || maths > 100);
			//storing the marks in arrays
            physicsMarks[i] = physics;
            chemistryMarks[i] = chemistry;
            mathsMarks[i] = maths;
			//calculation of percentage
            percent[i] = (physics + chemistry + maths) / 3;
            //calculation of grade
            if(percent[i] >= 80) grades[i] = "A";
			else if(percent[i] >= 70 && percent[i] < 80) grades[i] = "B";
			else if(percent[i] >= 60 && percent[i] < 70) grades[i] = "C"; 
			else if(percent[i] >= 50 && percent[i] < 60) grades[i] = "D";
			else if(percent[i] >= 40 && percent[i] < 50) grades[i] = "E";
			else grades[i] = "R";
        }
		//printing the results
        Console.WriteLine("Student Results:");
        for(int i = 0; i < numStudents; i++){
            Console.WriteLine("Student {0}:",i + 1);
            Console.WriteLine("Physics Marks: {0}",physicsMarks[i]);
            Console.WriteLine("Chemistry Marks: {0}",chemistryMarks[i]);
            Console.WriteLine("Maths Marks: {0}",mathsMarks[i]);
            Console.WriteLine("Percentage: {0}%",percent[i]);
            Console.WriteLine("Grade: {0}",grades[i]);
        }
    }
}
