using System;

class MainClass {
  public static void Main (string[] args) {
  	Console.WriteLine("-------------------------------------------");
	  Console.WriteLine("Welcome to the Decimal to Binary Calculator");
		Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Enter the decimal you would like to convert");
		Console.WriteLine("-------------------------------------------");


		string val = Console.ReadLine();

    int from = 10;
    int to = 2;
 
    string binary = Convert.ToString(Convert.ToInt32(val, from), to);
		Console.WriteLine();
		Console.WriteLine("In binary your number is: " + binary);
  }
}
