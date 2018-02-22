using System;
public class Exercise25
{
    public static void Main( )
    {
         Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
         for (int i = 1; i < 101; i++)
         {
             if (i % 2 != 0)
             {
         Console.WriteLine(i);
             }
         }
    }
}
