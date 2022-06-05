namespace MisalignedSpace
{
    /// <summary>
    /// Contains the list of Major and Minor wire colors.
    /// </summary>
    public static class TelecomWireColorStore
    {
        static TelecomWireColorStore()
        {
            MajorColors = new[] { "White", "Red", "Black", "Yellow", "Violet" };
            MinorColors = new[] { "Blue", "Orange", "Green", "Brown", "SlateGray" };
        }

        public static string[] MajorColors { get; }

        public static string[] MinorColors { get; }
    }
}
