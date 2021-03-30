using System;

namespace AngleMinHoursArrow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hours:");
            string s = Console.ReadLine();
            double h = double.Parse(s);
            Console.WriteLine("Minutes:");
            s = Console.ReadLine();
            double m = double.Parse(s);
            double angle = Math.Abs((h + m/60.0) * 30.0 - m * 6.0);
            angle = Math.Min(360 - angle, angle);
            Console.WriteLine("Angle is {0}", angle);
        }
    }
}
