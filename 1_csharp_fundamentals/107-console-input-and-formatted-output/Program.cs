// See https://aka.ms/new-console-template for more information
Console.WriteLine("Console Input!");

// Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);

//---------------------------------------------------

string name = "Fred";
string new_name = String.Format("Name = {0}, hours = {1:hh}", name, DateTime.Now);
Console.WriteLine(new_name);

string primes;
primes = String.Format("Prime numbers less than 10: {0}, {1}, {2}, {3}",
                       2, 3, 5, 7 );
Console.WriteLine(primes);
