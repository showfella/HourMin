using System;

namespace Anglediff
{
    class HourDiff
    {
        static int Anglediff(double h, double m)
        {

            if (h < 0 || m < 0 ||
           h > 12 || m > 60)
                Console.Write("Wrong input");

            if (h == 12)
                h = 0;

            if (m == 60)
                m = 0;

            int hour_angle = (int)(0.5 * (h * 60 + m));
            int minute_angle = (int)(6 * m);
            
            int angle = Math.Abs(hour_angle - minute_angle);
            
            angle = Math.Min(360 - angle, angle);

            return angle;
        }
             public static void Main()
             {
            Console.WriteLine(Anglediff(9, 60));
            Console.Write(Anglediff(3, 30));
        }
    }

}


