using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BodyMassIndexTest
{
    public class BodyMassIndexTests
    {
        [TestCase("1", "1", ExpectedResult = true)]
        [TestCase("2", "120", ExpectedResult = true)]
        [TestCase("1.5", "60", ExpectedResult = true)]
        public bool WhenBodyMassIndexWithValues_ThenValidBodyMassIndex(decimal height, decimal weight)
        {
            var bmi = new BodyMassIndex.BodyMassIndex(height, weight);
            var actual = weight / (height * height);
            return actual == bmi.Bmi;
        }
    }
}
