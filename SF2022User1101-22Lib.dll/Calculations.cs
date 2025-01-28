using System;
using System.Collections.Generic;
using System.Linq;

namespace SF2022User1101_22Lib.dll
{
    public class Calculations
    {
        public string[] SetDataTrue(string startTimesAndDurations, 
            string beginWorkingTimeAndEndWorkingTime, int consultationTime)
        {
            TimeSpan[] startTimes = new TimeSpan[24];
            int[] durations = new int[24];
            TimeSpan beginWorkingTime = new TimeSpan();
            TimeSpan endWorkingTime = new TimeSpan();

            string[] vvod = startTimesAndDurations.Split(',');
            for(int i = 0; i < vvod.Length; i++)
            {
                string[] parts = vvod[i].Split(' ');

                durations[i] = Int16.Parse(parts[1]);
                startTimes[i] = TimeSpan.Parse(parts[0]);
            }

            string[] vvodTime = beginWorkingTimeAndEndWorkingTime.Split('-');
            beginWorkingTime = TimeSpan.Parse(vvodTime[0]);
            endWorkingTime = TimeSpan.Parse(vvodTime[1]);

            var result = AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            return result;
        }
        private string[] AvailablePeriods(TimeSpan[] startTimes,
            int[] durations,
            TimeSpan beginWorkingTime,
            TimeSpan endWorkingTime,
            int consultationTime)
        {
            List<string> availableIntervals = new List<string>();

            var sortedOccupiedIntervals = startTimes.Select((startTime, index) => new { StartTime = startTime, Duration = durations[index], Index = index })
                                                  .OrderBy(x => x.StartTime).ToList();

            TimeSpan lastEndTime = TimeSpan.Zero;
            bool isFirstInterval = true;

            foreach (var occupiedInterval in sortedOccupiedIntervals)
            {
                TimeSpan intervalStart = occupiedInterval.StartTime;
                TimeSpan intervalDuration = TimeSpan.FromMinutes(occupiedInterval.Duration);

                if (!isFirstInterval && lastEndTime < intervalStart)
                {
                    TimeSpan availableTime = intervalStart - lastEndTime;
                    AddAvailableInterval(availableIntervals, availableTime);
                }

                lastEndTime = intervalStart + intervalDuration;

                isFirstInterval = false;
            }

            if (lastEndTime < endWorkingTime)
            {
                TimeSpan remainingTime = endWorkingTime - lastEndTime;
                AddAvailableInterval(availableIntervals, remainingTime);
            }

            return availableIntervals.ToArray();
        }

        private static void AddAvailableInterval(List<string> availableIntervals, TimeSpan availableTime)
        {
            string formattedTime = availableTime.ToString(@"hh\:mm");
            availableIntervals.Add(formattedTime);
        }
    }
}
