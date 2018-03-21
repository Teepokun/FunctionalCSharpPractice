using BodyMassIndex.Validation;

namespace BodyMassIndex
{
    public class BodyMassIndexReport
    {
        public readonly string Height;

        public readonly string Weight;

        protected readonly BodyMassIndex BmiCalculator;

        public readonly bool IsValid;

        public BodyMassIndexReport(string height, string weight)
        {
            this.Height = height;
            this.Weight = weight;

            var validation = new AllValidation();
            var areValidInputs = validation.IsValid(this);

            if (!areValidInputs) return;

            IsValid = true;

            var dWeight = GeneralValidation.MapStringToDecimal(weight);
            var dHeight = GeneralValidation.MapStringToDecimal(height);

            BmiCalculator = new BodyMassIndex(dHeight, dWeight);
        }

        public static string MapBmiToDesignation(BodyMassIndex bmi)
        {
            if (bmi.Bmi < 18.5M)
            {
                return "underweight";
            }

            if (bmi.Bmi >= 25)
            {
                return "overweight";
            }

            return "healthy";
        }

        public string GetReport()
            => FormatBmiMessage(this.BmiCalculator);

        public static string FormatBmiMessage(BodyMassIndex bmi)
            => $"For the given height: {bmi.Height} and weight: {bmi.Weight}, the BMI is {bmi.Bmi} and the designation is: {MapBmiToDesignation(bmi)}";
    }
}
