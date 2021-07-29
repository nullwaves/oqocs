using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class Shields
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            Buckler,
            RoundShield,
            KiteShield,
            TowerShield,
        };

        public static BasicRecipe Buckler => new BasicRecipe()
        {
            Product = "Buckler",
            DifficultyValue = 18,
            PriceMultiplier = 2,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(7, Helpers.AnyWoodOrMetal),
            }
        };

        public static BasicRecipe RoundShield => new BasicRecipe()
        {
            Product = "Round Shield",
            DifficultyValue = 18,
            PriceMultiplier = 2,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(15, Helpers.AnyWoodOrMetal),
            }
        };

        public static BasicRecipe KiteShield => new BasicRecipe()
        {
            Product = "Kite Shield",
            DifficultyValue = 23,
            PriceMultiplier = 2,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(12, Helpers.AnyWoodOrMetal),
            }
        };

        public static BasicRecipe TowerShield => new BasicRecipe()
        {
            Product = "Tower Shield",
            DifficultyValue = 20,
            PriceMultiplier = 2,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(22, Helpers.AnyWoodOrMetal),
            }
        };
    }
}