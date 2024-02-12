namespace DrinkingAgeCalc;

using Countries;

class Program
{
  static void Main(String[] args)
  {

    Console.WriteLine("Drinking age calculator v1.0.0");

    // Take user input
    Console.Write("What is your age? ");
    int age = int.Parse(Console.ReadLine() ?? "0");

    // Check age
    Country.CheckForAllCountries(age);

    // end
    Console.WriteLine("Drinking age calculator completed execution");
  }
}
