namespace BodyMassIndex.Validation
{
    public class HeightValidator : IValidator<BodyMassIndexReport>
    {
        public bool IsValid(BodyMassIndexReport type)
            => GeneralValidation.IsDecimal(type.Height);
    }
}
