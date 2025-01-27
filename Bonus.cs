using System;
class Bonus{
    static void Main(){
        int numEmployees = 10;	
        //creating arrays to store salary, years of service, bonus, and new salary for each employee
        double[] salaries = new double[numEmployees];
        double[] yearsOfService = new double[numEmployees];
        double[] bonuses = new double[numEmployees];
        double[] newSalaries = new double[numEmployees];
        //declaring variables to store total bonus, total old salary, and total new salary
        double totalBonus = 0.0;
        double totalOldSalary = 0.0;
        double totalNewSalary = 0.0;
        //iterating from 0 to numEmployees-1 to get input from the user
        for (int i = 0; i < numEmployees; i++){
            Console.WriteLine("Enter details for employee {0}:",i + 1);
            //getting salary and checking for positive values
            double salary;
            do{
                Console.Write("Enter salary: ");
                salary = Convert.ToDouble(Console.ReadLine());
            } while(salary <= 0);
            //getting years of service and cheking for positive values
            double years;
            do{
                Console.Write("Enter years of service: ");
                years = Convert.ToDouble(Console.ReadLine());
            } while(years < 0);
            salaries[i] = salary;	//storing salary
            yearsOfService[i] = years;	//storing years of service
			//calculation of bonus
            bonuses[i] = (years > 5) ? salary * 0.05 : salary * 0.02;
			//calculation of new salary
            newSalaries[i] = salary + bonuses[i];
            //calculation of total bonus, old salary and new salary
            totalBonus += bonuses[i];
            totalOldSalary += salary;
            totalNewSalary += newSalaries[i];
        }
		//printing the output for each employee
        Console.WriteLine("Employee Bonus and Salary Details:");
        for(int i = 0; i < numEmployees; i++){
            Console.WriteLine("Employee {0}:",i + 1);
            Console.WriteLine("Old Salary: {0}",salaries[i]);
            Console.WriteLine("Years of Service: {0}",yearsOfService[i]);
            Console.WriteLine("Bonus: {0}",bonuses[i]);
            Console.WriteLine("New Salary: {0}",newSalaries[i]);
        }
		//printing the total bonus and salary calculations
        Console.WriteLine("Total Bonus and Salary Details:");
        Console.WriteLine("Total Bonus: {0}",totalBonus);
        Console.WriteLine("Total Old Salary: {0}",totalOldSalary);
        Console.WriteLine("Total New Salary: {0}",totalNewSalary);
    }
}
