using System;
using System.Collections.Generic;

public class Exercise40
{
    public static void Main( )
    {
        int firstInteger = 15;
        int secondInteger = 12;
        int value = 20;
        var x = Math.Abs(firstInteger - value);
        var y = Math.Abs(secondInteger - value);
         Console.WriteLine(x == y ? 0 : (x < y ? firstInteger : secondInteger));
    }
}
