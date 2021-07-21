﻿using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public class MiningTools
    {
        // Mining Tools
        public static BasicRecipe MetalPick => new BasicRecipe()
        {
            Product = "Pick",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 10),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe StonePick => new BasicRecipe()
        {
            Product = "Pick",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 10),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe MetalWoodStoneSaw => new BasicRecipe()
        {
            Product = "Stone Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 5),
                new RecipeComponent(ComponentType.Wood, 1),
            }
        };

        public static BasicRecipe StoneWoodStoneSaw => new BasicRecipe()
        {
            Product = "Stone Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 5),
                new RecipeComponent(ComponentType.Wood, 1),
            }
        };

        public static BasicRecipe MetalStoneSaw => new BasicRecipe()
        {
            Product = "Stone Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 6),
            }
        };

        public static BasicRecipe StoneMetalStoneSaw => new BasicRecipe()
        {
            Product = "Stone Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 5),
                new RecipeComponent(ComponentType.Metal, 1),
            }
        };

        public static BasicRecipe MetalStoneStoneSaw => new BasicRecipe()
        {
            Product = "Stone Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 5),
                new RecipeComponent(ComponentType.Stone, 1),
            }
        };

        public static BasicRecipe StoneStoneSaw => new BasicRecipe()
        {
            Product = "Stone Saw",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 6),
            }
        };

        public static BasicRecipe MetalWoodGemSaw => new BasicRecipe()
        {
            Product = "Gem Saw",
            DifficultyValue = 37,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 1),
                new RecipeComponent(ComponentType.Wood, 0.5m),
            }
        };

        public static BasicRecipe StoneWoodGemSaw => new BasicRecipe()
        {
            Product = "Gem Saw",
            DifficultyValue = 37,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 1),
                new RecipeComponent(ComponentType.Wood, 0.5m),
            }
        };

        public static BasicRecipe MetalGemSaw => new BasicRecipe()
        {
            Product = "Gem Saw",
            DifficultyValue = 37,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 1.5m),
            }
        };

        public static BasicRecipe StoneMetalGemSaw => new BasicRecipe()
        {
            Product = "Gem Saw",
            DifficultyValue = 37,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 1),
                new RecipeComponent(ComponentType.Metal, 0.5m),
            }
        };

        public static BasicRecipe MetalStoneGemSaw => new BasicRecipe()
        {
            Product = "Gem Saw",
            DifficultyValue = 37,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 1),
                new RecipeComponent(ComponentType.Stone, 0.5m),
            }
        };

        public static BasicRecipe StoneGemSaw => new BasicRecipe()
        {
            Product = "Gem Saw",
            DifficultyValue = 37,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 1.5m),
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
                new RecipeComponent(ComponentType.Wood, 1),
            }
        };

        public static BasicRecipe MetalStoneAuger => new BasicRecipe()
        {
            Product = "Stone Auger",
            DifficultyValue = 20,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 3),
                new RecipeComponent(ComponentType.Wood, 0.5m),
            }
        };

        public static BasicRecipe StoneStoneAuger => new BasicRecipe()
        {
            Product = "Stone Auger",
            DifficultyValue = 20,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 3),
                new RecipeComponent(ComponentType.Wood, 0.5m),
            }
        };

        public static BasicRecipe WoodShovel => new BasicRecipe()
        {
            Product = "Shovel",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Wood, 3),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe MetalShovel => new BasicRecipe()
        {
            Product = "Shovel",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 3),
                new RecipeComponent(1, Carpentry.Dowel),
            }
        };

        public static BasicRecipe StoneShovel => new BasicRecipe()
        {
            Product = "Shovel",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Stone, 3),
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
                new RecipeComponent(ComponentType.Stone, 40)
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
                new RecipeComponent(ComponentType.Stone, 3),
            }
        };

        public static BasicRecipe MetalTongs => new BasicRecipe()
        {
            Product = "Tongs",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 1.5m),
            }
        };

        public static BasicRecipe StoneTongs => new BasicRecipe()
        {
            Product = "Tongs",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 1),
                new RecipeComponent(ComponentType.Stone, 0.5m),
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
                new RecipeComponent(ComponentType.Metal, 8),
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
                new RecipeComponent(ComponentType.Metal, 16),
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
                new RecipeComponent(ComponentType.Metal, 110),
            }
        };

        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            MetalPick,
            StonePick,
            MetalWoodStoneSaw,
            StoneWoodStoneSaw,
            MetalStoneSaw,
            StoneMetalStoneSaw,
            MetalStoneStoneSaw,
            StoneStoneSaw,
            MetalWoodGemSaw,
            StoneWoodGemSaw,
            MetalGemSaw,
            StoneMetalGemSaw,
            MetalStoneGemSaw,
            StoneGemSaw,
            Wedge,
            MetalStoneAuger,
            StoneStoneAuger,
            WoodShovel,
            MetalShovel,
            StoneShovel,
            Forge,
            Crucible,
            MetalTongs,
            StoneTongs,
            SmithingHammer,
            Sledgehammer,
            Anvil
        };
    }
}