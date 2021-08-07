namespace ParkCostCalc.Core.Helpers
{
    public class MinuteConvertor
    {
        private const int MinutesPerHour = 60;
        private const int HoursPerDay = 24;

        public static int Hours(int hours)
        {
            return DaysAndHoursAndMinutes(0, hours, 0);
        }

        public static int Days(int days)
        {
            return DaysAndHoursAndMinutes(days, 0, 0);
        }

        public static int HoursAndMinutes(int hours, int minutes)
        {
            return DaysAndHoursAndMinutes(0, hours, minutes);
        }

        public static int DaysAndHoursAndMinutes(int days, int hours, int minutes)
        {
            return (days * HoursPerDay + hours) * MinutesPerHour + minutes;
        }
    }
}