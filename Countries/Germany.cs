namespace Countries;

class Germany : Country
{
  String Country.GetName() { return "Germany"; }

  void Country.CheckLegality(uint age)
  {
    if (age < 16)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("You cannot drink");
      Console.ResetColor();
      return;
    }
    else if (age >= 16 && age < 18)
    {
      Console.WriteLine("You can only drink 🍺Beer and 🍷Wine");
    }
    else
    {
      Console.WriteLine("You can drink 🥃Alcohol");
    }
  }
}
