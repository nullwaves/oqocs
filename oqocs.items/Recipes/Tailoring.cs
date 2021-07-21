using oqocs.items.materials;
using System.Collections.Generic;

namespace oqocs.items.recipes
{
    public static class Tailoring
    {
        internal static List<BasicItem> SpoolMulti => new List<BasicItem>()
        {
            Fiber.CottonFiber,
            Fiber.AlpacaFiber,
        };

        public static BasicRecipe SpoolOfThread => new BasicRecipe()
        {
            Product = "Spool of Thread",
            DifficultyValue = 23,
            PriceMultiplier = 3,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Multi, 1, SpoolMulti),
            }
        };
    }
}