// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C# Objects!");

// C# built-in objects
// Math
Console.WriteLine("Math");
Console.WriteLine(Math.Abs(-4.7)); // 4.7
Console.WriteLine(Math.Pow(2, 3)); // 8
Console.WriteLine(Math.Sqrt(16)); // 4
Console.WriteLine(Math.Max(4, 90)); // 90
Console.WriteLine(Math.Min(4, 90)); // 4
Console.WriteLine(Math.Round(9.99)); // 10
Console.WriteLine(Math.Round(9.49)); // 9
Console.WriteLine(Math.Round(9.5)); // 10
Console.WriteLine(Math.Round(9.5, 0)); // 10
Console.WriteLine(Math.Round(9.523, 1)); // 9.5
Console.WriteLine(Math.Round(9.568, 2)); // 9.57
Console.WriteLine(Math.Round(9.5189, 3)); // 9.519

// Random
Console.WriteLine("Random");
Random random = new Random();
Console.WriteLine(random.Next()); // 0-2147483647 arası sayı üretir
Console.WriteLine(random.Next(10)); // 0-9 arası sayı üretir



