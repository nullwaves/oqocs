using oqocs.items.materials.cooking;
using oqocs.items.recipes.carpentry;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class OtherTools
    {
        public static BasicRecipe Candle => new BasicRecipe()
        {
            Product = "Candle",
            DifficultyValue = 12,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWax),
            }
        };

        public static BasicRecipe Torch => new BasicRecipe()
        {
            Product = "Torch",
            DifficultyValue = 12,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Furniture.Dowel),
                new RecipeComponent(0.00125m, Tailoring.BundleOfYarn),
                new RecipeComponent(1, Oils.All),
            }
        };

        public static BasicRecipe FireStarter => new BasicRecipe()
        {
            Product = "Fire Starter",
            DifficultyValue = 12,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Furniture.Dowel),
                new RecipeComponent(0.00125m, Tailoring.BundleOfCord),
            }
        };
    }
}