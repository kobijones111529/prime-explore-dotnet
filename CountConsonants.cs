public class CountConsonants
{
  public static int Count(string str)
  {
    return str
      .Where(x => Char.IsLetter(x) && !"aeiou".Contains(x))
      .Count();
  }
}
