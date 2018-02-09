public class Exercise16 {
  public static void Main()
        {
            System.Console.WriteLine(x("w3resource"));
            System.Console.WriteLine(x("Python"));
            System.Console.WriteLine(x("x"));
        }
       public static string x(string y)
        {
            return y.Length > 1
                ? y.Substring(y.Length - 1) + y.Substring(1, y.Length - 2) + y.Substring(0, 1) : y;
        }
}
