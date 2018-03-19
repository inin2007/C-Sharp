using System;

public class Exercise53
{
    public static void Main( )
    {
        int[] x = {2, 4, 7, 8, 6};
         Console.WriteLine("Original array: [{0}]", string.Join(", ",x));
         Console.WriteLine("Check if an array contains an odd number? " +y(x));
    }
    public static bool y(int[] x)
    {
        foreach (var n in x)
        {
            if (n % 2 != 0)
            return true;
        }
        return false;
    }
}
