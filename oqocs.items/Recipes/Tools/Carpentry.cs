using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public class CarpentryTools
    {
        // Carpentry Tools
        public static BasicRecipe Nail => new BasicRecipe()
        {
            Product = "Nail",
            DifficultyValue = 12,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>() { new RecipeComponent(ComponentType.Metal, 0.0125m) }
        };
    }
}