using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level02
{
    internal class TimeZonesAndDateTimeOffset
    {
        public static string TimeZone(string timeZoneId, string zoneName)
        {
            // get the current utc time
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;

            // find the time zone using time zone info

            TimeZoneInfo zone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

            // convert utc time to the target time zone

            DateTimeOffset convertedTime = TimeZoneInfo.ConvertTime(utcTime, zone);

            return $"{zoneName} Time: {convertedTime:yyyy-MM-dd HH:mm:ss}";


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Current Time in different Time zone");

            // GMT — Greenwich Mean Time (UTC)
            string gmt = TimeZone("GMT Standard Time", "GMT");

            // IST — Indian Standard Time
            string ist = TimeZone("India Standard Time", "IST");

            // PST — Pacific Standard Time
            string pst = TimeZone("Pacific Standard Time", "PST");

            Console.WriteLine(gmt);
            Console.WriteLine(ist);
            Console.WriteLine(pst);
        }
    }
}
