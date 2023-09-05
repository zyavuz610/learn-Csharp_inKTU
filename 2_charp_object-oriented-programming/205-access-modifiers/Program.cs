// See https://aka.ms/new-console-template for more information
/*
Erişim Denetleyiciler
    public: her yerden erişilebilir, sınıf dışından da
    private: sadece tanımlandığı sınıf içinden erişilebilir
    protected: sadece tanımlandığı sınıf içinden ve bu sınıftan türetilen sınıflardan erişilebilir, miras alınan sınıflardan erişilebilir

erişim denetleyiciler ne için kullanılır?
    veri gizleme ve encapsulation için kullanılır
*/

using System;

class Car2 {
    private string model = "Mustang"; // private erişim denetleyicisi
}

class Car3 {
    public string model = "Mustang"; // public erişim denetleyicisi
}

class Car {
  private string model = "Mustang";

  static void Main(string[] args)   {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);

    Car2 myObj2 = new Car2();
    // Console.WriteLine(myObj2.model); // hata verir

    Car3 myObj3 = new Car3();
    Console.WriteLine(myObj3.model); // hata vermez
  }
}

/*
protected erişim denetleyici miras konusu ile birlikte anlatılacak
*/