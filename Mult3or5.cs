public class Multiples
{
  public static int Solution(int value)
  {
    return Enumerable
      .Range(3, Math.Max(0, value - 3))
      .Where(x => x % 3 == 0 || x % 5 == 0)
      .Sum();
  }
}
