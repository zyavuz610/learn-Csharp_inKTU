﻿// See https://aka.ms/new-console-template for more information
using System;
using System;

namespace HelloWorld
{
  class Car 
  {
    string color = "red";
  
    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);

      // multiple object
      Car myObj1 = new Car();
      Car myObj2 = new Car();
      Console.WriteLine(myObj1.color);
      Console.WriteLine(myObj2.color);
    }
  }
  /*
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
    }
  }
  */
}

/*
Example explained
Line 1: using System means that we can use classes from the System namespace.

Line 2: A blank line. C# ignores white space. However, multiple lines makes the code more readable.

Line 3: namespace is used to organize your code, and it is a container for classes and other namespaces.

Line 4: The curly braces {} marks the beginning and the end of a block of code.

Line 5: class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.

Don't worry if you don't understand how using System, namespace and class works. Just think of it as something that (almost) always appears in your program, and that you will learn more about them in a later chapter.

Line 7: Another thing that always appear in a C# program, is the Main method. Any code inside its curly brackets {} will be executed. You don't have to understand the keywords before and after Main. You will get to know them bit by bit while reading this tutorial.

Line 9: Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example it will output "Hello World!".

If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.

Note: Every C# statement ends with a semicolon ;.

*/
