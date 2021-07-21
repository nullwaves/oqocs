using oqocs.items.materials;
using System.Collections.Generic;
using System.Linq;

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

                    case ComponentType.CraftableItem:
                        var localItem = component.CraftableItem.ProduceFrom(w, m, s);
                        localDurability = localItem.Durability;
                        localValue = localItem.CostInPence * component.Quantity * localItem.Quality.PriceMultiplier;
                        break;

                    case ComponentType.Unique:
                        var localUnique = component.UniqueItem;
                        localDurability = localUnique.Durability;
                        localValue = localUnique.CostInPence * component.Quantity * localUnique.Quality.PriceMultiplier;
                        break;

                    case ComponentType.Multi:
                        var localMulti = component.AcceptedInputs.First();
                        localDurability = localMulti.Durability;
                        localValue = localMulti.CostInPence * component.Quantity * localMulti.Quality.PriceMultiplier;
                        break;

                    case ComponentType.MultiRecipe:
                        var localRecipe = component.AcceptedCrafted.First();
                        var localCrafted = localRecipe.ProduceFrom(w, m, s);
                        localDurability = localCrafted.Durability;
                        localValue = localCrafted.CostInPence * component.Quantity * localCrafted.Quality.PriceMultiplier;
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
        CraftableItem,
        Unique,
        Multi,
        MultiRecipe,
    }

    public class RecipeComponent
    {
        public decimal Quantity { get; set; }
        public ComponentType Type { get; set; }
        public BasicRecipe CraftableItem { get; set; }
        public BasicItem UniqueItem { get; set; }

        public List<BasicItem> AcceptedInputs { get; set; }
        public List<BasicRecipe> AcceptedCrafted { get; set; }

        public RecipeComponent(ComponentType type, decimal qty)
        {
            Type = type;
            Quantity = qty;
        }

        public RecipeComponent(decimal qty, BasicRecipe recipe)
        {
            Type = ComponentType.CraftableItem;
            Quantity = qty;
            CraftableItem = recipe;
        }

        public RecipeComponent(decimal qty, BasicItem item)
        {
            Type = ComponentType.Unique;
            Quantity = qty;
            UniqueItem = item;
        }

        public RecipeComponent(decimal qty, List<BasicItem> choices)
        {
            Type = ComponentType.Multi;
            Quantity = qty;
            AcceptedInputs = choices;
        }

        public RecipeComponent(decimal qty, List<BasicRecipe> choices)
        {
            Type = ComponentType.MultiRecipe;
            Quantity = qty;
            AcceptedCrafted = choices;
        }
    }
}