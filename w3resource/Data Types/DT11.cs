using System;
public class DT11
{
  public static void Main()
  {   
    string answer;  
    string result; 
  
        answer = "7";
         
            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }
   }
