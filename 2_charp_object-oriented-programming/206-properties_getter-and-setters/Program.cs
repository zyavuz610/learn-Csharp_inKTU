// See https://aka.ms/new-console-template for more information

using System;

class Person {
    private string name = "Deneme"; // field

    public string Name { // property
        get { return name; }
        set { name = value; }
    }
    // alternatif olarak
    // public string Name { get; set; } // auto-implemented property

    // Name property'si name field'ına erişim sağlar. field küçük harfle başlar, property büyük harfle başlar
    // name => Name
}

class Program {
    static void Main(string[] args) {
        Person p = new Person();
        //p.Name = "Zafer";
        Console.WriteLine(p.Name);
    }
}

/*
Properties ve Encapsulation
    hassas verileri korumak için kullanılır, veri gizleme
    bunu sağlamak için;
        değişkenleri private yaparız
        değişkenlere erişmek için public fonksiyonlar (getter ve setter) kullanırız
        
*/
/*
Encapsulation Ne için Gerekli?
    sınıf içindeki değişkenlere erişimi kontrol etmek için kullanılır
    sadece get kullanılırsa değişken salt okunur olur
    sadece set kullanılırsa değişken salt yazılır olur
    esneklik sağlar, sadece bir kaç parça kodu değiştirmek için tüm kodu değiştirmek zorunda kalmayız
    daha iyi bir güvenlik sağlar, 
    daha iyi bir kontrol sağlar,
        eğer çok kişinin çalıştığı bir projede çalışıyorsanız, bu özellikler çok önemlidir
*/