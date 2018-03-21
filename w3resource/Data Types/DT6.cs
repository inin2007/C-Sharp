public class DT6
{
    public static void Main( )
    {
        int x, y;
        
         System.Console.WriteLine("x = y² - 2y + 1");

         for (y = -5; y <= 5; y++)
         {
             x = y*y - 2*y +1;
             System.Console.WriteLine("y = {0} ; x=({0})² - 2*({0}) +1 = {1}",
                y, x);
         }
    }
}
