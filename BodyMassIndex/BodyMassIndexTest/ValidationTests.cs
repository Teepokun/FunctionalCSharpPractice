using System;
using BodyMassIndex;
using BodyMassIndex.Validation;
using NUnit.Framework;

namespace BodyMassIndexTest
{
    public class ValidationTests
    {
        [TestCase("foobar", ExpectedResult = false)]
        [TestCase("50", ExpectedResult = true)]
        public bool WhenHeightIsValue_ThenValidatorSucceedsOrFails(string height)
        {
            var validator = new HeightValidator();
            return validator.IsValid(new BodyMassIndexReport(height, string.Empty));
        }

        [TestCase("foobar", ExpectedResult = false)]
        [TestCase("50", ExpectedResult = true)]
        public bool WhenWeightIsValue_ThenValidatorSucceedsOrFails(string weight)
        {
            var validator = new WeightValidator();
            return validator.IsValid(new BodyMassIndexReport(string.Empty, weight));
        }

        [TestCase("foobar", "foobar", ExpectedResult = false)] // false false
        [TestCase("foobar", "3", ExpectedResult = false)]      // false true
        [TestCase("3", "foobar", ExpectedResult = false)]      // true false
        [TestCase("3", "4", ExpectedResult = true)]            // true true
        public bool WhenHeightAndWeightAreValues_ThenValidatorSucceedsOrFails(string height, string weight)
        {
            var validator = new AllValidation();
            return validator.IsValid(new BodyMassIndexReport(height, weight));
        }
    }
}
