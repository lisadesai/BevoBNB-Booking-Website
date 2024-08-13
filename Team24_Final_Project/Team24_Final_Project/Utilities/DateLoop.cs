using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team24_Final_Project.Utilities
{
    public class DateLoop
    {
        public static IEnumerable<DateTime> EachDay(DateTime start, DateTime end)
        {
            for (var day = start.Date; day.Date <= end.Date; day = day.AddDays(1))
                yield return day;
        }
    }
}
