// See https://aka.ms/new-console-template for more information

/*
interface: arayüz, abstraction (soyutlama) yapmamızı sağlayan bir diğer yöntemdir
interface içerisinde sadece imza tanımlanır, gövde tanımlanmaz, tamamiyle abstract class gibidir
*/

// Interface
interface IAnimal {
  void animalSound(); // interface method (does not have a body)
}

class Cat : IAnimal {
  public void animalSound()   {
    // The body of animalSound() is provided here
    Console.WriteLine("The cat says: miav miav");
  }
}

class Program {
  static void Main(string[] args)   {
    Pig myCat = new Cat();
    myCat.animalSound();
  }
}

//------------------------------------------------------------
// multiple interface
/*
interface IFirstInterface {
  void myMethod(); // interface method
}

interface ISecondInterface {
  void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface {
  public void myMethod()   {
    Console.WriteLine("Some text..");
  }
  public void myOtherMethod()   {
    Console.WriteLine("Some other text...");
  }
}

class Program {
  static void Main(string[] args)   {
    DemoClass myObj = new DemoClass();
    myObj.myMethod();
    myObj.myOtherMethod();
  }
}
*/