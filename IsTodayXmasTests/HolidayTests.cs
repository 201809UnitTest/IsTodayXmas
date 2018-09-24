using System;
using IsTodayXmas;
using Xunit;

namespace IsTodayXmasTests
{
    public class HolidayTests
    {
        [Fact]
        public void today_is_Xmas()
        {
            var holiday = new FakeHoliday();
//            var holiday = new Holiday();
            holiday.SetToday(new DateTime(2011,12,25));
            var response = holiday.SayXmas();
            Assert.Equal("Merry Xmas", response);
        }
    }

    internal class FakeHoliday : Holiday
    {
        private DateTime _today;

        internal void SetToday(DateTime today)
        {
            _today = today;
        }

        protected override DateTime GetToday()
        {
            return this._today;
        }
    }
}