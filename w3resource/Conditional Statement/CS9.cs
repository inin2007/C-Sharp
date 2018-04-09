public class CS9
{
    public static void Main( )
    {
        int x, y;
        x = 0;
        y = 0;
         System.Console.WriteLine("Input the value for X coordinate :{0}", x);
         System.Console.WriteLine("Input the value for Y coordinate :{0}", y);
         if (x > 0 && y > 0)
         System.Console.WriteLine("The coordinate point ({0},{1}) lies in the First quadrant.", x, y);
         else if (x < 0 && y > 0)
         System.Console.WriteLine("The coordinate point ({0},{1}) lies in the Second quadrant.", x, y);
         else if (x < 0 && y < 0)
         System.Console.WriteLine("The coordinate point ({0},{1}) lies in the Third quadrant.", x, y);
         else if (x > 0 && y < 0)
         System.Console.WriteLine("The coordinate point ({0},{1}) lies in the Fourth quadrant.", x, y);
         else 
         System.Console.WriteLine("The coordinate point ({0},{1}) lies at the origin.", x, y);
    }
}
