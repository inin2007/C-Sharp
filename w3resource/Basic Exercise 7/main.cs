public class Exercise7
{
    public static void Main( )
    {
        int x = 25;
        int y = 4;
        int h = x+y;
        int q = x-y;
        int w = x*y;
        int e = x/y;
        int t = x%y;

           System.Console.WriteLine("{0} + {1} = {2}",x, y, h);
           System.Console.WriteLine("{0} - {1} = {2}",x, y, q);
           System.Console.WriteLine("{0} x {1} = {2}",x, y, w);
           System.Console.WriteLine("{0} / {1} = {2}",x, y, e);
           System.Console.WriteLine("{0} mod {1} = {2}",x, y, t);
    }
}

------------------------------------------------------------------------------------

public class Exercise7
{
    public static void Main( )
    {
        int x = 25;
        int y = 4;

           System.Console.WriteLine("{0} x {1} = {2}",x, y, x+y);
           System.Console.WriteLine("{0} x {1} = {2}",x, y, x-y);
           System.Console.WriteLine("{0} x {1} = {2}",x, y, x*y);
           System.Console.WriteLine("{0} x {1} = {2}",x, y, x/y);
           System.Console.WriteLine("{0} x {1} = {2}",x, y, x%y);
    }
}
