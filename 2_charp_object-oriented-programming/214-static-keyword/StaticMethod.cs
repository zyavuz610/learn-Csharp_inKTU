public class StaticMethod {
    public static void Main()     {
        StaticClass.Print();
        // StaticMethod.Print(); // hata verir
    }
    public void Print()     {
        Console.WriteLine("StaticMethod.Print()");
        Print2();
    }
    public static void Print2()     {
        Console.WriteLine("StaticMethod.Print2()");
    }
}