using System;

public class Exercise50
{
    public static void Main( )
    {
        int[] Array1 = {1, 2, 8};
        var x = Array1[0];
        for (var i = 0; i < Array1.Length - 1; i++)
        {
            Array1[i] = Array1[i + 1];
        }
        Array1[Array1.Length -1] = x;
         Console.WriteLine(string.Join(", ", Array1));
    }
}
