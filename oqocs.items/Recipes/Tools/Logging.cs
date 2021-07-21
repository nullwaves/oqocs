using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public class LoggingTools
    {
        // Logging Tools
        public static BasicRecipe MetalWoodaxe => new BasicRecipe()
        {
            Product = "Woodaxe",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 4),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe StoneWoodaxe => new BasicRecipe()
        {
            Product = "Woodaxe",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 4),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe MetalWoodLoggingSaw => new BasicRecipe()
        {
            Product = "Logging Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 5),
                new RecipeComponent(ComponentType.Wood, 1),
            }
        };

        public static BasicRecipe StoneWoodLoggingSaw => new BasicRecipe()
        {
            Product = "Logging Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 5),
                new RecipeComponent(ComponentType.Wood, 1),
            }
        };

        public static BasicRecipe MetalLoggingSaw => new BasicRecipe()
        {
            Product = "Logging Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 6),
            }
        };

        public static BasicRecipe StoneMetalLoggingSaw => new BasicRecipe()
        {
            Product = "Logging Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 5),
                new RecipeComponent(ComponentType.Metal, 1),
            }
        };

        public static BasicRecipe MetalStoneLoggingSaw => new BasicRecipe()
        {
            Product = "Logging Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 5),
                new RecipeComponent(ComponentType.Stone, 1),
            }
        };

        public static BasicRecipe StoneLoggingSaw => new BasicRecipe()
        {
            Product = "Logging Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 6),
            }
        };

        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            MetalWoodaxe,
            StoneWoodaxe,
            MetalWoodLoggingSaw,
            StoneWoodLoggingSaw,
            MetalLoggingSaw,
            StoneMetalLoggingSaw,
            MetalStoneLoggingSaw,
            StoneLoggingSaw,
        };
    }
}