namespace oqocs.items
{
    public static class CurrencyFormatter
    {
        public static string PrettyShorthandFromPence(int p)
        {
            int silver = p / (24 * 6);
            int copper = (p - (silver * 24 * 6)) / 6;
            int pence = p - (silver * 24 * 6 + copper * 6);
            return $"{silver}s {copper}c {pence}p";
        }

        public static string PrettyCopperFromPence(int p)
        {
            int copper = p / 6;
            int pence = p % 6;
            return $"{copper}c {pence}p";
        }
    }
}