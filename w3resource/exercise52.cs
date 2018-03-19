public class Exercise52
{
    public static void Main( )
    {
        int[] x = {1, 2, 5};
        int[] y = {0, 3, 8};
        int[] z = {-1, 0, 2};
        int[] NewArray = {x[1], y[1], z[1]};
         System.Console.WriteLine("Array1: [" + string.Join(", ",x) + "]");
         System.Console.WriteLine("Array2: [" + string.Join(", ",y) + "]");
         System.Console.WriteLine("Array3: [" + string.Join(", ",z) + "]");
         System.Console.WriteLine("New Array: [" + string.Join(", ",NewArray) + "]");
    }
}
