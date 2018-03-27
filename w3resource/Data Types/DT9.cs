public class DT9
{
    public static void Main( )
    {
        char symbol = 'a';
         if (( symbol == 'a') || (symbol == 'e' || symbol == 'i') || (symbol == 'o' || symbol == 'u'))
         System.Console.WriteLine("It's a lowercase vowel.");   
         else if (( symbol >= '0') && ( symbol <= '9'))
         System.Console.WriteLine("It's a digit.");       
         else
         System.Console.WriteLine("It's any other symbol.");         
    }
}
