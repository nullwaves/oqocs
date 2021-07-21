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
                new RecipeComponent(ComponentType.Metal, 4),
                new RecipeComponent(ComponentType.Wood, 1)
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
                new RecipeComponent(ComponentType.Metal, 1),
                new RecipeComponent(ComponentType.Wood, 0.5m),
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
                new RecipeComponent(ComponentType.Metal, 2),
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
                new RecipeComponent(ComponentType.Wood, 1)
            }
        };

        public static BasicRecipe MetalWoodAuger => new BasicRecipe()
        {
            Product = "Wood Auger",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 1),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe StoneWoodAuger => new BasicRecipe()
        {
            Product = "Wood Auger",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 1),
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
            Components = new List<RecipeComponent>() { new RecipeComponent(ComponentType.Metal, 0.0125m) }
        };
    }
}