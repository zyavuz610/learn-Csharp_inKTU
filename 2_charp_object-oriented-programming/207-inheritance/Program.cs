// See https://aka.ms/new-console-template for more information

class Vehicle { // base class (parent)
// sealed class Vehicle { // sealed class, bu sınıftan türetilen sınıflar oluşturulamaz 
  public string brand = "Ford";  // Vehicle field
  public void honk()  {            // Vehicle method 
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle { // derived class (child)
  public string modelName = "Mustang";  // Car field
}

class Program {
  static void Main(string[] args)   {
    Car myCar = new Car();

    myCar.honk();

    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}

/*
örneğin;
base class: Takim
derived class: FutbolTakimi
derived class: BasketbolTakimi
derived class: VoleybolTakimi

*/