using oqocs.items.materials;
using oqocs.items.recipes.carpentry;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public class CarpentryTools
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            WoodSaw,
            Handsaw,
            Hammer,
            Level,
            WoodAuger,
            Clamp,
            Brush,
            Trowel,
            Ladder,
            Pulley,
            Sawhorse,
            CarvingKnife,
            Chisel,
            Nail,
            Hinge,
            LockAndKey,
        };

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

        public static BasicRecipe Hammer => new BasicRecipe()
        {
            Product = "Hammer",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Helpers.AnyMetal),
                new RecipeComponent(1, Furniture.Dowel),
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
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Clamp => new BasicRecipe()
        {
            Product = "Clamp",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Helpers.AnyWood),
                new RecipeComponent(0.025m, Tailoring.BundleOfCord),
            }
        };

        public static BasicRecipe Brush => new BasicRecipe()
        {
            Product = "Brush",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyFiber),
                new RecipeComponent(0.5m, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Trowel => new BasicRecipe()
        {
            Product = "Trowel",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Ladder => new BasicRecipe()
        {
            Product = "Ladder",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(15, Helpers.AnyWood),
                new RecipeComponent(1, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe Pulley => new BasicRecipe()
        {
            Product = "Pulley",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWood),
                new RecipeComponent(0.0375m, Tailoring.BundleOfCord),
            }
        };

        public static BasicRecipe Sawhorse => new BasicRecipe()
        {
            Product = "Sawhorse",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(10, Helpers.AnyWood),
                new RecipeComponent(16, Nail),
            }
        };

        public static BasicRecipe CarvingKnife => new BasicRecipe()
        {
            Product = "Carving Knife",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyMetal),
                new RecipeComponent(0.25m, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe Chisel => new BasicRecipe()
        {
            Product = "Chisel",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyMetal),
                new RecipeComponent(0.5m, Helpers.AnyWoodMetalOrStone),
            }
        };

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

        public static BasicRecipe Hinge => new BasicRecipe()
        {
            Product = "Hinge",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe LockAndKey => new BasicRecipe()
        {
            Product = "Lock & Key",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyMetal),
            }
        };
    }
}