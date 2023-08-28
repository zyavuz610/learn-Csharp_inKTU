// See https://aka.ms/new-console-template for more information
Console.WriteLine("Constant snd Litterals!");

// Constants
const double PI = 3.14159; // daha önce de gördüğümüz gibi const değişkenlerin değeri değiştirilemez

// Literals
int x = 5;
double d = 5.5;
char c = 'c';
string s = "Hello";
bool b = true;

// int literals
int x = 0b101; // binary literal
int y = 0xFF; // hexadecimal literal
int z = 0b101_0001_0100_1010; // binary literal with digit separators
int w = 1_000_000; // decimal literal with digit separators
long w2 = 1_000_000L; // decimal literal with digit separators

// float literals
float f1 = 3.5F; // float literal
double d1 = 3.5D; // double literal

// char literals
char c1 = 'a';
char c2 = '\u0061'; // unicode character
char c3 = '\x61'; // hexadecimal character

// Escape karakterler
string s1 = "Hello\tWorld\n"; // \t: tab, \n: new line
/*
    \\: backslash
    \': single quote
    \": double quote
    \0: null
    \a: alert
    \b: backspace
    \f: form feed
    \r: carriage return
    \v: vertical tab
    \uxxxx: unicode character
    \n: new line
    \t: tab
*/

// string literals
string s1 = "Hello";
string s2 = @"C:\Users\KTU\Desktop\KTU\KTU-PROGRAMMING\KTU-PROGRAMMING\1_csharp_fundamentals\103-constants-and-litterals\Program.cs"; // verbatim string literal: yani \ işareti escape karakteri olarak algılanmaz

