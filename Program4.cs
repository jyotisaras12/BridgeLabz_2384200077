using System;
using System.Collections.Generic;

//creating an abstract class 'BankAccount'
abstract class BankAccount {
    protected string accountNumber;
    protected string holderName;
    protected double balance;

    //constructor to initialize bank account details
    public BankAccount(string accountNumber, string holderName, double balance) {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    //method to deposit money
    public void Deposit(double amount) {
        if(amount > 0) balance += amount; 
		else Console.WriteLine("Invalid deposit amount!");
    }

    //method to withdraw money
    public void Withdraw(double amount) {
        if (amount > 0 && amount <= balance) {
            balance -= amount;
        } else {
            Console.WriteLine("Insufficient balance!");
        }
    }

    //abstract method to calculate interest
    public abstract double CalculateInterest();

    //method to display account details
    public virtual void DisplayDetails() {
        Console.WriteLine("Account Details:\nAccount Number: {0}\nHolder Name: {1}\nBalance: {2}", accountNumber, holderName, balance);
    }
}

//creating interface for loanable accounts
interface ILoanable {
    double CalculateLoanEligibility();
}

//creating 'SavingsAccount' class inheriting from BankAccount and implementing ILoanable
class SavingsAccount : BankAccount, ILoanable {
    private double interestRate = 0.04; // 4% interest rate

    //constructor to initialize SavingsAccount details
    public SavingsAccount(string accountNumber, string holderName, double balance) 
        : base(accountNumber, holderName, balance) { }

    //method to calculate interest for savings account
    public override double CalculateInterest() {
        return balance * interestRate;
    }

    //method to calculate loan eligibility
    public double CalculateLoanEligibility() {
        return balance * 2; //loan eligibility is twice the balance
    }
}

//creating 'CurrentAccount' class inheriting from BankAccount
class CurrentAccount : BankAccount {
    //constructor to initialize CurrentAccount details
    public CurrentAccount(string accountNumber, string holderName, double balance) 
        : base(accountNumber, holderName, balance) { }

    //method to calculate interest for current account(no interest)
    public override double CalculateInterest() {
        return 0;
    }
}

class Program {
    public static void Main(string[] args) {
        //creating a list of bank accounts
        List<BankAccount> accounts = new List<BankAccount>();

        //adding a savings account
        SavingsAccount savings = new SavingsAccount("SA123", "Avishi", 15000);
        accounts.Add(savings);

        //adding a current account
        CurrentAccount current = new CurrentAccount("CA456", "Divya", 5500);
        accounts.Add(current);

        //iterating through the list to display account details, interest, and loan eligibility
        foreach(BankAccount account in accounts){
            account.DisplayDetails();
            Console.WriteLine("Interest: {0}", account.CalculateInterest());

            //checking if account is loanable
            if(account is ILoanable){
                ILoanable loanable = (ILoanable)account;
                Console.WriteLine("Loan Eligibility: {0}", loanable.CalculateLoanEligibility());
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
