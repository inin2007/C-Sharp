using System;
using System.Linq;

public class Exercise51
{
    public static void Main( )
    {
        int[] Array1 = {1, 2, 5, 7, 8};
        var x = Array1[0];
        for (var i = 0; i < Array1.Length; i++)
        {
            if (Array1[i] > Array1[0])
            x = Array1[i];
        }
         Console.WriteLine("Array1: [" + string.Join(", ", Array1)+ "]");
         Console.WriteLine("Highest value between first and last values of the said array: "+ x);
    }
}
