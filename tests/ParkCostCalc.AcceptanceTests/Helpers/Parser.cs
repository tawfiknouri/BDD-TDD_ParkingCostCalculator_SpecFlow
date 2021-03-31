using System.Text.RegularExpressions;

namespace ParkingCostCalculator.Specs.Helpers
{
    public class Parser
    {
        private const int MinutesPerHour = 60;
        private const int MinutesPerDay  = 24 * MinutesPerHour;
        private const int MinutesPerWeek = 7 * MinutesPerDay;

        public static int ParseDuration(string duration)
        {
            int totalMinutes = 0;

            totalMinutes += ParseWeeks(duration) * MinutesPerWeek;
            totalMinutes += ParseDays(duration) * MinutesPerDay;
            totalMinutes += ParseHours(duration) * MinutesPerHour;
            totalMinutes += ParseMinutes(duration);

            return totalMinutes;
        }

        public static decimal ParseCost(string duration)
        {
            string dayPattern = @"(\d+)";
            Match match = Regex.Match(duration, dayPattern);
            if (match.Success)
            {
                string minText = match.Groups[1].Value;
                return decimal.Parse(minText);
            }

            return 0;
        }


        private static int ParseWeeks(string duration)
        {
            return ParseNumberAccordingToPattern(@"(\d+)\s?week(s)?", duration);
           // return ParseNumberAccordingToPattern(@"(\d+)\s?(week(s)|semaine(s))?", duration);
        }

        private static int ParseDays(string duration)
        {
            return ParseNumberAccordingToPattern(@"(\d+)\s?day(s)?", duration);
        }

        private static int ParseHours(string duration)
        {
            Match match = Regex.Match(duration, @"(\d+)\s?hour(s)?");
            if (match.Success)
            {
                string minText = match.Groups[1].Value;
                return int.Parse(minText);
            }

            return 0;
        }

        private static int ParseMinutes(string duration)
        {
            Match match = Regex.Match(duration, @"(\d+)\s?minute(s)?");
            if (match.Success)
            {
                string minText = match.Groups[1].Value;
                return int.Parse(minText);
            }

            return 0;
        }

        private static int ParseNumberAccordingToPattern(string dayPattern, string duration)
        {
            Match match = Regex.Match(duration, dayPattern);
            if (match.Success)
            {
                string minText = match.Groups[1].Value;
                return int.Parse(minText);
            }

            return 0;
        }
    }
}