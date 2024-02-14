namespace Countries;

public interface Country
{
  private static Country[] CountryList = { new Germany(), new Netherlands() };
  public static void CheckForAllCountries(int age)
  {
    foreach (Country country in CountryList)
    {
      Console.WriteLine($"Country: {country.GetName()}");
      country.CheckPublicLegality(age);
    }
  }

  protected String GetName();
  protected void CheckPublicLegality(int age);
}
