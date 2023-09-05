// See https://aka.ms/new-console-template for more information

using System.IO;

class Program {
  static void Main(string[] args) {
    string[] lines = {"First line", "Second line", "Third line"};
    File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);

    string writeText = "Hello World!";  // Create a text string
    File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

    string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
    Console.WriteLine(readText);  // Output the content
  }
}

/*

Method	Description
AppendText()	Appends text at the end of an existing file
Copy()	Copies a file
Create()	Creates or overwrites a file
Delete()	Deletes a file
Exists()	Tests whether the file exists
ReadAllText()	Reads the contents of a file
Replace()	Replaces the contents of a file with the contents of another file
WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.

*/

//--------------------------------------------------------------------------------
//  her satırında Türkiyenin şehirlerinin plakasını ve isimleri yazan verileri okuyup ekrana basan bir program
/*
using System;
using System.IO;

class Program {
    static void Main()    {
        // Dosyanın yolunu belirtin
        string dosyaYolu = "sehirler.txt";

        try // Hata oluşma ihtimaline karşı try-catch bloğu kullanın {
            // Dosyayı açın ve StreamReader kullanmadan verileri okuyun
            string[] satirlar = File.ReadAllLines(dosyaYolu);

            foreach (string satir in satirlar) // Her satır için            {
                // Satırı boşluğa göre ayırarak plaka ve şehir adını alın
                string[] parcalar = satir.Split(' ');

                // Plaka ve şehir adını ekrana yazdırın
                if (parcalar.Length == 2) // Hata oluşmaması için                {
                    string plaka = parcalar[0];
                    string sehirAdi = parcalar[1];
                    Console.WriteLine("Plaka: " + plaka + ", Şehir: " + sehirAdi);
                }
            }
        }
        catch (Exception ex) // Hata oluşursa        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
}

*/