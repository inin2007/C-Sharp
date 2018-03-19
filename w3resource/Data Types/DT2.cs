using System;
using System.Linq;

public class DT2
{
    public static void Main( )
    {
        int num = 6;
        int width = 6;
        int height = width;
        for (int row = 0; row < height; row++)
        {
            for (int column = 0; column < width; column++)
        {
            Console.Write(num);
        }
         Console.WriteLine();
         width--;
        }
    }
}
