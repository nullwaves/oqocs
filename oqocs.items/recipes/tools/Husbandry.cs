using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class HusbandryTools
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            ShepherdsCrook,
            Llamaboots,
            Leash,
            Saddle,
            Whip,
        };

        public static BasicRecipe ShepherdsCrook => new BasicRecipe()
        {
            Product = "Shepherds Crook",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(7, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Llamaboots => new BasicRecipe()
        {
            Product = "Llamaboots",
            DifficultyValue = 20,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Tailoring.MediumLeather),
                new RecipeComponent(0.5m, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe Leash => new BasicRecipe()
        {
            Product = "Leash",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Tailoring.MediumLeather),
            }
        };

        public static BasicRecipe Saddle => new BasicRecipe()
        {
            Product = "Saddle",
            DifficultyValue = 23,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Tailoring.MediumLeather),
                new RecipeComponent(1, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe Whip => new BasicRecipe()
        {
            Product = "Whip",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Tailoring.MediumLeather),
            }
        };
    }
}