using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Calendar
{
    class DateHandler
    {
        public static TimeSpan remindInAdvanceTimeSpan = new TimeSpan(30, 0, 0, 0);
        public static TimeSpan timSpaneToBirthday(DateTime dateOfBirth)
        {
            return getNextBirthday(dateOfBirth) - DateTime.Today;
        }

        public static bool birthdayIsNearing(DateTime dateOfBirth)
        {
            return (getNextBirthday(dateOfBirth) >= DateTime.Today)
               && (getNextBirthday(dateOfBirth) <= DateTime.Today + remindInAdvanceTimeSpan);
        }

        public static DateTime getNextBirthday(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            int year =
                dateOfBirth.Month >= today.Month && dateOfBirth.Day >= today.Day
                ? today.Year
                : today.Year + 1;
            return new DateTime(year, dateOfBirth.Month, dateOfBirth.Day);
        }
    }
}
