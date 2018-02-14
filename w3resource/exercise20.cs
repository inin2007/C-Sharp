public class Exercise20 {
  static void Main()
        {
            System.Console.WriteLine(number(3,2));
            System.Console.WriteLine(number(2,5));
            System.Console.WriteLine(number(-12,-1));          
        }
        public static int number(int a, int b)
        {
            if (a>b)
            {
                return (a-b)*2;
            }
            return b-a;
        }
}
