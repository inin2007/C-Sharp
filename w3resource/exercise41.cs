using System;
using System.Collections.Generic;
using System.Linq;

public class Exercise41
{
    public static void Main( )
    {
        string x = "w3resource";
        var y = x.Count(s => s == 'e');
         Console.WriteLine(y >= 1 && y <= 3);
    }
}
