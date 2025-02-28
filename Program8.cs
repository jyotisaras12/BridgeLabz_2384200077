using System;

//creating base class: BankAccount
class BankAccount{
    private string accountNumber { get; set; }
    private double balance { get; set; }

	//constructor
    public BankAccount(string accountNumber, double balance){
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

	//method to display account type
    public virtual void DisplayAccountType(){
        Console.WriteLine("General Bank Account");
    }
}

//creating subclass: SavingsAccount
class SavingsAccount : BankAccount{
    private double interestRate { get; set; }

	//constructor
    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        this.interestRate = interestRate;
    }
	
	//method to display account type
    public override void DisplayAccountType(){
        Console.WriteLine("Savings Account\nInterest Rate: {0}%",interestRate);
    }
}

//creating subclass: CheckingAccount
class CheckingAccount : BankAccount{
    private double withdrawalLimit { get; set; }

	//constructor
    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance){
        this.withdrawalLimit = withdrawalLimit;
    }

	//method to display account type
    public override void DisplayAccountType(){
        Console.WriteLine("Checking Account\nWithdrawal Limit: {0}", withdrawalLimit);
    }
}

//creating subclass: FixedDepositAccount
class FixedDepositAccount : BankAccount{
    private int depositTerm { get; set; } 

	//constructor
    public FixedDepositAccount(string accountNumber, double balance, int depositTerm)
        : base(accountNumber, balance){
        this.depositTerm = depositTerm;
    }

	//method to display account type
    public override void DisplayAccountType(){
        Console.WriteLine("Fixed Deposit Account\nDeposit Term: {0} months",depositTerm);
    }
}

class Program8{
    static void Main(string[] args){
		//creating objects for 'SavingsAccount', 'CheckingAccount' and 'FixedDepositAccount' classes
        SavingsAccount savings = new SavingsAccount("SA11111", 4500, 4.5);
        CheckingAccount checking = new CheckingAccount("CA33333", 2000, 1000);
        FixedDepositAccount fixedDeposit = new FixedDepositAccount("FD55555", 10000, 12);
		
		//displaying account details
        savings.DisplayAccountType();
        Console.WriteLine();
        
        checking.DisplayAccountType();
        Console.WriteLine();
        
        fixedDeposit.DisplayAccountType();
    }
}
