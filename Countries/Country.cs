namespace Countries;

public interface Country
{
  private static Country[] CountryList = { new Germany(), new Netherlands() };
  public static void CheckForAllCountries(uint age)
  {
    foreach (Country country in CountryList)
    {
      Console.WriteLine($"Country: {country.GetName()}");
      country.CheckpublicLegality(age);
    }
  }

  protected String GetName();
  protected void CheckpublicLegality(uint age);
}
