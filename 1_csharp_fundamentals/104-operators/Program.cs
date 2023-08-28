// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operators!");

// Aritmetik operatörler
// +, -, *, /, %, ++, --
// aritmetik işlemler için kullanılır
// + operatörü string birleştirme için de kullanılır
// % operatörü mod alma işlemi için kullanılır
// ++ operatörü bir arttırma işlemi için kullanılır
// -- operatörü bir azaltma işlemi için kullanılır

string str = "100";
int num = 100;
Console.WriteLine(str + num); // 100100, imlicit conversion
Console.WriteLine(num + str); // 100100, imlicit conversion
Console.WriteLine(num + num); // 200, sayısal toplama
Console.WriteLine(str + str); // 100100, string birleştirme

int x = 10;
int y = ++x; // önce x değerini 1 arttır sonra y'ye ata
Console.WriteLine("X:"+x); // 11
Console.WriteLine("Y:"+y); // 11

y = x++; // önce x değerini y'ye ata sonra x değerini 1 arttır
Console.WriteLine("X:"+x); // 12
Console.WriteLine("Y:"+y); // 11

// Atama operatörleri
// =, +=, -=, *=, /=, %=

// Karşılaştırma operatörleri
// ==, !=, >, <, >=, <=
// karşılaştırma işlemleri için kullanılır, sonuç bool türündedir, yani true veya false değeri alır

// Mantıksal operatörler
// &&, ||, !
// mantıksal işlemler için kullanılır, sonuç bool türündedir, yani true veya false değeri alır
// birden fazla koşulun birlikte sağlanıp sağlanmadığını kontrol etmek için kullanılır

/*
Operatör Öncelikleri
    1. ()
    2. ++, --
    3. *, /, %
    4. +, -
    5. <, >, <=, >=
    6. ==, !=
    7. &&
    8. ||
    9. =
*/