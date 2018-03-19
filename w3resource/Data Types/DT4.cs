using System;
public class DT4
{
public static void Main()
{
int num1, num2;
char oper; 

num1 = 20;
num2 = 12;
oper = '-';

  if (oper=='+')
         Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2);
  else if (oper=='-')
         Console.WriteLine("{0} - {1} = {2}", num1, num2, num1-num2);
  else if ((oper=='*') || (oper=='x'))
         Console.WriteLine("{0} * {1} = {2}", num1, num2, num1*num2);    
  else if (oper=='/')
         Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);       
         else
         Console.WriteLine("Wrong Character");
      }
}
