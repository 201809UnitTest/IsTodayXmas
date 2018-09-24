using System;

namespace IsTodayXmas
{
    public class Holiday
    {
        public string SayXmas()
        {
            var today = GetToday();
            if (today.Month==12 && (today.Day==24 ||today.Day==25))
            {
                return "Merry Xmas";
            }

            return "Today is not Xmas";
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Today;
        }
    }
}