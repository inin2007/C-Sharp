public class DT7
{
    public static void Main( )
    {
        float m, hr, min, sec, time;
        m = 50000;
        hr = 1;
        min = 35;
        sec = 56;
        time = hr*60*60 + min*60 + sec;
         System.Console.WriteLine("Your speed in meters/sec is "+ m/time);
         System.Console.WriteLine("Your speed in km/h is "+ ((m*0.001f)/(time/3600f)));
         System.Console.WriteLine("Your speed in miles/h is "+ ((m*0.00062137f)/(time/3600f)));
    }
}
