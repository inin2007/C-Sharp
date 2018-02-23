using System;
public class Exercise26
{
    public static void Main( )
    {
         Console.WriteLine("Sum of the first 500 prime numbers:");
         long x = 0;
         int y = 0;
         int j = 2;
         while (y < 500)
         {
             if (h(j))
             {
                 x += j;
                 y++;
             }
             j++;
         }
         Console.WriteLine(x.ToString());
    }
    public static bool h(int i)
    {
        int n = (int)Math.Floor(Math.Sqrt(i));
        
        if (i == 1) return false;
        if (i == 2) return true;
        
        for (int q = 2; q <= n; ++q)
        {
            if (i%q == 0) return false;
        }
        return true;
    }
}
