// See https://aka.ms/new-console-template for more information
Console.WriteLine("if else!");

if (20 > 18) {
  Console.WriteLine("20 is greater than 18");
}

double x = 20;
double y = 18;
if (x > y) {
  Console.WriteLine("x is greater than y");
}

int time = 20;
if (time < 18) {
  Console.WriteLine("Good day.");
} 
else {
  Console.WriteLine("Good evening.");
}

int time = 22;
if (time < 10) {
  Console.WriteLine("Good morning.");
} 
else if (time < 20) {
  Console.WriteLine("Good day.");
} 
else {
  Console.WriteLine("Good evening.");
}

//---------------------------------------------
// Ternary operatörü
// syntax: <koşul> ? <doğruysa> : <yanlışsa>
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);

// nested ternary operatörü
int time = 20;
string result = (time < 18) ? "Good day." : (time < 20) ? "Good afternoon." : "Good evening.";

//---------------------------------------------
// switch-case, eşiğe göre karar verme
int day = 4;
switch (day) {
  case 1:
    Console.WriteLine("Monday");
    break;      // break komutu switch-case bloğundan çıkılmasını sağlar, mutlaka kullanılmalıdır
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
  default:    // hiçbir case eşleşmezse default bloğu çalışır
    Console.WriteLine("Gün değeri 1-7 arasında olmalıdır.");
}
