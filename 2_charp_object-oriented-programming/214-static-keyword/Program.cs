// See https://aka.ms/new-console-template for more information

/*
Static keyword
    normalde bir nesne oluşturulduğunda o nesneye ait özellikler ve metotlar oluşur. bu özellikler ve metotlar nesne üzerinden çağrılır. hangi özellik ve methodları olacağı class içerisinde belirtilir.
    static keywordü ile oluşturulan özellik ve metotlar nesneye ait değildir. sınıfa aittir. bu özellik ve metotlar nesne üzerinden değil sınıf üzerinden çağrılır.
    static kelimesi bir nesneye ait olmayan, sınıfa ait olan bir özelliktir.
    static özelliğe sahip bir nesne oluşturulamaz.
    static kelimesi class, metot ve özelliklerde kullanılabilir.

static class
    sınıf düzeyinde statik olma durumunu gösterir
    static classlar içerisinde static olmayan bir özellik veya metot oluşturulamaz.
    static classlar içerisinde static olmayan bir nesne oluşturulamaz.
    static classlar içerisinde tüm özellikler ve metotlar static olmak zorundadır.
    static classlar içerisinde static olmayan bir constructor oluşturulamaz.
    kullanım amacı: genelde yardımcı sınıflar için kullanılır. örneğin matematiksel işlemler için kullanılabilir.
*/
StaticClass.Print(); // kaynak koda bakınız, StaticClass.cs

//--------------------------------------------------------------------------
/*
Static Olmayan Sınıf İçinde Static Method ve Özellikler
    2 durum söz konusu
        1. static olmayan sınıf içinde static method ve özellikler
        2. static olmayan sınıf içinde static olmayan method ve özellikler
    
    1. static olmayan sınıf içinde static method ve özellikler
        static method ve özellikler oluşturulduğunda bu method ve özellikler sınıfa ait olur. nesneye ait değildir.
        static method ve özellikler sınıf üzerinden çağrılır.
        static method ve özellikler nesne üzerinden çağrılamaz.
        static method ve özellikler nesne üzerinden çağrılmak istenirse hata alınır.
        static method içerisinde static olmayan method ve özellikler çağrılamaz.

    2. static olmayan sınıf içinde static olmayan method ve özellikler
        1. static olmayan method ve özellikler nesneye ait olur.
        2. static olmayan method ve özellikler nesne üzerinden çağrılır.
        3. static olmayan method ve özellikler sınıf üzerinden çağrılamaz.
        4. static olmayan method ve özellikler sınıf üzerinden çağrılmak istenirse hata alınır.
        5. static olmayan method içerisinde static method ve özellikler çağrılablir.
    
*/
StaticMethod sm = new StaticMethod();
sm.Print(); // kaynak koda bakınız, StaticMethod.cs
StaticMethod.Print2(); // kaynak koda bakınız, StaticMethod.cs
//StaticMethod.Print(); // hata verir, kaynak koda bakınız, StaticMethod.cs
//sm.Print2(); // hata verir, kaynak koda bakınız, StaticMethod.cs

//--------------------------------------------------------------------------
/*
static constructor
    static constructor parametre almaz. tek bir static constructor oluşturulabilir.
    static constructorlar static olmayan constructorlara göre daha önceliklidir.
    static constructor sınıf içerisinde static olmayan bir özellik veya metot çağrılmadan önce çalışır.
    static constructor çalıştırıldığında static olmayan constructor çalıştırılmaz.
*/
StaticConstructor sc = new StaticConstructor(2);
