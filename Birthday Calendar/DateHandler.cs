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
            DateTime nextBday = getNextBirthday(dateOfBirth);
            return (nextBday >= DateTime.Today)
               && (nextBday <= DateTime.Today + remindInAdvanceTimeSpan);
        }

        public static DateTime getNextBirthday(DateTime dateOfBirth)
        {
            int year =
                dateOfBirth.Month > DateTime.Today.Month || (dateOfBirth.Month == DateTime.Today.Month && dateOfBirth.Day >= DateTime.Today.Day)
                ? DateTime.Today.Year
                : DateTime.Today.Year + 1;
            return new DateTime(year, dateOfBirth.Month, dateOfBirth.Day);
        }
    }
}
