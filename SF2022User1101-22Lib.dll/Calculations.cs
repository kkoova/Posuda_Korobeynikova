using System;
using System.Collections.Generic;

namespace SF2022User1101_22Lib.dll
{
    /// <summary>
    /// Библиотека для расчета графика работников
    /// </summary>
    public class Calculations
    {
        /// <summary>
        /// Расчет и возврат графика рабоников с перерывами в виде массива
        /// </summary>
        public string[] AvailablePeriods(TimeSpan[] startTimes,
            int[] durations,
            TimeSpan beginWorkingTime,
            TimeSpan endWorkingTime,
            int consultationTime)
        {
            List<TimeSpan> busyStartTimes = new List<TimeSpan>();
            List<TimeSpan> busyEndTimes = new List<TimeSpan>();

            TimeSpan workingStartTime = beginWorkingTime;
            TimeSpan workingEndTime = endWorkingTime;

            for (int i = 0; i < startTimes.Length; i++)
            {
                TimeSpan startTime = startTimes[i];
                TimeSpan duration = TimeSpan.FromMinutes(durations[i]);

                busyStartTimes.Add(startTime);
                busyEndTimes.Add(startTime + duration);
            }

            List<string> freeIntervals = new List<string>();

            TimeSpan currentTime = workingStartTime;
            while (currentTime + TimeSpan.FromMinutes(consultationTime) <= workingEndTime)
            {
                bool isFree = true;
                for (int i = 0; i < busyStartTimes.Count; i++)
                {
                    if (!(currentTime >= busyEndTimes[i] || currentTime + TimeSpan.FromMinutes(consultationTime) <= busyStartTimes[i]))
                    {
                        isFree = false;
                        break;
                    }
                }

                if (isFree)
                {
                    freeIntervals.Add($"{currentTime.ToString(@"hh\:mm")}-{(currentTime + TimeSpan.FromMinutes(consultationTime)).ToString(@"hh\:mm")}");
                    currentTime += TimeSpan.FromMinutes(consultationTime);
                }
                else
                {
                    currentTime += TimeSpan.FromMinutes(consultationTime);
                }

                if (currentTime > workingEndTime)
                {
                    break;
                }
            }

            return freeIntervals.ToArray();
        }
    }
}
