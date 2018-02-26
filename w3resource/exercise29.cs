using System;
using System.Collections.Generic;
using System.IO;

public class Exercise29 {
 public static void Main() {
        FileInfo f = new FileInfo("/home/students/abc.txt");
        Console.WriteLine("\nSize of a file: "+f.Length.ToString());
 }
}
