using System;
using System.Linq;

public class Exercise45
{
    static void Main()
    {
       int x = 5; 
       int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
       Console.WriteLine("Number of "+ x +" present in the said array: " + nums.Count(n => n == x));
    }
}
