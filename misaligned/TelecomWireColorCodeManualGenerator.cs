namespace MisalignedSpace
{
    using System;
    using System.Collections.Generic;

    public class TelecomWireColorCodeManualGenerator
    {
        public List<TelecomWireColorCode> GenerateTelecomWireColorCodes(string[] majorColors, string[] minorColors)
        {
            if (majorColors == null || majorColors.Length == 0 || minorColors == null || minorColors.Length == 0)
            {
                throw new ArgumentException("Major or Minor colors is/are invalid.");
            }

            var telecomWireColorCodes = new List<TelecomWireColorCode>();

            for (int majorColorIndex = 0; majorColorIndex < majorColors.Length; majorColorIndex++)
            {
                for (int minorColorIndex = 0; minorColorIndex < minorColors.Length; minorColorIndex++)
                {
                    telecomWireColorCodes.Add(GenerateTelecomWireColorCode(
                        (majorColorIndex * 5) + minorColorIndex + 1,
                        majorColors[majorColorIndex],
                        majorColors[minorColorIndex]));
                }
            }

            return telecomWireColorCodes;
        }

        public TelecomWireColorCode GenerateTelecomWireColorCode(int pairNumber, string majorColor, string minorColor)
        {
            return new TelecomWireColorCode(pairNumber, majorColor, minorColor);
        }
    }
}
