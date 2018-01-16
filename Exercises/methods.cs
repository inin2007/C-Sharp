using System;

public class Methods
{
    public static void Main()
    {

        int x = 2;
        int y = 2;
        int a = foo(x,y);
        Console.WriteLine(a);

    }
	
	public static int foo(int x, int y)
	{
		
	return x/y;
		
	}

}
