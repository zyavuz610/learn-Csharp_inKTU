// See https://aka.ms/new-console-template for more information
using System;
using System;

namespace HelloWorld {
  class Car   {
    string color = "red";
    static void Main(string[] args)     {
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
  class Program   {
    static void Main(string[] args)     {
      Console.WriteLine("Hello World!");    
    }
  }
  */
}

/*
Açıklama
Satır 1: using System, System isim uzayından sınıfları kullanmamızı sağlar.
Satır 2: Boş bir satır. C# boşlukları görmezden gelir. Ancak birden fazla satır kodu daha okunabilir hale getirir.
Satır 3: namespace, kodunuzu düzenlemek için kullanılır ve sınıflar ve diğer isim uzayları için bir konteyner görevi görür.
Satır 4: Süslü parantezler {} bir kod bloğunun başlangıcını ve sonunu işaretler.
Satır 5: class, programınıza işlevsellik getiren veri ve yöntemlerin bir konteyneridir. C# 'da çalışan her kod satırı bir sınıf içinde olmalıdır. Örneğimizde sınıfı Program olarak adlandırdık.

using System satırını atladığınızda, metin yazdırmak / çıktı almak için System.Console.WriteLine() yazmanız gerekir.

Satır 7: C# programında her zaman görünen başka bir şey de Main yöntemidir. Süslü parantezlerinin {} içindeki herhangi bir kod yürütülür. Main'in önündeki ve arkasındaki anahtar kelimeleri anlamanız gerekmez. Bu öğreticiyi okurken onları azar azar öğreneceksiniz.

Satır 9: Console, metin yazdırmak / çıktı almak için kullanılan bir System isim uzayı sınıfıdır. Örneğimizde "Merhaba Dünya!" Çıktısını / çıktısını verecektir.

Not: Her C# ifadesi noktalı virgül ; ile biter.

*/

