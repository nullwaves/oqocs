using System.Collections.Generic;

namespace oqocs.items.recipes
{
    public static class Carpentry
    {
        public static BasicRecipe Dowel = new BasicRecipe()
        {
            Product = "Dowel",
            DifficultyValue = 12,
            PriceMultiplier = 5,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>() { new RecipeComponent(ComponentType.Wood, 1) }
        };
    }
}