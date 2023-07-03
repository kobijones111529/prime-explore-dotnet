public class SumPositives
{
  public static int Sum(int[] arr)
  {
    return arr
      .Where(x => x > 0)
      .Sum();
  }
}
