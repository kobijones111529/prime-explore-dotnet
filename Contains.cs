public class Contains
{
  public static bool Check(object[] a, object x)
  {
    foreach (object e in a)
    {
      if (Object.Equals(e, x)) return true;
    }
    return false;
  }
}
