// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Loops!");

// for döngüsü
// syntax: for (<başlangıç değeri>; <koşul>; <arttırma/azaltma>) {
//              <döngü gövdesi>
//         }
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}

// while döngüsü
// syntax: while (<koşul>) {
//              <döngü gövdesi>
//         }
int i2 = 0;
while (i2 < 10) {
    Console.WriteLine(i2);
    i2++;
}

// do-while döngüsü
// syntax: do {
//              <döngü gövdesi>
//         } while (<koşul>);
int ii = 0;
do {
    Console.WriteLine(ii);
    ii++;
} while (ii < 10);

//---------------------------------------------
// nested loops
for (int i = 0; i < 10; i++) {      // dış döngü
    for (int j = 0; j < 10; j++) {  // iç döngü
        Console.Write(i + "," + j + " ");
    }
    Console.WriteLine();
}

//---------------------------------------------
// break ve continue
// break: döngüden çıkılmasını sağlar
// continue: döngüdeki bir sonraki adıma geçilmesini sağlar
for (int i = 0; i < 10; i++) {
    if (i == 5) {
        break;
    }
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++) {
    if (i == 5) {
        continue;
    }
    Console.WriteLine(i);
}

//---------------------------------------------
// foreach döngüsü
// syntax: foreach (<değişken> in <dizi>) {
//              <döngü gövdesi>
//         }
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string i in cars) {
    Console.WriteLine(i);
}

//---------------------------------------------
// örnek: sayı tahmin oyunu
// 1-100 arasında rastgele bir sayı üretilir
// kullanıcıdan sayı tahmini istenir
// kullanıcı sayıyı doğru tahmin edene kadar tahmin istenir
// kullanıcı sayıyı doğru tahmin ettiğinde kaç tahminde bildiği ekrana yazdırılır
// kullanıcı sayıyı doğru tahmin edemediğinde sayıyı ekrana yazdırılır
// kullanıcı sayıyı doğru tahmin edemediğinde kullanıcıya yeni bir tahmin istenir
// kullanıcı yeni bir tahmin girdiğinde önceki tahminler ekrana yazdırılır

int number = new Random().Next(1, 100);
int guess = 0;
int count = 0;
while(1){
    Console.Write("Bir sayı tahmin edin: ");
    guess = Convert.ToInt32(Console.ReadLine());
    count++;
    if(guess == number){
        Console.WriteLine("Tebrikler, {0} sayısını {1} tahminde bildiniz.", number, count); // formatlı yazdırma, daha sonra anlatılacak
        break;
    }
    else if(guess < number){
        Console.WriteLine("Daha büyük bir sayı girin.");
    }
    else{
        Console.WriteLine("Daha küçük bir sayı girin.");
    }
}
//--------------------------------------------- 
