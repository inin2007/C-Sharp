using System;
public class Exercise32
{
    public static void Main( )
    {
        string x = "The quick brown fox jumps over the lazy dog.";
        int y = 0;
         Console.WriteLine("Input a string : "+ x);
         if (x.Length > 4)
         {
             Console.WriteLine(x.Length < 4 ? x + x + x : x.Substring(x.Length - 4)+ x.Substring(x.Length - 4)+x.Substring(x.Length - 4)+ x.Substring(x.Length - 4));
         }
    }
}
