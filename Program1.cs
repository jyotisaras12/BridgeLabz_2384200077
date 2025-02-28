using System;

//creating 'superclass': Animal
class Animal{
    public string name { get; set; }
    public int age { get; set; }

	//constructor to initialise Animal details
    public Animal(string name, int age){
        this.name = name;
        this.age = age;
    }

	//method 'MakeSound()'
    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound.");
    }
}

//creating 'subclass': Dog
class Dog : Animal{
    public Dog(string name, int age) : base(name, age) { }
	
	//method to override 'MakeSound()' in Animal class
    public override void MakeSound(){
        Console.WriteLine("Dog barks.");
    }
}

//creating 'subclass': Cat
class Cat : Animal{
    public Cat(string name, int age) : base(name, age) { }

	//method to override 'MakeSound()' in Animal class
    public override void MakeSound(){
        Console.WriteLine("Cat meows.");
    }
}

//creating 'subclass': Bird
class Bird : Animal{
    public Bird(string name, int age) : base(name, age) { }

	//method to override 'MakeSound()' in Animal class
    public override void MakeSound(){
        Console.WriteLine("Bird chirps.");
    }
}

class Program1{
    static void Main(string[] args){
		//creating objects for 'Dog', 'Cat' and 'Bird' class referencing 'Animal' class
        Animal dog = new Dog("Tommy", 3);
        Animal cat = new Cat("Kitty", 2);
        Animal bird = new Bird("Angel", 1);

        dog.MakeSound(); 
        cat.MakeSound(); 
        bird.MakeSound(); 
    }
}
