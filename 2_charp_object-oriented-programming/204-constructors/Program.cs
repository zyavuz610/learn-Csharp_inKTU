// See https://aka.ms/new-console-template for more information
class Car {
    public string model;  // Create a field
    public string color;
    public int year;

    // Create a class constructor for the Car class
    public Car()   {
        model = "Mustang"; // Set the initial value for model
    }

    public Car(string modelName)   { // constructor overloading, parametreli constructor
        model = modelName;
    }

    public Car(string modelName, string modelColor, int modelYear)   { // constructor overloading, parametreli constructor
        model = modelName;
        color = modelColor;
        year = modelYear;
    }

    static void Main(string[] args)   {
        Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
        Console.WriteLine(Ford.model);  // Print the value of model

        Car Opel = new Car("Astra");
        Console.WriteLine(Opel.model);

        Car Opel2 = new Car("Astra", "white", 2005);
        Console.WriteLine("Marka: " + Opel2.model);
        Console.WriteLine("Renk: " + Opel2.color);
        Console.WriteLine("Yıl: " + Opel2.year);
    }
}
