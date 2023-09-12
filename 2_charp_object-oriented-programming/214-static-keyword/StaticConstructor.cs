public class StaticConstructor {
    static StaticConstructor()     {
        Console.WriteLine("StaticConstructor.StaticConstructor()");
    }
    StaticConstructor(int a)     {
        Console.WriteLine("StaticConstructor.non-StaticConstructor()");
    }
    public void Print()     {
        Console.WriteLine("StaticMethod.Print()");
        Print2();
    }
    public static void Print2()     {
        Console.WriteLine("StaticMethod.Print2()");
    }
}