public class Exercise37
{
    public static void Main( )
    {
        string x = "PHP Tutorial";
         System.Console.WriteLine(( x.Substring(1, 2).Equals("HP") ? x.Remove(1, 2) : x));
    }
}
