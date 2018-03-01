using System;
public class Exercise30
{
    public static void Main( )
    {
        string x = "4B0";
         Console.WriteLine("Hexadecimal number: "+x);
         int y = int.Parse(x, System.Globalization.NumberStyles.HexNumber);
         Console.WriteLine("Convert to-");
         Console.WriteLine("Decimal number: "+y);
    }
}
