using System;

public class Exercise44
{
    static void Main()
    {
       string x = "w3resource"; 
       var result = string.Empty;
       for (var i = 0; i < x.Length; i++)
       {
           if (i % 2 == 0) result += x[i];
       }
       Console.WriteLine(result);
    }
}
