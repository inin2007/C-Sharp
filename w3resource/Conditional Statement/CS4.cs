public class CS4
{
    public static void Main( )
    {
         int x = 2016;
                  if ((x % 400) == 0)
         {
             System.Console.WriteLine("{0} is a leap year", x);
         }
                  else if ((x % 100) == 0)
         {
             System.Console.WriteLine("{0} is not a leap year", x);
         }
                  else if ((x % 4) == 0)
         {
             System.Console.WriteLine("{0} is a leap year", x);
         }
                  else 
         {
             System.Console.WriteLine("{0} is not a leap year", x);
         }
    }
}
