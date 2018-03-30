using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
