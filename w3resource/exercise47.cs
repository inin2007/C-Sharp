using System;

public class Exercise47
{
    public static void Main( )
    {
        int[] Array1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7,  7, 8, 8, 1};
        var x = 0;
        for (var i =0; i < Array1.Length; i++)
        {
            x += Array1[i];
        }
         Console.WriteLine("Sum: "+ x);
    }
}
