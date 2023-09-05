// See https://aka.ms/new-console-template for more information
﻿// See https://aka.ms/new-console-template for more information
using System;


public class UtilTest {
   public void func() {
      string a = "blue";
      string b = "sky";
      Console.WriteLine("{0} {1}", a, b);
      Util.Swap(ref a, ref b);
      Console.WriteLine("{0} {1}", a, b);
   }
}
public class Util {
   public static void Swap(ref string x, ref string y) {
      string o = x;
      x = y;
      y = o;
   }
}


public class Program {

  static void Main(string[] args) {
    MyClass mc = new MyClass();
    mc.func();
    Console.WriteLine(mc.color);
    Console.WriteLine(mc.maxSpeed);
    
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);

   //------------------------------------------------------------
    UtilTest ut = new UtilTest();
    ut.func();
  }
}

