public class Exercise17
{
    public static void Main( )
    {
        string x = "The quick brown fox jumps over the lazy dog.";
        if (x.Length>=1)
        {
        var y = x.Substring(0,1);
        System.Console.WriteLine(y+x+y);
        }
    }
}
