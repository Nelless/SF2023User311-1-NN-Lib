using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SF2022User311_1_NN_Lib
{
    public class CorrectString
    {
        public static bool IsCorrectTimeString(string time)
        {
            string reg = @"^[0-2][0-9]\:[0-5][0-9]$";
            if (Regex.IsMatch(time, reg))
            {
                if (Regex.IsMatch(time, @"^2[0-9]\:[0-5][0-9]$"))
                {
                    if (Regex.IsMatch(time, @"^2[0-3]\:[0-5][0-9]$"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static bool IsCorrectDurationString(string duration)
        {
            string reg = @"^[1-6][0-9]$";
            if (Regex.IsMatch(duration, reg) || Regex.IsMatch(duration, @"^[0-9]$"))
            {
                if (Regex.IsMatch(duration, @"^6[1-9]$"))
                {
                    return false;
                }
                return true;

            }
            return false;
        }
    }
}
