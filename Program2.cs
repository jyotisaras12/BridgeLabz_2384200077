using System;
using System.Collections.Generic;

//creating 'Bank' class
class Bank{
    public string name { get; private set; }
    private List<Account> accounts;
    
	//constructor to initialise Bank details
    public Bank(string name){
        this.name = name;
        accounts = new List<Account>();
    }
    
	//method to open an account in the bank
    public void OpenAccount(Customer customer, decimal initialDeposit){
        Account newAccount = new Account(customer, initialDeposit, this);
        accounts.Add(newAccount);
        customer.AddAccount(newAccount);
    }
}

//creating 'Customer' class
class Customer{
    public string name { get; private set; }
    private List<Account> accounts;
    
	//contructor to initialise Customer details
    public Customer(string name){
        this.name = name;
        accounts = new List<Account>();
    }
    
	//method to add an account 
    public void AddAccount(Account account){
        accounts.Add(account);
    }
    
	//method to view balance
    public void ViewBalance(){
        Console.WriteLine("Bank details for {0}:",name);
        foreach(Account account in accounts){
            Console.WriteLine("Bank: {0} \nBalance: {1}\n", account.bank.name, account.balance);
        }
    }
}

//creating 'Account' class
class Account{
    public Customer owner { get; private set; }
    public decimal balance { get; private set; }
    public Bank bank { get; private set; }
    
    public Account(Customer owner, decimal initialDeposit, Bank bank){
        this.owner = owner;
        this.balance = initialDeposit;
        this.bank = bank;
    }
}

class Program2{
    static void Main(string[] args){
        //creating Bank object
        Bank bank1 = new Bank("State Bank of India");
		Bank bank2 = new Bank("HDFC");
		Bank bank3 = new Bank("Canara");
        
        //creating Customer objects
        Customer customer1 = new Customer("Astha");
        Customer customer2 = new Customer("Sejal");
		Customer customer3 = new Customer("Avishi");
        
        //opening accounts for customers
        bank1.OpenAccount(customer1, 2500);
		bank2.OpenAccount(customer1, 1500);
        bank1.OpenAccount(customer2, 1000);
		bank3.OpenAccount(customer3, 2000);
        
        //viewing balances
        customer1.ViewBalance();
        customer2.ViewBalance();
		customer3.ViewBalance();
    }
}
