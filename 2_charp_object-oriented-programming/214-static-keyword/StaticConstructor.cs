public class StaticConstructor {
    /*
    */
    static StaticConstructor()     { // static constructor ların erişim belirleyicisi private olamaz. bu nedenle static constructor ların erişim belirleyicisi olmaz.
        Console.WriteLine("StaticConstructor.StaticConstructor()");
    }
    public StaticConstructor()     {
        Console.WriteLine("StaticConstructor.non-StaticConstructor()");
    }
    private StaticConstructor(int a)     { // static olmayan constructor ların erişim belirleyicisi private olabilir.
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