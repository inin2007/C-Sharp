using System;
public class Exercise27 {
 public static void Main() {
   int n = 12;  
  Console.Write("Input  a number(integer):{0} ", n);
  int sum = 0;
  while (n != 0) {
   sum += n % 10;
   n /= 10;
  }
  Console.WriteLine("\nSum of the digits of the said integer: " + sum);
 }
}
