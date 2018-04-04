using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter3;
using LaYumba.Functional.Option;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Chapter3Test
{
    [TestClass]
    public class Exercise2Test
    {
        private static Func<int, bool> IsOdd => i => i % 2 == 1;

        [TestCase()]
        // new List<int>().Lookup(isOdd) // => None
        public void TestIsOddPredicateWithEmptyList()
        {
            var result = new List<int>().Lookup(IsOdd);
            var assertVal = result.Match(
                () => true,
                val => false);

            Assert.IsTrue(assertVal);
        }

        [TestCase()]
        // new List<int> { 1 }.Lookup(isOdd) // => Some(1)
        public void TestIsOddPredicateWithPresentList()
        {
            var result = new List<int> {1}.Lookup(IsOdd);
            Assert.AreEqual(1, result);
        }
    }
}
