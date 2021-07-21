namespace oqocs.items.materials
{
    public class Fiber : BasicItem
    {
        public Fiber(string name, string description, decimal value, int durability, Unit unit)
        {
            Name = name;
            Description = description;
            CostInPence = value;
            Durability = durability;
            Unit = unit;
            Quality = Grade.C;
        }

        public static Fiber AlpacaFiber => new Fiber("Alpaca Fiber", "", 4, 2, Unit.Pounds);

        public static Fiber CottonFiber => new Fiber("Cotton Fiber", "", 3, 1, Unit.Pounds);

        public static Fiber PlantFiber => new Fiber("Plant Fiber", "", 1, 3, Unit.Pounds);
    }
}