using oqocs.items.materials;
using oqocs.items.recipes.carpentry;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class FishingTools
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            Rod,
            Net,
            ShrimpTrap,
            SnailTrap,
            OctopusTrap,
            CrabPot,
            HermitTrap,
            Harpoon,
        };

        public static BasicRecipe Rod => new BasicRecipe()
        {
            Product = "Fishing Rod",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWood),
                new RecipeComponent(0.25m, Helpers.AnyWoodOrMetal),
                new RecipeComponent(1, Tailoring.BundleOfCord),
            }
        };

        public static BasicRecipe Net => new BasicRecipe()
        {
            Product = "Net",
            DifficultyValue = 23,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Tailoring.BundleOfCord),
            }
        };

        public static BasicRecipe ShrimpTrap => new BasicRecipe()
        {
            Product = "Shrimp Trap",
            DifficultyValue = 20,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Helpers.AnyWood),
                new RecipeComponent(0.01875m, Tailoring.BundleOfCord),
            }
        };

        public static BasicRecipe SnailTrap => new BasicRecipe()
        {
            Product = "Shrimp Trap",
            DifficultyValue = 20,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Helpers.AnyWood),
            }
        };

        public static BasicRecipe OctopusTrap => new BasicRecipe()
        {
            Product = "Octopus Trap",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3, Stone.Clay),
            }
        };

        public static BasicRecipe CrabPot => new BasicRecipe()
        {
            Product = "Crab Pot",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(10, Helpers.AnyWood),
                new RecipeComponent(0.0625m, Tailoring.BundleOfCord),
            }
        };

        public static BasicRecipe HermitTrap => new BasicRecipe()
        {
            Product = "Hermit Trap",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Harpoon => new BasicRecipe()
        {
            Product = "Harpoon",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };
    }
}