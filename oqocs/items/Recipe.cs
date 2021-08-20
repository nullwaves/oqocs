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

        public override string ToString() => $"{Product} P.Multi: x{PriceMultiplier} D.Multi: x{DurabilityMultiplier}";
    }

    public enum ComponentType
    {
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