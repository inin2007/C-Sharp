using System;
public class Exercise24
{
    public static void Main( )
    {
        string x = "WRITE A C# SHARP PROGRAM TO DISPLAY THE FOLLOWING PATTERN USING THE ALPHABET.";
        string[] y = x.Split(new[] { " " }, StringSplitOptions.None);
        string k = "";
        int i = 0;
        foreach (String j in y)
        {
            if (j.Length > i)
            {
                k = j;
                i = j.Length;
            }
        }
         Console.WriteLine(k);
    }
}
