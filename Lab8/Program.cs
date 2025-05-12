using System;

// Step 1
class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Step 2
class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 3
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();
        
        
        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();
    }
}