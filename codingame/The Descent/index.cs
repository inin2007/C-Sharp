```
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {          
            int max = 0;
            int imax = 0;
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
                if (mountainH > max) {
                    max = mountainH;
                    imax = i;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(imax);
        }
    }
}
```
