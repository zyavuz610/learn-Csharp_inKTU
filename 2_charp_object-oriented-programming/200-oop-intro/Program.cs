// See https://aka.ms/new-console-template for more information
using System; // gerekli kütüphane ve isim uzayları dahil edilir

class Program{                      // her program aslında bir C# nesnesidir
    public static void Main(){      // her program Main den başlar, statik olmak zorundadır
        Console.WriteLine("Merhaba KTU");
    }
}

/*
nesneler bir sınıfın örneğidir.
sınıf oluşturmak için class anahtar kelimesi kullanılır.

nesne yönelimli programlama (OOP) bir programlama paradigmasıdır.
bu paradigma, programı nesnelerin birbirleriyle etkileşimleri üzerinden tasarlamayı sağlar.
normalde programlar, veri yapıları ve fonksiyonlar üzerinden tasarlanır.
OOP de ise programlar, nesneler ve nesnelerin birbirleriyle etkileşimleri üzerinden tasarlanır.
örneğin
    şekil çizme programı yazmak istiyoruz.
    bu programı veri yapıları ve fonksiyonlar üzerinden tasarlayabiliriz.
    veri yapıları olarak da üçgen, kare, daire gibi şekilleri kullanabiliriz.
    fonksiyonlar olarak da çiz, sil, boyutlandır gibi fonksiyonları kullanabiliriz.
    bu programı nesneler ve nesnelerin birbirleriyle etkileşimleri üzerinden tasarlayabiliriz.
    nesneler olarak da üçgen, kare, daire gibi şekilleri kullanabiliriz.
    nesnelerin birbirleriyle etkileşimleri olarak da çiz, sil, boyutlandır gibi fonksiyonları kullanabiliriz.
    bu programı nesneler ve nesnelerin birbirleriyle etkileşimleri üzerinden tasarlamak, programı daha kolay anlaşılır ve daha kolay geliştirilebilir hale getirir.
    bu programı nesneler ve nesnelerin birbirleriyle etkileşimleri üzerinden tasarlamak için nesne yönelimli programlama kullanılır.

bir diğer örnek:
    bir banka programı yazmak istiyoruz.
        bu programı veri yapıları ve fonksiyonlar üzerinden tasarlayabiliriz.
        veri yapıları olarak da müşteri, hesap, para gibi kavramları kullanabiliriz.
        fonksiyonlar olarak da para yatır, para çek, hesap aç gibi fonksiyonları kullanabiliriz.
    bu programı nesneler ve nesnelerin birbirleriyle etkileşimleri üzerinden tasarlayabiliriz.
        nesneler olarak da müşteri, hesap, para gibi kavramları kullanabiliriz.
        nesnelerin birbirleriyle etkileşimleri olarak da para yatır, para çek, hesap aç gibi fonksiyonları kullanabiliriz.

Sınıflar ve nesneler, nesne yönelimli programlamanın iki ana yönüdür.
örneğin:
    int x = 5, y = 10;
    burada int bir class, x ve y ise birer nesnedir.
bu benzetimden hareketle bundan sonra biz de kendi class larımızı yazacağız ve bunlardan nesne oluşturacağız.
*/
