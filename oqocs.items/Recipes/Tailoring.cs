using oqocs.items.materials;
using System.Collections.Generic;
using System.Linq;

namespace oqocs.items.recipes
{
    public static class Tailoring
    {
        internal static List<BasicItem> CottonAndAlpaca => new List<BasicItem>()
        {
            Fiber.CottonFiber,
            Fiber.AlpacaFiber,
        };

        public static List<BasicRecipe> Bundles => new List<BasicRecipe>()
        {
            BundleOfYarn,
            BundleOfCord,
        };

        public static List<BasicRecipe> SpoolsAndBundles => new List<BasicRecipe>(Bundles)
        {
            SpoolOfThread,
        };

        public static BasicRecipe SpoolOfThread => new BasicRecipe()
        {
            Product = "Spool of Thread",
            DifficultyValue = 23,
            PriceMultiplier = 3,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, CottonAndAlpaca),
            }
        };

        public static BasicRecipe BundleOfYarn => new BasicRecipe()
        {
            Product = "Bundle of Yarn",
            DifficultyValue = 18,
            PriceMultiplier = 2,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(4, CottonAndAlpaca)
            }
        };

        public static BasicRecipe BundleOfCord => new BasicRecipe()
        {
            Product = "Bundle of Cord",
            DifficultyValue = 15,
            PriceMultiplier = 2.5m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Fiber.PlantFiber),
            }
        };

        public static BasicRecipe SpoolOfWire => new BasicRecipe()
        {
            Product = "Spool of Wire",
            DifficultyValue = 22,
            PriceMultiplier = 2,
            DurabilityMultiplier = 0.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Metal, 2)
            }
        };

        public static BasicRecipe BoltOfFelt => new BasicRecipe()
        {
            Product = "Bolt of Felt",
            DifficultyValue = 18,
            PriceMultiplier = 2,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(4, CottonAndAlpaca)
            }
        };

        public static BasicRecipe BoltOfWovenCloth => new BasicRecipe()
        {
            Product = "Bolt of Woven Cloth",
            DifficultyValue = 23,
            PriceMultiplier = 8,
            DurabilityMultiplier = 10,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(8, SpoolsAndBundles),
            }
        };

        public static BasicRecipe BoltOfKnitCloth => new BasicRecipe()
        {
            Product = "Bolt of Knit Cloth",
            DifficultyValue = 28,
            PriceMultiplier = 9,
            DurabilityMultiplier = 5,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(4, Bundles),
            }
        };

        public static BasicRecipe BoltOfLace => new BasicRecipe()
        {
            Product = "Bolt of Lace",
            DifficultyValue = 33,
            PriceMultiplier = 10,
            DurabilityMultiplier = 8,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(8, SpoolsAndBundles),
            }
        };

        public static BasicRecipe BoltOfCarpet => new BasicRecipe()
        {
            Product = "Bolt of Carpet",
            DifficultyValue = 28,
            PriceMultiplier = 6,
            DurabilityMultiplier = 10,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(15, SpoolsAndBundles),
            }
        };

        public static BasicRecipe MediumLeather => new BasicRecipe()
        {
            Product = "Medium Leather",
            DifficultyValue = 15,
            PriceMultiplier = 3,
            DurabilityMultiplier = 10,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Unique.MediumPelt),
            }
        };

        public static BasicRecipe MediumFur => new BasicRecipe()
        {
            Product = "Medium Fur",
            DifficultyValue = 15,
            PriceMultiplier = 3,
            DurabilityMultiplier = 10,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Unique.MediumPelt),
            }
        };

        public static BasicRecipe WoodScale => new BasicRecipe()
        {
            Product = "Wood Scale",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.1m, Wood.All.ToList<BasicItem>())
            }
        };

        public static BasicRecipe LacqueredWoodScale => new BasicRecipe()
        {
            Product = "Lacquered Scale",
            DifficultyValue = 28,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, WoodScale),
                new RecipeComponent(0.1m, Resin.All.ToList<BasicItem>()),
            }
        };

        public static BasicRecipe MetalScale => new BasicRecipe()
        {
            Product = "Metal Scale",
            DifficultyValue = 33,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.1m, Metal.All.ToList<BasicItem>()),
            }
        };

        public static BasicRecipe WoodLame => new BasicRecipe()
        {
            Product = "Wood Lame",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1.5m, Wood.All.ToList<BasicItem>()),
            }
        };

        public static BasicRecipe LacqueredWoodLame => new BasicRecipe()
        {
            Product = "Lacquered Lame",
            DifficultyValue = 28,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, WoodLame),
                new RecipeComponent(1, Resin.All.ToList<BasicItem>()),
            }
        };

        public static BasicRecipe MetalLame => new BasicRecipe()
        {
            Product = "Metal Lame",
            DifficultyValue = 33,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1.5m, Metal.All.ToList<BasicItem>()),
            }
        };

        public static BasicRecipe Belt => new BasicRecipe()
        {
            Product = "Belt",
            DifficultyValue = 18,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, MediumLeather),
                new RecipeComponent(2, Fitting),
            }
        };

        public static BasicRecipe Fitting = new BasicRecipe()
        {
            Product = "Fitting",
            DifficultyValue = 15,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.05m, Metal.All.ToList<BasicItem>()),
            }
        };
    }
}