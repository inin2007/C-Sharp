using System;

public class Exercise49
{
    public static void Main( )
    {
        int[] Array1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7,  7, 8, 8, 1};
        int[] Array2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7,  7, 8, 8, 5};
         Console.WriteLine((Array1[0].Equals(Array2[0])) || (Array1[Array1.Length - 1].Equals(Array2[Array2.Length -1])));
    }
}
