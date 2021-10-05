using System;

namespace DatetimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //returns current date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current DateTime : " + currentDateTime);

            // returns today's date
            DateTime todaysDate = DateTime.Today;
            Console.WriteLine("Today's Date : " + todaysDate);

            // returns current UTC date and time
            DateTime currentDateTimeUTC = DateTime.UtcNow;
            Console.WriteLine("Current Datetime in UTC : " + currentDateTimeUTC);

            //return default value 01/01/0001 00:00:00
            DateTime defaultDateValue = new DateTime();
            Console.WriteLine("Set Default Date : " + defaultDateValue);

            //set the date - year, month, day
            DateTime setDateValue = new DateTime(2021, 10, 01);
            Console.WriteLine("Set the Date : " + setDateValue);

            //set the date time - year, month, day, hour, min, seconds
            DateTime setDateTimeValue = new DateTime(2021, 10, 01, 5, 10, 20);
            Console.WriteLine("Set the Date Time : " + setDateTimeValue);

            //set the datetime - year, month, day, hour, min, seconds, UTC timezone
            DateTime setDateTimeInUtcZone = new DateTime(2021, 10, 01, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine("Set the Date Time in UTC : " + setDateTimeInUtcZone);

            //we can add the datetime to other.
            //timespan have days, hour, min, sec.
            DateTime addDatetime = new DateTime(2021, 12, 31);
            TimeSpan settimeSpan = new TimeSpan(24, 20, 55);
            DateTime newAddDatetime = addDatetime.Add(settimeSpan);
            Console.WriteLine("New DateTime Added : " + newAddDatetime);

            //we can subtraction the datetime.
            DateTime datetimenow = DateTime.Now;
            DateTime datetimeold = new DateTime(2019, 2, 2);
            int result = datetimenow.Subtract(datetimeold).Days;
            Console.WriteLine("Subtract datetimenew from old datetime : " + result + " Days");
        }
    }
}
