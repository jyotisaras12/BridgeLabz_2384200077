using System;

//creating interface: Worker
interface Worker{
    void PerformDuties();
}

//creating base class: Person
class Person{
    public string name { get; set; }
    public int id { get; set; }

	//constructor
    public Person(string name, int id){
        this.name = name;
        this.id = id;
    }

	//method to display role
    public virtual void DisplayRole()
    {
        Console.WriteLine("Normal Person");
    }
}

//creating subclass: Chef
class Chef : Person, Worker{
    private string specialty { get; set; }

	//constructor
    public Chef(string name, int id, string specialty)
        : base(name, id){
        this.specialty = specialty;
    }

	//method to display role
    public override void DisplayRole(){
        Console.WriteLine("Chef: {0}\nID: {1}\nSpecialty: {2}", name, id, specialty);
    }

	//method to show duties
    public void PerformDuties(){
        Console.WriteLine("Cooking food.");
    }
}

//creating subclass: Waiter
class Waiter : Person, Worker{
    private int tablesAssigned { get; set; }

	//constructor
    public Waiter(string name, int id, int tablesAssigned)
        : base(name, id){
        this.tablesAssigned = tablesAssigned;
    }

	//method to display role
    public override void DisplayRole()
    {
        Console.WriteLine("Waiter: {0}\nID: {1}\nTables Assigned: {2}", name, id, tablesAssigned);
    }

	//method to show duties
    public void PerformDuties(){
        Console.WriteLine("Serving food to customers.");
    }
}

class Program10{
    static void Main(string[] args){
		//creating objects for 'Chef' and 'Waiter' classes
        Chef chef = new Chef("Aman", 123, "Chinese Food");
        Waiter waiter = new Waiter("Veena", 234, 4);

		//displaying roles and duties
        chef.DisplayRole();
        chef.PerformDuties();
        Console.WriteLine();
        
        waiter.DisplayRole();
        waiter.PerformDuties();
    }
}
