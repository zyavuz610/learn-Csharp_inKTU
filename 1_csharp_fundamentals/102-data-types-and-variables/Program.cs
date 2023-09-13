// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veri Türleri ve Değişkenler!");

/*
c# dilinde değişkenler veri tutan yapılardır.
değişken isimlendirme kurallarını hatırlayalım:
        . A-Z veya a-z veya _ ile başlayabilirler
        . devamında 0 veya daha fazla A-Z, a-z, _ ve 0-9 (rakamlar) gelebilir
        . özel karakterler (@, $, % ...) kullanılmaz
        . büyük küçük harf ayrımı vardır
        . "gun" ve "Gun" farkli elemanları ifade eder
    Öneri: değişkenlere yaptıkları işi anlatan isimler verilmelidir.
    farklı değişken isimlendirme stilleri vardır:
        camelCase
        PascalCase
        snake_case
        kebab-case
    tek harften oluşan değişken isimlerini sadece mateamatiksel formüllerde kullanabiliriz:
    örnek: lineer denklem: y=mx+b


*/

// syntax: <veri_türü> <değişken_adı> = <değer>;
int x = 10; // x değişkeni 10 değerini tutuyor

// değişkenlerin değerleri değiştirilebilir
x = 20; // x değişkeni 20 değerini tutuyor

string name = "John";       // değişkenlere ilk değer ataması yapılabilir
Console.WriteLine(name);    // değişkenin değeri ekrana yazdırılır
Console.WriteLine("Hello " + name);
int x = 5;
int y = 6;
Console.WriteLine(x + y); // + operatörüne dikkat: string toplama ile sayı toplama işlemleri farklı

// diğer veri türler
int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

//---------------------------------------------
const int myNum = 15;       // const değiken içeriği değiştirilemeyen değişkenlerdir
myNum = 20;                 // hata verir, const değişkenlerin değeri değiştirilemez

//---------------------------------------------
int x = 5, y = 6, z = 50; // aynı türden birden fazla değişken tanımlanabilir
Console.WriteLine(x + y + z);

int x, y, z;
x = y = z = 50;
Console.WriteLine(x + y + z);

//---------------------------------------------
/*
Data Type	Size	Description
int	        4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
long	    8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float	    4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double	    8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
bool	    1 bit	Stores true or false values
char	    2 bytes	Stores a single character/letter, surrounded by single quotes
string	    2 bytes per character	Stores a sequence of characters, surrounded by double quotes
*/

// Sayısal veri türleri
int myNum = 100000;
Console.WriteLine(myNum);

long myNum = 15000000000L;
Console.WriteLine(myNum);

float myNum = 5.75F;
Console.WriteLine(myNum);

double myNum = 19.99D;
Console.WriteLine(myNum);

// Boolean veri türü
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False

// Char veri türü
char myGrade = 'B';
Console.WriteLine(myGrade);

// String veri türü
string greeting = "Hello World";
Console.WriteLine(greeting);

//---------------------------------------------
// Type Casting
// Implicit Casting (automatically) - converting a smaller type to a larger type size
// char -> int -> long -> float -> double
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

// Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char
double myDouble = 9.78;
int myInt = (int)myDouble;    // Manual casting: double to int

// Type Conversion Methods
// Convert.ToString()
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;
Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

/*
Düzgün ve Hatalı Değişken İsimlendirmelerine Örnekler
    int 1stNumber = 10; // hatalı
    int firstNumber = 10; // düzgün
    int first_number = 10; // düzgün
    int first-number = 10; // hatalı
    int firstNumber1 = 10; // düzgün
    int _firstNumber = 10; // düzgün
    int firstNumber_ = 10; // düzgün
    int firstNumber_1 = 10; // düzgün
    int firstNumber$ = 10; // hatalı

büyük küçük harf ayrımı vardır
    firstNumber ve FirstNumber farklı değişkenlerdir.
*/