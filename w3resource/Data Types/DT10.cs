using System;
public class DT10
{
    public static void Main( )
    {
        int n1, n2;
        bool bothEven;
        n1 = 4;
        n2 = 8;
        
        bothEven = ((n1 % 2 == 0) && (n2 % 2 == 0))? true : false;
        
      Console.WriteLine( bothEven ?
        "There're numbers bothEven." : 
        "There's a number odd.");
    }
}
