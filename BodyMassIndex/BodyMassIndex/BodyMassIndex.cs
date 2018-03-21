namespace BodyMassIndex
{
    public class BodyMassIndex
    {
        public readonly decimal Height;

        public readonly decimal Weight;

        public BodyMassIndex(decimal height, decimal weight)
        {
            this.Height = height;
            this.Weight = weight;
        }

        public decimal Bmi => Weight / (Height * Height);
    }
}
