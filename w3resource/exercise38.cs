public class Exercise38
{
    public static void Main( )
    {
        string x = "PHP";
        var result = "";
        if (x.Length >= 1 && x[0] == 'P')
        result += x[0];
        if (x.Length >= 2 && x[1] == 'H')
        result += x[1];
         System.Console.WriteLine(result);
    }
}
