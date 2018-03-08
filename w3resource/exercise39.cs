using System;
using System.Collections.Generic;

public class Exercise39
{
    public static void Main( )
    {
        int x = 15;
        int y = 25;
        int z = 30;
         Console.WriteLine("Largest of three: "+ Math.Max(x, Math.Max(y, z)));
         Console.WriteLine("Lowest of three: "+ Math.Min(x, Math.Min(y, z)));
    }
}
