// See https://aka.ms/new-console-template for more information
Console.WriteLine("Strings!");

string greeting = "Hello";
string name = "Zafer";
string message = greeting + ", " + name;
Console.WriteLine("String concatenation"");
Console.WriteLine(message);

string message2 = String.Format("{0}, {1}", greeting, name);
Console.WriteLine("String.Format()");
Console.WriteLine(message2);

// String interpolation
string message3 = $"{greeting}, {name}";
Console.WriteLine("String interpolation");
Console.WriteLine(message3);

// Access individual characters in a string with indexing
string message4 = "Hello, World!";
Console.WriteLine("Access individual characters in a string with indexing");
Console.WriteLine(message4[0]); // H

// Get the length of a string
Console.WriteLine("Get the length of a string");
Console.WriteLine(message4.Length); // 13

// Get a substring
Console.WriteLine("Get a substring");
Console.WriteLine(message4.Substring(7, 5)); // World, 7: başlangıç, 5: uzunluk

// Search for the index of a substring
Console.WriteLine("Search for the index of a substring");
Console.WriteLine(message4.IndexOf("World")); // 7

// Change casing
Console.WriteLine("Change casing");
Console.WriteLine(message4.ToLower());
Console.WriteLine(message4.ToUpper());

// Replace a substring
Console.WriteLine("Replace a substring");
Console.WriteLine(message4.Replace("World", "Universe")); // Hello, Universe!

// Concatenate strings
Console.WriteLine("Concatenate strings");
string message5 = "Hello, " + "World!";
Console.WriteLine(message5);

// Concatinate with Method
Console.WriteLine("Concatinate with Method");
string message6 = String.Concat("Hello, ", "World!");
Console.WriteLine(message6);


