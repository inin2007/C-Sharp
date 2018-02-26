using System;
using System.Collections.Generic;

public class Exercise28
{
    public static void Main( )
    {
        string x = "Display the pattern like pyramid using the alphabet.";
         Console.WriteLine("Original String: {0}", x);
         string y = "";
         List <string> jList = new List < string > ();
         string[] j = x.Split(new []{
             " "
         }, StringSplitOptions.None);
         for (int i = j.Length - 1; i >= 0; i--) {
             y += j[i] +" ";
         }
         jList.Add(y);
         foreach(String n in jList){
         Console.WriteLine("Peverse String: {0}", n);    
         }
    }
}
