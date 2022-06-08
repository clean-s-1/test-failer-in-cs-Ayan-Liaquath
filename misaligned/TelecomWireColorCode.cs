namespace MisalignedSpace
{
    public class TelecomWireColorCode
    {
        public TelecomWireColorCode(int pairNumber, string majorColor, string minorColor)
        {
            PairNumber = pairNumber;
            MajorColor = majorColor;
            MinorColor = minorColor;
        }

        public int PairNumber { get; }

        public string MajorColor { get; }

        public string MinorColor { get; }
    }
}
