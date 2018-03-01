using System;
public class Exercise31
{
    public static void Main( )
    {
        int[] x = {1, 3, -5, 4};
        int[] y = {1, 4, -5, -2};
         Console.WriteLine("Array1: [{0}]", string.Join(", ",x));
         Console.WriteLine("Array2: [{0}]", string.Join(", ",y));
         Console.WriteLine("Multiple corresponding elements of two arrays:");
         for (int i = 0; i < x.Length; i++)
         {
            Console.Write(x[i] * y[i]+" "); 
         }
    }
}
