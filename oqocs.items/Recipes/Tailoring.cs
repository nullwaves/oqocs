using oqocs.items.materials;
using System.Collections.Generic;

namespace oqocs.items.Recipes
{
    public static class Tailoring
    {
        public static BasicRecipe SpoolOfAlpacaThread => new BasicRecipe()
        {
            Product = "Spool of Alpaca Thread",
            DifficultyValue = 23,
            PriceMultiplier = 3,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Unique, 1, Fiber.AlpacaFiber),
            }
        };
    }
}