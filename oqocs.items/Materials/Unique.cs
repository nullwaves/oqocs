using System.Collections.Generic;

namespace oqocs.items.materials
{
    public class Unique : BasicItem
    {
        public Unique(string name, string description, decimal value, int durability, Unit unit)
        {
            Name = name;
            Description = description;
            CostInPence = value;
            Durability = durability;
            Unit = unit;
            Quality = Grade.C;
        }

        public static Unique GlassBead => new Unique("Glass Bead", "", 1, 1, Unit.Each);

        public static Unique MediumPelt => new Unique("Medium Pelt", "", 6, 1, Unit.Each);
    }
}