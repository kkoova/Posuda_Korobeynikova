using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SF2022User1101_22Lib.dll.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void SetDataTrueTest()
        {
            var calc = new Calculations();

            var result = calc.SetDataTrue("09:00 30","08:00-10:00",30);
        }

        [TestMethod()]
        public void SetDataTrueTestTwo()
        {
            var calc = new Calculations();

            var result = calc.SetDataTrue("09:00 30", "08:00-14:00", 30);
        }

        [TestMethod()]
        public void SetDataTrueTestTree()
        {
            var calc = new Calculations();

            var result = calc.SetDataTrue("09:00 30", "08:00-11:00", 30);
        }

        [TestMethod()]
        public void SetDataTrueTestFour()
        {
            var calc = new Calculations();

            var result = calc.SetDataTrue("09:00 30", "08:00-19:00", 30);
        }

        [TestMethod()]
        public void SetDataTrueTestFive()
        {
            var calc = new Calculations();

            var result = calc.SetDataTrue("09:00 30", "08:00-23:00", 30);
        }
    }
}