using System.Collections.Generic;

namespace oqocs.items.materials
{
    public class Resin : BasicItem
    {
        public Resin(string name, string description, decimal value, int durability, Grade quality)
        {
            Name = name;
            Description = description;
            CostInPence = value;
            Durability = durability;
            Unit = Unit.Pint;
            Quality = quality;
        }

        public static Resin TimchaSap => new Resin("Timcha Sap", "", 1, 0, Grade.D);

        public static Resin Plant20LeafGlue => new Resin("Plant 20 Leaf Glue", "", 1, 0, Grade.D);

        public static Resin Plant16FlowerGlue => new Resin("Plant 16 Flower Glue", "", 3, 0, Grade.C);

        public static Resin Plant12FruitGlue => new Resin("Plant 12 Fruit Glue", "", 3, 0, Grade.C);

        public static Resin UqazoBarkGlue => new Resin("Uqazo Bark Glue", "", 6, 0, Grade.B);

        public static Resin Bush28FlowerBalsam => new Resin("Bush 18 Flower Balsam", "", 12, 0, Grade.A);

        public static Resin Timcha => new Resin("Timcha", "", 30, 0, Grade.S);

        public static List<Resin> All => new List<Resin>()
        {
            TimchaSap,
            Plant20LeafGlue,
            Plant16FlowerGlue,
            Plant12FruitGlue,
            UqazoBarkGlue,
            Bush28FlowerBalsam,
            Timcha,
        };
    }
}