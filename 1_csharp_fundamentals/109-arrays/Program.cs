using System.Linq;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Arrays!");

// define array
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine("Dizi elemanına erişim:");
Console.WriteLine(cars[0]); // Volvo


// loop through array
Console.WriteLine("Dizi üzerinde döngü");
for (int i = 0; i < cars.Length; i++) {
    Console.WriteLine(cars[i]);
}

// loop through array with foreach
foreach (string car in cars) {
    Console.WriteLine(car);
}

//---------------------------------------------
// sorting arrays  (dizileri sıralama)
Console.WriteLine("Dizileri sıralama:");
int[] numbers = {4, 2, 8, 5, 1, 7};
Array.Sort(numbers); // her veri tipi için kullanılabilir
foreach (int number in numbers) {
    Console.WriteLine(number);
}

//---------------------------------------------
// Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:
// using System.Linq; dahil edilmelidir
int[] numbers2 = {4, 2, 8, 5, 1, 7};
Console.WriteLine(numbers.Max()); // 8
Console.WriteLine(numbers.Min()); // 1
Console.WriteLine(numbers.Sum()); // 27

//---------------------------------------------
// multidimensional arrays (çok boyutlu diziler)
// syntax: <veri tipi>[,] <dizi adı> = new <veri tipi>[<satır sayısı>, <sütun sayısı>];
int[,] myNumbers = { {1, 2, 3, 4}, {5, 6, 7, 8} };
Console.WriteLine(myNumbers[0, 0]); // 1
Console.WriteLine(myNumbers[1, 2]); // 7

// loop through multidimensional array
for (int i = 0; i < myNumbers.GetLength(0); i++) {
    for (int j = 0; j < myNumbers.GetLength(1); j++) {
        Console.WriteLine(myNumbers[i, j]);
    }
}

// loop through multidimensional array with foreach
foreach (int number in myNumbers) {
    Console.WriteLine(number);
}

//---------------------------------------------