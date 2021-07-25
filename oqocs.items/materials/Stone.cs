using System.Collections.Generic;

namespace oqocs.items.materials
{
    public class Stone : BasicItem
    {
        public Stone(string name, string description, decimal value, int durability)
        {
            Name = name;
            Description = description;
            CostInPence = value;
            Durability = durability;
            Unit = Unit.Pounds;
            Quality = Grade.C;
        }

        public static Stone Plain => new Stone("Regular Stone", "", 0.1m, 50);
        public static Stone Sandstone => new Stone("Sandstone", "", 0.1m, 10);
        public static Stone Limestone => new Stone("Limestone", "", 0.1m, 10);
        public static Stone Basalt => new Stone("Basalt", "", 0.1m, 15);
        public static Stone Granite => new Stone("Granite", "", 1, 100);
        public static Stone Amber => new Stone("Amber", "", 144, 75);
        public static Stone Bloodstone => new Stone("Bloodstone", "", 144, 75);
        public static Stone Flint => new Stone("Flint", "", 0.1m, 25);
        public static Stone Quartz => new Stone("Quartz", "", 6, 75);
        public static Stone Feldspar => new Stone("Feldspar", "", 0.1m, 10);
        public static Stone Salt => new Stone("Salt", "", 6, 10);
        public static Stone Sulfur => new Stone("Sulfur", "", 0.1m, 10);
        public static Stone Andesite => new Stone("Andesite", "", 0.1m, 75);
        public static Stone Clay => new Stone("Clay", "", 0.2m, 1);

        // All Stone
        public static List<Stone> All = new List<Stone>()
        {
            Plain, Sandstone, Limestone, Basalt, Granite, Amber, Bloodstone, Flint, Quartz, Feldspar, Salt, Sulfur, Andesite, Clay
        };
    }
}