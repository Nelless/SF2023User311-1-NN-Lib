using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SF2023User311_1_NN_Lib;

namespace SF2023User311_1_NN_LibConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculations calc = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[] { new TimeSpan(10, 00, 00), new TimeSpan(11, 00, 00), new TimeSpan(15, 00, 00), new TimeSpan(15, 30, 00), new TimeSpan(16, 50, 00) };
            int[] duration = new int[] { 60, 30, 10, 10, 40 };
            int consultationTime = 30;
            TimeSpan startWorkingTime = new TimeSpan(08, 00, 00);
            TimeSpan endWorkingTime = new TimeSpan(18, 00, 00);

            TimeSpan consultation = TimeSpan.FromMinutes(consultationTime);

            List<string> intervals = new List<string>
            {
                startTimes[0].ToString(),
                startTimes[1].ToString(),
                startTimes[2].ToString(),
                startTimes[3].ToString(),
                startTimes[4].ToString(),
            };

            List<int> durations = new List<int>{

                duration[0],
                duration[1],
                duration[2],
                duration[3],
                duration[4]

            };

            Console.ReadKey();
        }
    }
}
