using oqocs.items.materials;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public class MiningTools
    {
        // Mining Tools
        public static BasicRecipe Pick => new BasicRecipe()
        {
            Product = "Pick",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(10, Helpers.AnyMetalOrStone),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe StoneSaw => new BasicRecipe()
        {
            Product = "Stone Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Helpers.AnyMetalOrStone),
                new RecipeComponent(1, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe GemSaw => new BasicRecipe()
        {
            Product = "Gem Saw",
            DifficultyValue = 37,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyMetalOrStone),
                new RecipeComponent(0.5m, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe Wedge => new BasicRecipe()
        {
            Product = "Wedge",
            DifficultyValue = 12,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWood),
            }
        };

        public static BasicRecipe StoneAuger => new BasicRecipe()
        {
            Product = "Stone Auger",
            DifficultyValue = 20,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3, Helpers.AnyMetalOrStone),
                new RecipeComponent(0.5m, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe Shovel => new BasicRecipe()
        {
            Product = "Shovel",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe Forge => new BasicRecipe()
        {
            Product = "Forge",
            DifficultyValue = 23,
            PriceMultiplier = 2,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(40, Stone.Clay)
            }
        };

        public static BasicRecipe Crucible => new BasicRecipe()
        {
            Product = "Crucible",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3, Helpers.AnyStone),
            }
        };

        public static BasicRecipe Tongs => new BasicRecipe()
        {
            Product = "Tongs",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyMetal),
                new RecipeComponent(0.5m, Helpers.AnyMetalOrStone),
            }
        };

        public static BasicRecipe SmithingHammer => new BasicRecipe()
        {
            Product = "Smithing Hammer",
            DifficultyValue = 18,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(8, Helpers.AnyMetal),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe Sledgehammer => new BasicRecipe()
        {
            Product = "Sledgehammer",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(16, Helpers.AnyMetal),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe Anvil => new BasicRecipe()
        {
            Product = "Anvil",
            DifficultyValue = 28,
            PriceMultiplier = 1,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(110, Helpers.AnyMetal),
            }
        };

        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            Pick,
            StoneSaw,
            GemSaw,
            Wedge,
            StoneAuger,
            Shovel,
            Forge,
            Crucible,
            Tongs,
            SmithingHammer,
            Sledgehammer,
            Anvil
        };
    }
}