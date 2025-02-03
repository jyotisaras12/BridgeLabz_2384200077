using System;
class Person{
    //declaring fields
    public string Name { get; set; }
    public int Age { get; set; }

    //default constructor
    public Person(){
        Name = "Bhaskar";
        Age = 24;
    }

    //parameterized constructor
    public Person(string name, int age){
        Name = name;
        Age = age;
    }

    //copy constructor
    public Person(Person otherPerson){
        Name = otherPerson.Name;  
        Age = otherPerson.Age;
    }

    //method to display person's information
    public void DisplayPersonInfo(){
        Console.WriteLine("Name: {0}\nAge: {1}", Name, Age);
    }
}

class Program3{
    static void Main(string[] args){
		//using the default constructor
        Person person1 = new Person();
        Console.WriteLine("Person 1:");
        person1.DisplayPersonInfo(); 
		
        //using the parameterized constructor
        Person person2 = new Person("Ashish", 35);
        Console.WriteLine("Person 2:");
        person2.DisplayPersonInfo();

        //using the copy constructor
        Person person3 = new Person(person2);
        Console.WriteLine("Person 3 (copy of Person 2):");
        person3.DisplayPersonInfo();
    }
}
