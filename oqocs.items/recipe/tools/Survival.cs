using oqocs.items.recipes.carpentry;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class SurvivalTools
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            Hoe,
            Pitchfork,
            Plough,
            Sickle,
            Snare,
            Spike,
            Cage,
            Trap,
            SetOfCaltrops,
        };

        public static BasicRecipe Hoe => new BasicRecipe()
        {
            Product = "Hoe",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Pitchfork => new BasicRecipe()
        {
            Product = "Pitchfork",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Plough => new BasicRecipe()
        {
            Product = "Plough",
            DifficultyValue = 20,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Helpers.AnyMetalOrStone),
                new RecipeComponent(25, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Sickle => new BasicRecipe()
        {
            Product = "Sickle",
            DifficultyValue = 23,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3, Helpers.AnyMetal),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Snare => new BasicRecipe()
        {
            Product = "Snare",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.03125m, Tailoring.BundleOfCord),
            }
        };

        public static BasicRecipe Spike => new BasicRecipe()
        {
            Product = "Spike",
            DifficultyValue = 15,
            PriceMultiplier = 1,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Cage => new BasicRecipe()
        {
            Product = "Cage",
            DifficultyValue = 20,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe Trap => new BasicRecipe()
        {
            Product = "Trap",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyMetal),
                new RecipeComponent(3, Helpers.AnyWood),
                new RecipeComponent(0.01875m, Tailoring.BundleOfCord),
            }
        };

        public static BasicRecipe SetOfCaltrops => new BasicRecipe()
        {
            Product = "Set Of Caltrops",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(4, Helpers.AnyMetal),
            }
        };
    }
}