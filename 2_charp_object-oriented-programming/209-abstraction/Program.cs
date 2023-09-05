// See https://aka.ms/new-console-template for more information

/*
Abstract Class ve Abstract Method
Abstract Class: soyut sınıf, abstract anahtar kelimesi ile tanımlanır
Abstract Method: soyut metot, abstract anahtar kelimesi ile tanımlanır

abstract sınıftan nesne oluşturulamaz
abstract methodun gövdesi olmaz, sadece imzası olur, ayrıca sadece abstract sınıflarda tanımlanabilir
abstract sınıfta abstract olmayan metotlar da tanımlanabilir    
*/
abstract class Animal {
  public abstract void animalSound(); // abstract method (does not have a body)
  public void sleep()   {
    Console.WriteLine("Zzz");
  }
}

class Cat : Animal {
  public override void animalSound() {
    // The body of animalSound() is provided here
    Console.WriteLine("The Cat says: wee wee");
  }
}

class Program {
  static void Main(string[] args)   {
    // Animal myObj = new Animal(); // Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')
    Cat myCat = new Cat(); // Create a Cat object
    myCat.animalSound();  // Call the abstract method
    myCat.sleep();  // Call the regular method
  }
}

/*
base class içerisinde virtual metot tanımlandığında, 
    derived class içerisinde override edilmesi zorunludur
    base class tan nesne oluşturulabilir

base class abstract olarak tanımlandığında, 
    derived class içerisinde override edilmesi zorunludur
    base class tan nesne oluşturulamaz

abstraction ve polymorphizm birlikte kullanılır
bir diğer yöntem ise interface lerdir, bir sonraki bölümde anlatılacak
*/