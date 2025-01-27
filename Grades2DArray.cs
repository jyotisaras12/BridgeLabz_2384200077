using System;
class Grades2DArray{
    static void Main(){
        //taking number of students as input from user
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());
        //creating arrays to store marks, percentages, and grades
        double[,] marks = new double[numStudents, 3];
        double[] percents = new double[numStudents];
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
			//storing the marks in 2D arrays
            marks[i, 0] = physics;
            marks[i, 1] = chemistry;
            marks[i, 2] = maths;

			//calculation of percentage
            percents[i] = (physics + chemistry + maths) / 3;
            //calculation of grade
            if(percents[i] >= 80) grades[i] = "A";
			else if(percents[i] >= 70 && percents[i] < 80) grades[i] = "B";
			else if(percents[i] >= 60 && percents[i] < 70) grades[i] = "C"; 
			else if(percents[i] >= 50 && percents[i] < 60) grades[i] = "D";
			else if(percents[i] >= 40 && percents[i] < 50) grades[i] = "E";
			else grades[i] = "R";
        }
		//printing the results
        Console.WriteLine("Student Results:");
        for(int i = 0; i < numStudents; i++){
            Console.WriteLine("Student {0}:",i + 1);
            Console.WriteLine("Physics Marks: {0}",marks[i, 0]);
            Console.WriteLine("Chemistry Marks: {0}",marks[i, 1]);
            Console.WriteLine("Maths Marks: {0}",marks[i, 2]);
            Console.WriteLine("Percentage: {0}%",percents[i]);
            Console.WriteLine("Grade: {0}",grades[i]);
        }
    }
}
