namespace MisalignedSpace
{
    using System;

    public class ColorMapPrinter
    {
        public string FormatWireColorCode(int pairNumber, string majorColor, string minorColor)
        {
            return $"{pairNumber} | {majorColor} | {minorColor}";
        }

        public void PrintStringOnConsole(string input)
        {
            Console.WriteLine(input);
        }

        public int PrintColorMap(string[] majorColors, string[] minorColors, Func<int, string, string, string> formatterFunction, Action<string> printerFunction)
        {
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    printerFunction(formatterFunction((i * 5) + j, majorColors[i], minorColors[i]));
                }
            }

            return i * j;
        }
    }
}
