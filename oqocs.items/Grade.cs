using System.Collections.Generic;

namespace oqocs.items
{
    public class Grade
    {
        public static Grade S => new Grade("S", 3);
        public static Grade A => new Grade("A", 2);
        public static Grade B => new Grade("B", 1.5m);
        public static Grade C => new Grade("C", 1);
        public static Grade D => new Grade("D", 0.5m);
        public static Grade U => new Grade("U", 0);

        public string ShortName { get; }
        public string LongName => ShortName + "-Grade";
        public decimal PriceMultiplier { get; }

        public Grade(string shortname, decimal priceMulti)
        {
            this.ShortName = shortname;
            this.PriceMultiplier = priceMulti;
        }
    }
}