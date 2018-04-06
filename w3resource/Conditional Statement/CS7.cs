public class CS7
{
    public static void Main( )
    {
        float height = 165;
        if (height < 150.0)
         System.Console.WriteLine("This person is Dwarf.");
         else if ((height >= 150.0) && (height < 165.0))
         System.Console.WriteLine("This person is average heighted.");
         else if ((height >= 165.0) && (height < 195.0))
         System.Console.WriteLine("This person is taller.");
         else
         System.Console.WriteLine("Abnormal height.");
    }
}
