namespace MisalignedSpace
{
    using System.Diagnostics;

    class ColorMapTester
    {
        private static int formatterFuncCallCount = 0;

        private static int printerFuncCallCount = 0;

        static void Main()
        {
            var colorMapPrinter = new ColorMapPrinter();
            var majorColors = new[] { "White", "Red", "Black", "Yellow", "Violet" };
            var minorColors = new[] { "Blue", "Orange", "Green", "Brown", "Slate" };

            int result = colorMapPrinter.PrintColorMap(majorColors, minorColors, FormatWireColorCodeMock, PrintStringOnConsoleMock);
            Debug.Assert(result == 25);
            Debug.Assert(formatterFuncCallCount == 25);
            Debug.Assert(printerFuncCallCount == 25);
        }

        public static string FormatWireColorCodeMock(int pairNumber, string majorColor, string minorColor)
        {
            Debug.Assert(pairNumber > 0 && pairNumber < 26);
            formatterFuncCallCount++;
            return string.Empty;
        }

        public static void PrintStringOnConsoleMock(string input)
        {
            printerFuncCallCount++;
        }
    }
}
