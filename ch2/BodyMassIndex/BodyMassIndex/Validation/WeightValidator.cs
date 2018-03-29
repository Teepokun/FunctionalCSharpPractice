namespace BodyMassIndex.Validation
{
    public class WeightValidator : IValidator<BodyMassIndexReport>
    {
        public bool IsValid(BodyMassIndexReport report)
        => GeneralValidation.IsDecimal(report.Weight);
    }
}
