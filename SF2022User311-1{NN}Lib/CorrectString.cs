using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User311_1_NN_Lib
{
    public class CorrectString
    {
        public static bool IsCorrectString()
        {
            string eventTypeComboBoxString = @"^([1-4]{1})";
            string timeTextBoxString = @"^(([00-23]{1})[:]([00-59]{1}))";
            string durationTextBoxstring = @"^([00-60])";
            return true;
        }
    }
}
