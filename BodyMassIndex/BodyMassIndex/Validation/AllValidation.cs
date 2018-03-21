namespace BodyMassIndex.Validation
{
    public class AllValidation : IValidator<BodyMassIndexReport>
    {
        public bool IsValid(BodyMassIndexReport report)
            => new HeightValidator().IsValid(report) &&
               new WeightValidator().IsValid(report);
    }
}
