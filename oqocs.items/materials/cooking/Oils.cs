using System.Collections.Generic;

namespace oqocs.items.materials.cooking
{
    public static class Oils
    {
        public static List<BasicItem> All => new List<BasicItem>()
        {
            Plant23FlowerOil,
            Plant27RootOil,
            Fungus22Oil,
        };

        public static BasicItem Plant23FlowerOil => new BasicItem()
        {
            Name = "Plant 23 Flower Oil",
            Description = "",
            Durability = 1,
            CostInPence = 6,
            Quality = Grade.C,
            Unit = Unit.Pint,
        };

        public static BasicItem Plant27RootOil => new BasicItem()
        {
            Name = "Plant 27 Root Oil",
            Description = "",
            Durability = 1,
            CostInPence = 2,
            Quality = Grade.C,
            Unit = Unit.Pint,
        };

        public static BasicItem Fungus22Oil => new BasicItem()
        {
            Name = "Fungus 22 Oil",
            Description = "",
            Durability = 1,
            CostInPence = 9,
            Quality = Grade.C,
            Unit = Unit.Pint,
        };
    }
}