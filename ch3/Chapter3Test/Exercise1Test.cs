using System.Linq;
using System.Runtime.Remoting.Messaging;
using Chapter3;
using LaYumba.Functional.Option;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DayOfWeek = System.DayOfWeek;

namespace Chapter3Test
{
    [TestClass]
    public class Exercise1Test
    {
        [TestCase("Monday", ExpectedResult = DayOfWeek.Monday)]
        [TestCase("Tuesday", ExpectedResult = DayOfWeek.Tuesday)]
        [TestCase("Wednesday", ExpectedResult = DayOfWeek.Wednesday)]
        [TestCase("Thursday", ExpectedResult = DayOfWeek.Thursday)]
        [TestCase("Friday", ExpectedResult = DayOfWeek.Friday)]
        [TestCase("Saturday", ExpectedResult = DayOfWeek.Saturday)]
        [TestCase("Sunday", ExpectedResult = DayOfWeek.Sunday)]
        public DayOfWeek AssertNormalDaysWorks(string v)
        {
            var result = Exercise1.Parse<DayOfWeek>(v);
            return result.AsEnumerable().First();
        }

        [TestCase(ExpectedResult = true)]
        public bool AssertAbnormalDaysReturnNone()
        {
            return Exercise1.Parse<DayOfWeek>("Funday")
                .Match(
                    () => true,
                    val => false);
        }
    }
}
