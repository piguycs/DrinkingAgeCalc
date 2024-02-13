namespace Countries;

class Netherlands : Country
{
  String Country.GetName() { return "Netherlands"; }

<<<<<<< Updated upstream
  void Country.CheckLegality(int age)
=======
  void Country.CheckPublicLegality(uint age)
>>>>>>> Stashed changes
  {
    if (age < 18)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("You cannot drink");
      Console.ResetColor();
      return;
    }
    else
    {
      Console.WriteLine("You can drink 🥃Alcohol");
    }
  }
}
