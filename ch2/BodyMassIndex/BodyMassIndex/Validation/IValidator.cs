namespace BodyMassIndex.Validation
{
    public interface IValidator<in T>
    {
        bool IsValid(T type);
    }
}
