using System;
        class car{
			public int numTires = 4;
			public int year = 2000;
			public bool runs = true;
		}
			public class MainClass{
    public static void Main(){
	        car car1 = new car();
	        car car2 = new car();
			car car3 = new car();
			
        Console.WriteLine(car1.numTires);
        Console.WriteLine(car2.year);
        Console.WriteLine(car3.runs);
		}
	}
