namespace TShirtSpace
{
    using System;
    using System.Diagnostics;

    class TShirtSizeTester
    {
        static void Main()
        {
            var tShirtSizeCalculator = new TShirtSizeCalculator();

            Debug.Assert(tShirtSizeCalculator.CalculateSize(37) == "S");
            Debug.Assert(tShirtSizeCalculator.CalculateSize(40) == "M");
            Debug.Assert(tShirtSizeCalculator.CalculateSize(43) == "L");
            Debug.Assert(tShirtSizeCalculator.CalculateSize(42) == "L");
            Debug.Assert(tShirtSizeCalculator.CalculateSize(38) == "M");

            try
            {
                tShirtSizeCalculator.CalculateSize(0);
                Debug.Fail("Expected an argument exception.");
            }
            catch (ArgumentException argumentException)
            {
                Debug.Assert(argumentException.Message.Equals("Shoulder measurement is less than or equal to zero."));
            }
        }
    }
}
