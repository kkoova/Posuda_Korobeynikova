using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SF2022User1101_22Lib.dll.Tests
{
    /// <summary>
    /// Тесты для библиотеки <see cref="Calculations"/>
    /// </summary>
    [TestClass()]
    public class CalculationsTests
    {
        /// <summary>
        /// Тест 1: Одно значение
        /// </summary>
        [TestMethod]
        public void SetDataTrueTest_EmptySchedule()
        {
            var expectedOutput = new[]
            {
                "08:30-09:00",
                "09:00-09:30",
                "09:30-10:00",
                "10:00-10:30",
                "10:30-11:00",
                "11:00-11:30",
                "11:30-12:00",
                "12:00-12:30",
                "12:30-13:00",
                "13:00-13:30",
                "13:30-14:00"
            };

            var result = SetDataTrue("08:00 30", "08:00-14:00", 30);

            CollectionAssert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Тест 2: График полностью занят
        /// </summary>
        [TestMethod]
        public void SetDataTrueTest_FullSchedule()
        {
            var result = SetDataTrue("08:00 360", "08:00-14:00", 30);

            Assert.AreEqual(0, result.Length);
        }

        /// <summary>
        /// Тест 3: Сравнение значений
        /// </summary>
        [TestMethod]
        public void SetDataTrueTest_ShortIntervals()
        {
            var expectedOutput = new[]
            {
                "08:00-08:30",
                "08:30-09:00",
                "09:30-10:00",
                "10:30-11:00",
                "11:30-12:00",
                "12:00-12:30",
                "12:30-13:00",
                "13:00-13:30",
                "13:30-14:00",
            };

            var result = SetDataTrue("09:00 30,10:00 30,11:00 30", "08:00-14:00", 30);

            CollectionAssert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Тест 4: Разные консультации (60 минут)
        /// </summary>
        [TestMethod]
        public void SetDataTrueTest_LongConsultation()
        {
            var expectedOutput = new[]
            {
                "08:00-09:00",
                "10:00-11:00",
                "12:00-13:00",
                "13:00-14:00"
            };

            var result = SetDataTrue("09:30 30,11:30 30", "08:00-14:00", 60);

            CollectionAssert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Тест 5: Начало и конец рабочего дня не совпадают с началом и концом интервала
        /// </summary>
        [TestMethod]
        public void SetDataTrueTest_NonStandardWorkingHours()
        {
            var expectedOutput = new[]
            {
                "09:00-09:30",
                "09:30-10:00",
                "10:00-10:30",
                "10:30-11:00",
                "11:00-11:30",
                "11:30-12:00",
                "12:00-12:30",
                "12:30-13:00",
                "13:00-13:30",
                "13:30-14:00",
                "14:00-14:30",
                "14:30-15:00",
                "15:00-15:30",
                "15:30-16:00",
                "16:00-16:30",
                "16:30-17:00",
                "17:00-17:30",
                "17:30-18:00"
            };

            var result = SetDataTrue("08:30 30,18:30 30", "09:00-18:00", 30);

            CollectionAssert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Тест 6: Сравнение значений
        /// </summary>
        [TestMethod]
        public void SetDataTrueTest()
        {
            // Arrange
            var expectedOutput = new[]
            {
                "08:00-08:30",
                "08:30-09:00",
                "09:30-10:00",
                "10:00-10:30",
                "10:30-11:00",
                "11:00-11:30",
                "11:30-12:00",
                "12:00-12:30",
                "12:30-13:00",
                "13:30-14:00",
            };

            // Act
            var result = SetDataTrue("09:00 30,13:00 30", "08:00-14:00", 30);

            // Assert
            CollectionAssert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Тест 7: Частично занятый график
        /// </summary>
        [TestMethod]
        public void SetDataTrueTest_PartiallyBusySchedule()
        {
            var expectedOutput = new[]
            {
                "08:00-08:30",
                "08:30-09:00",
                "09:00-09:30",
                "10:00-10:30",
                "10:30-11:00",
                "11:00-11:30",
                "11:30-12:00",
                "12:00-12:30",
                "12:30-13:00",
                "13:00-13:30",
                "13:30-14:00",
            };

            var result = SetDataTrue("09:30 30", "08:00-14:00", 30);

            CollectionAssert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Тест 8: Интервалы пересекаются
        /// </summary>
        [TestMethod]
        public void SetDataTrueTest_OverlappingIntervals()
        {
            var expectedOutput = new[]
            {
                "08:00-08:30",
                "08:30-09:00",
                "10:00-10:30",
                "10:30-11:00",
                "11:00-11:30",
                "11:30-12:00",
                "12:00-12:30",
                "12:30-13:00",
                "13:00-13:30",
                "13:30-14:00",
            };

            var result = SetDataTrue("09:00 45,09:30 30", "08:00-14:00", 30);

            CollectionAssert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Тест 9: Минимальное консультационное время больше чем рабочий день
        /// </summary>
        [TestMethod]
        public void SetDataTrueTest_ConsultationTimeLargerThanWorkingDay()
        {
            var result = SetDataTrue("07:00 10", "08:00-14:00", 420); // 7 часов в минутах

            Assert.AreEqual(0, result.Length);
        }

        /// <summary>
        /// Тест 10: График с короткими интервалами и небольшой консультацией
        /// </summary>
        [TestMethod]
        public void SetDataTrueTest_ShortIntervalsAndSmallConsultation()
        {
            var expectedOutput = new[]
            {
                "08:00-08:10",
                "08:10-08:20",
                "08:20-08:30",
                "08:30-08:40",
                "08:40-08:50",
                "08:50-09:00",
                "09:00-09:10",
                "09:30-09:40",
                "09:40-09:50",
                "09:50-10:00",
                "10:00-10:10",
                "10:30-10:40",
                "10:40-10:50",
                "10:50-11:00",
                "11:00-11:10",
                "11:30-11:40",
                "11:40-11:50",
                "11:50-12:00",
                "12:00-12:10",
                "12:10-12:20",
                "12:20-12:30",
                "12:30-12:40",
                "12:40-12:50",
                "12:50-13:00",
                "13:00-13:10",
                "13:10-13:20",
                "13:20-13:30",
                "13:30-13:40",
                "13:40-13:50",
                "13:50-14:00"
            };
                
            var result = SetDataTrue("09:15 10,10:15 10,11:15 10", "08:00-14:00", 10);
                
            CollectionAssert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Приравнивание значения к правильной форме
        /// </summary>
        public string[] SetDataTrue(string startTimesAndDurations,
            string beginWorkingTimeAndEndWorkingTime, int consultationTime)
        {
            var calc = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[24];
            int[] durations = new int[24];
            TimeSpan beginWorkingTime = new TimeSpan();
            TimeSpan endWorkingTime = new TimeSpan();

            string[] vvod = startTimesAndDurations.Split(',');
            for (int i = 0; i < vvod.Length; i++)
            {
                string[] parts = vvod[i].Split(' ');

                durations[i] = Int16.Parse(parts[1]);
                startTimes[i] = TimeSpan.Parse(parts[0]);
            }

            string[] vvodTime = beginWorkingTimeAndEndWorkingTime.Split('-');
            beginWorkingTime = TimeSpan.Parse(vvodTime[0]);
            endWorkingTime = TimeSpan.Parse(vvodTime[1]);

            return calc.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);
        }
    }
}

