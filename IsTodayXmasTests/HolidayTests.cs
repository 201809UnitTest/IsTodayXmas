using System;
using IsTodayXmas;
using Xunit;

namespace IsTodayXmasTests
{
    public class HolidayTests
    {
        private FakeHoliday _holiday = new FakeHoliday();

        [Fact]
        public void today_is_Xmas()
        {
            GivenToday(month: 12, day: 25);
            SayXmasShouldResponse(expected: "Merry Xmas");
        }

        private void SayXmasShouldResponse(string expected)
        {
            Assert.Equal(expected, _holiday.SayXmas());
        }

        private void GivenToday(int month, int day)
        {
            _holiday.SetToday(new DateTime(2011, month, day));
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