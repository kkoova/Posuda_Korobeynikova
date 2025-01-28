using System;

namespace SF2022User1101_22Lib.dll
{
    public class Calculations
    {
        public string AvailablePeriods(TimeSpan[] startTimes,
            int[] durations,
            TimeSpan beginWorkingTime,
            TimeSpan endWorkingTime,
            int consultationTime)
        {
            var vvod = "";
            var booll = false;
            var i = 0;

            Console.WriteLine(vvod);

            if (vvod.Length < 8) return null;
            string[] parts = vvod.Split(' ');

            startTimes[i] = TimeSpan.Parse(parts[0]);
            durations[i] = Int16.Parse(parts[1]);

            i++;
            
            return 
        }
    }
}
