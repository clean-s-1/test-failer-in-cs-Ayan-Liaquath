namespace MisalignedSpace
{
    using System.Diagnostics;

    class TelecomWireColorCodeTester
    {
        private static int formatterFuncCallCount = 0;

        private static int printerFuncCallCount = 0;

        static void Main()
        {
            var colorMapGenerator = new TelecomWireColorCodeManualGenerator();
            var colorMapManual = colorMapGenerator.GenerateTelecomWireColorCodes(
                TelecomWireColorStore.MajorColors,
                TelecomWireColorStore.MinorColors);

            var colorMapPrinter = new TelecomWireColorCodePrinter();
            colorMapPrinter.DisplayColorMap(colorMapManual, FormatWireColorCodeStub, PrintStringOnConsoleStub);
            
            Debug.Assert(colorMapManual.Count == 25);
            Debug.Assert(colorMapManual[0].PairNumber == 1);
            Debug.Assert(colorMapManual[colorMapManual.Count - 1].PairNumber == 25);
            Debug.Assert(formatterFuncCallCount == 25);
            Debug.Assert(printerFuncCallCount == 25);
        }

        public static string FormatWireColorCodeStub(int pairNumber, string majorColor, string minorColor)
        {
            formatterFuncCallCount++;
            return string.Empty;
        }

        public static void PrintStringOnConsoleStub(string input)
        {
            printerFuncCallCount++;
        }
    }
}
