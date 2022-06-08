namespace MisalignedSpace
{
    using System;
    using System.Collections.Generic;

    public class TelecomWireColorCodePrinter
    {
        public string FormatWireColorCode(int pairNumber, string majorColor, string minorColor)
        {
            return $"{pairNumber} | {majorColor} | {minorColor}";
        }

        public void PrintStringOnConsole(string input)
        {
            Console.WriteLine(input);
        }

        public void DisplayColorMap(List<TelecomWireColorCode> telecomWireColorCodes, Func<int, string, string, string> formatterFunction, Action<string> printerFunction)
        {
            telecomWireColorCodes?.ForEach(
                telecomWireColorCode =>
                    {
                        printerFunction(
                            formatterFunction(
                                telecomWireColorCode.PairNumber,
                                telecomWireColorCode.MajorColor,
                                telecomWireColorCode.MinorColor));
                    });
        }
    }
}
