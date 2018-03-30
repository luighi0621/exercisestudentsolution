using System;
using static StudentSolution.Helpers.Enums;

namespace StudentSolution.Helpers
{
    public static class ConvertHelpers
    {
        public static char ConvertEnumGenderToChar(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return 'M';
            }
            else
            {
                return 'F';
            }
        }

        public static string ConvertToTimeStamp(DateTime date)
        {
            return date.ToString("yyyyMMddHHmmss");
        }

        public static Gender ConvertToGender(string stringGender)
        {
            char valueToCompare = stringGender[0];
            if (valueToCompare == 'M')
            {
                return Gender.Male;
            }
            else
            {
                return Gender.Female;
            }
        }

        public static DateTime ConvertToDate(string timeStamp)
        {
            try
            {
                int year = int.Parse(timeStamp.Substring(0, 4));
                int month = int.Parse(timeStamp.Substring(4, 2));
                int day = int.Parse(timeStamp.Substring(6, 2));
                int hour = int.Parse(timeStamp.Substring(8, 2));
                int minute = int.Parse(timeStamp.Substring(10, 2));
                int sec = int.Parse(timeStamp.Substring(12, 2));
                return new DateTime(year, month, day, hour, minute, sec);
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
            
        }
    }
}
