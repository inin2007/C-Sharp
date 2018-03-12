using System;
using System.Linq;

public class Exercise46
{
    static void Main()
    {
       int x = 25; 
       int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
       Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));
    }
}
