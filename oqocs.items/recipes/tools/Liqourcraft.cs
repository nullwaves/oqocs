using oqocs.items.materials;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class Liqourcraft
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            Cask,
            Basin,
            Still,
            Filter,
        };

        public static BasicRecipe Cask => new BasicRecipe()
        {
            Product = "Cask",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(20, Helpers.AnyWood),
                new RecipeComponent(2, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe Basin => new BasicRecipe()
        {
            Product = "Basin",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(50, Stone.Clay),
            }
        };

        public static BasicRecipe Still => new BasicRecipe()
        {
            Product = "Still",
            DifficultyValue = 28,
            PriceMultiplier = 3,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyMetal),
                new RecipeComponent(2, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Filter => new BasicRecipe()
        {
            Product = "Filter",
            DifficultyValue = 20,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.01m, Tailoring.BoltOfWovenCloth),
                new RecipeComponent(1, Helpers.AnyWood),
            }
        };
    }
}