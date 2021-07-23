using oqocs.items.materials;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public class CarpentryTools
    {
        // Carpentry Tools

        public static BasicRecipe WoodSaw => new BasicRecipe()
        {
            Product = "Wood-Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(4, Helpers.AnyMetal),
                new RecipeComponent(1, Helpers.AnyWoodMetalOrStone)
            }
        };

        public static BasicRecipe Handsaw => new BasicRecipe()
        {
            Product = "Handsaw",
            DifficultyValue = 23,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyMetal),
                new RecipeComponent(0.5m, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe Hammer = new BasicRecipe()
        {
            Product = "Hammer",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Helpers.AnyMetal),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe Level => new BasicRecipe()
        {
            Product = "Level",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Unique.GlassBead),
                new RecipeComponent(1, Helpers.AnyWood),
            }
        };

        public static BasicRecipe WoodAuger => new BasicRecipe()
        {
            Product = "Wood Auger",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyMetalOrStone),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        //Clamp +

        public static BasicRecipe Nail => new BasicRecipe()
        {
            Product = "Nail",
            DifficultyValue = 12,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.0125m, Helpers.AnyMetal),
            }
        };
    }
}