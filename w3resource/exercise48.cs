using System;

public class Exercise48
{
    public static void Main( )
    {
        int[] Array1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7,  7, 8, 8, 1};
         Console.WriteLine((Array1.Length >= 1) && (Array1[0].Equals(Array1[Array1.Length - 1])));
    }
}
