// See https://aka.ms/new-console-template for more information

/*
poly: çok
morph: şekil
polymorphizm, çok biçimlilik, miras kavramı ile yakından ilgilidir

*/
class Animal { // Base class (parent) 
  public void animalSound()   {
    Console.WriteLine("The animal makes a sound");
  }
}

class Cat : Animal { // Derived class (child) 
  public void animalSound()   {
    Console.WriteLine("The Cat says: wee wee");
  }
}

class Dog : Animal { // Derived class (child) 
  public void animalSound()   {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program {
  static void Main(string[] args)   {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myCat = new Cat();  // Create a Cat object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myCat.animalSound();
    myDog.animalSound();
  }
}
/*
The output will be:

The animal makes a sound
The animal makes a sound
The animal makes a sound

*/

// ------------------------------------------------------------
// sorunu düzeltelim
/*
class Animal { // Base class (parent) 
  public virtual void animalSound()   {
    Console.WriteLine("The animal makes a sound");
  }
}

class Cat : Animal { // Derived class (child) 
  public override void animalSound()   {
    Console.WriteLine("The Cat says: wee wee");
  }
}

class Dog : Animal { // Derived class (child) 
  public override void animalSound()   {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program {
  static void Main(string[] args)   {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myCat = new Cat();  // Create a Cat object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myCat.animalSound();
    myDog.animalSound();
  }
}

/*
The output will be:

The animal makes a sound
The Cat says: wee wee
The dog says: bow wow
*/

*/