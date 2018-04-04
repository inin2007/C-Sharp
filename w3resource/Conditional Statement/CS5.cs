public class CS5
{
    public static void Main( )
    {
         int x = 21;
                  if (x >= 18)
         {
             System.Console.WriteLine("Congratulation! You are eligible for casting your vote.");
         }
                  else 
         {
             System.Console.WriteLine("Sorry! You are not eligible for casting your vote.");
             System.Console.WriteLine("Youwould be able to caste your vote after {0} years.", 18-x);
         }
         }
}
