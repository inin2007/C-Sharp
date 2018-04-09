public class CS8
{
    public static void Main( )
    {
        int num1, num2, num3;
        num1 = 25;
        num2 = 63;
        num3 = 10;
        if ((num1 > num2) && (num1 > num3))
         System.Console.WriteLine("The 1nd Number is the greatest among three");
         else if ((num1 < num2) && (num2 > num3))
         System.Console.WriteLine("The 2nd Number is the greatest among three");
         else
         System.Console.WriteLine("The 3nd Number is the greatest among three");
    }
}
