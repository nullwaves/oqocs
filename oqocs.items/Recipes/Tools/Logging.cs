using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public class LoggingTools
    {
        // Logging Tools
        public static BasicRecipe Woodaxe => new BasicRecipe()
        {
            Product = "Woodaxe",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(4, Helpers.AnyMetalOrStone),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe LoggingSaw => new BasicRecipe()
        {
            Product = "Logging Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Helpers.AnyMetalOrStone),
                new RecipeComponent(1, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            Woodaxe,
            LoggingSaw,
        };
    }
}