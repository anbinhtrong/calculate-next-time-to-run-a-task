using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateNextTimeToRunTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dt1 = new DateTime(2014, 1, 1, 1, 0, 0);
            var dt2 = new DateTime(2014, 1, 2, 1, 0, 0);
            var result = CalculateDayBetweenTwoDate(dt1, dt2);
            Console.WriteLine(result);
            var timespan = new TimeSpan(0, 5, 0);
            GetNextDayTime(timespan, dt1, dt2);
        }

        static bool GetNextDayTime(TimeSpan timespan, DateTime dt1, DateTime dt2)
        {
            var minDateTime = DateTime.MinValue;
            minDateTime.Add(timespan);
            var day1 = (dt1 - minDateTime).TotalDays;
            var day2 = (dt2 - minDateTime).TotalDays;
            Console.WriteLine(string.Format("Day 1: {0}", day1));
            Console.WriteLine(string.Format("Day 2: {0}", day2));
            Console.WriteLine("Has next day " + (day2 - day1 >= 1).ToString());
            return day2 - day1 >= 1;
        }

        static double CalculateDayBetweenTwoDate(DateTime dt1, DateTime dt2)
        {
            return (dt2 - dt1).TotalDays;
        }
    }
}
