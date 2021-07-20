namespace oqocs.items
{
    public class Unit
    {
        public string Short { get; }
        public string Long { get; }

        private Unit(string s, string l)
        {
            Short = s;
            Long = l;
        }

        public static Unit Each => new Unit("", "Each");
        public static Unit Pounds => new Unit("lb", "Pounds");
    }
}