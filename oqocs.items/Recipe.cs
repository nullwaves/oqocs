using System.Collections.Generic;

namespace oqocs.items
{
    public class BasicRecipe
    {
        public string Product { get; set; }
        public List<RecipeComponent> Components { get; set; }
        public int DifficultyValue { get; set; }
        public decimal PriceMultiplier { get; set; }
        public decimal DurabilityMultiplier { get; set; }
        public string Knowledge { get; set; }

        public BasicItem ProduceFrom(Wood w = null, Metal m = null, Stone s = null)
        {
            int sumDurability = 0;
            decimal sumValue = 0;
            foreach (RecipeComponent component in Components)
            {
                int localDurability = 0;
                decimal localValue = 0;
                switch (component.Type)
                {
                    case ComponentType.Wood:
                        localDurability += w.Durability;
                        localValue += w.CostInPence * component.Quantity * w.Quality.PriceMultiplier;
                        break;

                    case ComponentType.Metal:
                        localDurability += m.Durability;
                        localValue += m.CostInPence * component.Quantity * m.Quality.PriceMultiplier;
                        break;

                    case ComponentType.Stone:
                        localDurability += s.Durability;
                        localValue += s.CostInPence * component.Quantity * s.Quality.PriceMultiplier;
                        break;
                }
                if (localValue > 0 && localValue < 1) localValue = 1; // Round up component costs.
                sumDurability += localDurability;
                sumValue += localValue;
            }

            string mats = (w != null ? w.Name + " " : string.Empty) + (m != null ? m.Name + " " : string.Empty) + (s != null ? s.Name + " " : string.Empty);
            var item = new BasicItem()
            {
                Name = $"{mats} {Product}",
                Durability = (int)(sumDurability * DurabilityMultiplier),
                CostInPence = sumValue * PriceMultiplier,
                Quality = Grade.C,
                Unit = Unit.Each
            };

            return item;
        }
    }

    public enum ComponentType
    {
        Wood,
        Metal,
        Stone,
    }

    public class RecipeComponent
    {
        public decimal Quantity { get; set; }
        public ComponentType Type { get; set; }

        public RecipeComponent(ComponentType type, decimal qty)
        {
            Type = type;
            Quantity = qty;
        }
    }
}