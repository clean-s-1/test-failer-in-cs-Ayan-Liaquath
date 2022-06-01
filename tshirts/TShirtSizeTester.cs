namespace TShirtSpace
{
    using System.Diagnostics;

    class TShirtSizeTester
    {
        static void Main()
        {
            var tshirtSizeCalculator = new TShirtSizeCalculator();

            Debug.Assert(tshirtSizeCalculator.CalculateSize(37) == "S");
            Debug.Assert(tshirtSizeCalculator.CalculateSize(40) == "M");
            Debug.Assert(tshirtSizeCalculator.CalculateSize(43) == "L");
            Debug.Assert(tshirtSizeCalculator.CalculateSize(38) == "M");
        }
    }
}
