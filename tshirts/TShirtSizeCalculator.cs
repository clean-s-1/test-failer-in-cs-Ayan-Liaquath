namespace TShirtSpace
{
    using System;

    public class TShirtSizeCalculator
    {
        public string CalculateSize(int shoulderMeasurementInCms)
        {
            if (shoulderMeasurementInCms <= 0)
            {
                throw new ArgumentException("Shoulder measurement is less than or equal to zero.");
            }

            if (shoulderMeasurementInCms < 38)
            {
                return "S";
            }

            if (shoulderMeasurementInCms < 42)
            {
                return "M";
            }
            
            return "L";
        }
    }
}
