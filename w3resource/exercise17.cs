public class Exercise17
{
    public static void Main( )
    {
        var x = "The quick brown fox jumps over the lazy dog.";
        var y = x.Substring(0,1);
        System.Console.WriteLine(y+x+y);
    }
}
