using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyMassIndex;
using NUnit.Framework;

namespace BodyMassIndexTest
{
    public class BodyMassIndexReportTests
    {
        [TestCase("1.752", "113.398", ExpectedResult = "overweight")]
        [TestCase("1.752", "30", ExpectedResult = "underweight")]
        [TestCase("1.752", "60", ExpectedResult = "healthy")]
        public string TestMapBmiToDesignation(decimal height, decimal weight)
        {
            var bmi = new BodyMassIndex.BodyMassIndex(height, weight);
            return BodyMassIndexReport.MapBmiToDesignation(bmi);
        }
    }
}
