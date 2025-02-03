using System;
class BankAccount{
    //instance variables 
    public string AccountNumber { get; set; }    
    protected string AccountHolder { get; set; } 
    private double Balance { get; set; }        

    //constructor to initialize bank account details
    public BankAccount(string accountNumber, string accountHolder, double initialBalance){
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    //public method to access balance (getter)
    public double GetBalance(){
        return Balance;
    }

    //public method to modify balance (setter)
    public void Deposit(double amount){
        if (amount > 0) Balance += amount;
        else Console.WriteLine("Deposit amount must be positive.");
    }

    //method to display account details
    public void DisplayAccountDetails(){
        Console.WriteLine("Account Number: {0}\nAccount Holder: {1}\nBalance: {2}",AccountNumber, AccountHolder, Balance);
    }
}

class SavingsAccount : BankAccount{
    //instance variable for SavingsAccount
    public double InterestRate { get; set; } 

    //constructor to initialize SavingsAccount details
    public SavingsAccount(string accountNumber, string accountHolder, double initialBalance, double interestRate)
        : base(accountNumber, accountHolder, initialBalance){
        InterestRate = interestRate;
    }

    //method to calculate interest on the balance
    public double CalculateInterest(){
        return GetBalance() * (InterestRate / 100);
    }

    //method to display SavingsAccount details
    public void DisplaySavingsAccountDetails(){
		Console.WriteLine("Account Number: {0}\nAccount Holder: {1}\nBalance: {2}\nInterest Rate: {3}\nInterest: {4}",AccountNumber, AccountHolder, GetBalance(), InterestRate, CalculateInterest());
    }
}

class Program12{
    static void Main(string[] args){
        //creating a BankAccount object
        BankAccount bankAccount = new BankAccount("123456", "Bhaskar", 5000.0);
        Console.WriteLine("Bank Account Details:");
        bankAccount.DisplayAccountDetails();

        //modifying the balance 
        bankAccount.Deposit(500.0);
        Console.WriteLine("Updated Bank Account Details:");
        bankAccount.DisplayAccountDetails();

        //creating a SavingsAccount object
        SavingsAccount savingsAccount = new SavingsAccount("123234", "Akash", 4000.0, 5.0);
        Console.WriteLine("\nSavings Account Details:");
        savingsAccount.DisplaySavingsAccountDetails();
    }
}
