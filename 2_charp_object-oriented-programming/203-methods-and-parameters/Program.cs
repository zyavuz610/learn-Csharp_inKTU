// See https://aka.ms/new-console-template for more information

using System;

namespace Methods {
    class Program {
        static void yaz() {
            Console.WriteLine("Merhaba KTU"); 
        }
        static void yaz2(string s) { // parametre
            Console.WriteLine("Merhaba " + s);
        }
        static void Main(string[] args) {
            yaz();
            yaz();

            yaz2("KTU"); // argüman
            yaz2("Zafer");
        }
    }
}

/*
methodlarda parametre kullanımı
    parametreler farklı türde ve sayıda olabilir
    örneğin:
        static void MyMethod(string fname, int age)         {
        Console.WriteLine(fname + " is " + age);
        }

default parametreler
    parametrelerin varsayılan değerleri olabilir
    örneğin:
        static void MyMethod(string country = "Norway")         {
        Console.WriteLine(country);
        }
    bu durumda MyMethod() şeklinde çağırırsak country parametresinin değeri Norway olur
    MyMethod("Sweden") şeklinde çağırırsak country parametresinin değeri Sweden olur

return değeri
    methodlar bir değer döndürebilir
    örneğin:
        static int MyMethod(int x)         {
        return 5 + x;
        }
    bu durumda MyMethod(3) şeklinde çağırırsak MyMethod(3) değeri 8 olur

adlandırılmış parametreler
    parametrelerin sırası önemli değildir
    örneğin:
        static void MyMethod(string child1, string child2, string child3)         {
        Console.WriteLine("The youngest child is: " + child3);
        }
    bu durumda 
        MyMethod(child3: "John", child2: "Liam", child1: "Liam");
    şeklinde çağırırsak MyMethod(child3: "John", child2: "Liam", child1: "Liam") değeri The youngest child is: John olur

method overloading
    aynı isimde birden fazla method olabilir
    örneğin:
        static int PlusMethodInt(int x, int y)         {
        return x + y;
        }
        static double PlusMethodDouble(double x, double y)         {
        return x + y;
        }
    bu durumda PlusMethodInt(8, 5) değeri 13 olur
    bu durumda PlusMethodDouble(4.3, 6.26) değeri 10.56 olur
*/