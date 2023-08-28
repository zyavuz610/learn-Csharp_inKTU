// See https://aka.ms/new-console-template for more information

/*

    ********** YORUM[LAR]   *************************
    - programcıya daha sonra hatırlatması için kullanılan yapılardır.
    - c# dili tarafından görmezden gelinirler
    - tek satır ve çok satırlı türleri vardır
    - yazılan bir kodu silmeden görmezden gelinmesi için kullanılabilir.
    - DEBUG işlemlerinde çok yararlı bir yapıdır.


*/
 // tek satırlı yorum, // işaretinden sonra yazılan o satırdaki her şey yorum olur

/* Başka bir tek satırlı yorum */

/* blok halinde yorum
    * çok satırlı yorum için bir satır
*/

Console.WriteLine("Yorum yapma şekilleri anlatıldı...!");


/*
/*
    ********* IFADE SONLANDIRMA **************
    - c# dilinde komutlar (kodlar) ifadeler(statement) biçiminde yazılır
    - her ifade ; ile sonlandırılır
    - örneğin;
        x=y;
        y=x+1;
        return 0;

    ********** BLOK { ... }  ********************
    - c# dilinde blok denilen ve mantıksal olarak birbiriyle ilişkili ifadeleri gruplayan yapılar vardır
    - { ... } şeklinde blok açılır ve kapanır.
    - fonksiyonlar, koşul ve döngü ifadelerinin blokları için kullanılır.
    - örneğin 
*/
for(int i=0;i<10;i++)  {
  Console.Write(i + " ");
}
  /*
  - c# dilinde tüm kodlar tek bir satırda yazılabileceği gibi ayrı ayrı satırlarda da yazılır
    - aşağıdaki kod1 ve kod2 aynı anlamdadır.
    - kod1:
        int x=1;
        x=x+1;
        x++;
    - kod2:
        int x=1; x=x+1; x++;

    *******  C# identifiers **********************
    - kullanıcı tanımlı elemanlardır (değişken, fonksiyon, class, module ...)  
    - bu elemanları isimlendirme yaparken
        . A-Z veya a-z veya _ ile başlayabilirler
        . devamında 0 veya daha fazla A-Z, a-z, _ ve 0-9 (rakamlar) gelebilir
        . özel karakterler (@, $, % ...) kullanılmaz
        . büyük küçük harf ayrımı vardır
        . "gun" ve "Gun" farkli elemanları ifade eder

    *********** C# KeyWords (Anahtar Kelimeler) ******************
    - c# da kullanıcı tanımlı öğeleri isimlendirirken kullanamayacağımız anahtar kelimeler vardır
    - örneğin:
        if, else, for, int, float, char, unsigned, new, this, return ....

    *********** C# Whitespace (Beyaz Boşluk) ******************************
    - Boş satırlar veya birden çok boşluk karakteri c++ tarafından görmezden gelinir.
    - Yani istediğiniz kadar boşluk, tab, yeni satır, yorum[lar] kullanabilirsiniz.
    - Tüm bunlar white space olarak adlandırılır ve tek bir boşluk karakteri olarak görülür
    - Bu durumda programınızı tek bir satırda da yazabilirsiniz, yüzlerce satıra da bölebilirsiniz.  
*/

