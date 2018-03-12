public class Exercise42
{
    public static void Main( )
    {
        string x = "w3r";
        if (x.Length < 4)
         System.Console.WriteLine(x.ToUpper());
         else
         System.Console.WriteLine(x.Substring(0, 4).ToLower() + x.Substring(4, x.Length -4));
    }
}
