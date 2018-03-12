using System;

public class Exercise43
{
    static void Main()
    {
       string x = "www"; 
    }
    public static bool b(string x )
    {
        var y = 0;
        for(var i = 0; i < x.Length-1; i++)
        {
            if (x[i].Equals('w')) y++;
            if (x.Substring(i, 2).Equals("ww") && y > 2)
            return true;
        }
        return false;
    }
}
