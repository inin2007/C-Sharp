public class Exercise1
{
    public static void Main( )
    {
        string x = "w3resource";
        //x = x.Substring(1);
         System.Console.WriteLine("{0}", x.Remove(1, 1));
         System.Console.WriteLine("{0}", x.Remove(x.Length - 1));
         System.Console.WriteLine("{0}", x.Substring(1));
    }
}
