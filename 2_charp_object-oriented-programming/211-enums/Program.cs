// See https://aka.ms/new-console-template for more information
class Program {
  enum Level   {
    Low,        // 0
    Medium,     // 1
    High        // 2
  }
  enum Months   {
    January,    // 0
    February,   // 1
    March = 6,    // 6
    April,      // 7
    May,        // 8
    June,       // 9
    July        // 10
  }
  static void Main(string[] args)   {
    Level myVar = Level.Medium;
    Console.WriteLine(myVar);

    int myNum = (int) Months.April;
    Console.WriteLine(myNum);
  }
}
