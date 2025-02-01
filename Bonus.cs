using System;
class Bonus{
    //method to generate salary and years of service for employees
    public static double[,] GenerateEmployees(int count){
        Random random = new Random();
        double[,] employees = new double[count, 2]; 

        for (int i = 0; i < count; i++){
            employees[i, 0] = random.Next(30000, 100000); //random salary between 30k and 100k
            employees[i, 1] = random.Next(1, 11); //random years of service between 1 and 10
        }
        return employees;
    }

    //method to calculate new salary and bonus based on the given logic
    public static double[,] CalculateBonuses(double[,] employees){
        int rowCount = employees.GetLength(0);
        double[,] result = new double[rowCount, 2]; // [old salary, new salary, bonus]

        for (int i = 0; i < rowCount; i++){
            double salary = employees[i, 0];
            double years = employees[i, 1];
            double bonus = (years > 5) ? salary * 0.05 : salary * 0.02;
            double newSalary = salary + bonus;
            result[i, 0] = newSalary;
            result[i, 1] = bonus;
        }
        return result;
    }

    //method to calculate the total old salary, new salary, and total bonus
    public static void CalculateTotals(double[,] results, double[,] emp){
        double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;

        Console.WriteLine("Employee\tOld Salary\tYears of Service\tBonus\t\tNew Salary");

        for (int i = 0; i < results.GetLength(0); i++){
            double oldSalary = emp[i, 0];
            double newSalary = results[i, 0];
            double bonus = results[i, 1];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine("{0}\t\t{1:F2}\t\t{2}\t\t{3:F2}\t\t{4:F2}",i + 1,oldSalary,emp[i,1],bonus,newSalary);
        }

        Console.WriteLine("Total Old Salary: {0:F2}",totalOldSalary);
        Console.WriteLine("Total New Salary: {0:F2}",totalNewSalary);
        Console.WriteLine("Total Bonus: {0:F2}",totalBonus);
    }

	//Main method
    static void Main(string[] args){
        const int employeeCount = 10;
		//printing the output
        double[,] employees = GenerateEmployees(employeeCount); //generating salary and years data
        double[,] results = CalculateBonuses(employees); //calculation of bonuses and new salary
        CalculateTotals(results,employees); //printing results and totals
    }
}
