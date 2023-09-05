// See https://aka.ms/new-console-template for more information

using System;

namespace MyException {
    class Program {
        static void Main(string[] args) {
            try {
                int[] myNumbers = {1, 2, 3};
                Console.WriteLine(myNumbers[12]);
            } catch (Exception e) {
                Console.WriteLine("Something went wrong.");
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}