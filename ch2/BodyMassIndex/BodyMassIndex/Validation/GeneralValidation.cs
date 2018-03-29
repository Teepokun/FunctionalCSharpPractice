namespace BodyMassIndex.Validation
{
    public static class GeneralValidation
    {
        public static bool IsDecimal(string value)
        {
            return int.TryParse(value, out _);
        }

        public static decimal MapStringToDecimal(string value)
            => decimal.Parse(value);
    }
}
