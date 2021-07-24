using oqocs.items.materials;
using System.Collections.Generic;

namespace oqocs.items.recipes
{
    public static class Tailoring
    {
        internal static List<BasicItem> CottonAndAlpaca => new List<BasicItem>()
        {
            Fiber.CottonFiber,
            Fiber.AlpacaFiber,
        };

        internal static List<BasicRecipe> Bundles => new List<BasicRecipe>()
        {
            BundleOfYarn,
            BundleOfCord,
        };

        internal static List<BasicRecipe> SpoolsAndBundles => new List<BasicRecipe>(Bundles)
        {
            SpoolOfThread,
        };

        internal static List<BasicRecipe> WeaveLace => new List<BasicRecipe>()
        {
            BoltOfWovenCloth,
            BoltOfLace,
        };

        internal static List<BasicRecipe> WeaveKnitLace => new List<BasicRecipe>(WeaveLace)
        {
            BoltOfKnitCloth,
        };

        internal static List<BasicRecipe> LeatherFur => new List<BasicRecipe>()
        {
            MediumLeather,
            MediumFur,
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
                new RecipeComponent(2, Helpers.AnyMetal)
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
                new RecipeComponent(0.1m, Helpers.AnyWood)
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
                new RecipeComponent(0.1m, Helpers.AnyResin),
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
                new RecipeComponent(0.1m, Helpers.AnyMetal),
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
                new RecipeComponent(1.5m, Helpers.AnyWood),
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
                new RecipeComponent(1, Helpers.AnyResin),
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
                new RecipeComponent(1.5m, Helpers.AnyMetal),
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

        public static BasicRecipe Fitting => new BasicRecipe()
        {
            Product = "Fitting",
            DifficultyValue = 15,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.05m, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe Tsixataq => new BasicRecipe()
        {
            Product = "Tsixataq",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.02m, WeaveKnitLace),
            }
        };

        public static BasicRecipe LeatherTsixataq => new BasicRecipe()
        {
            Product = "Tsixataq",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, LeatherFur)
            }
        };

        public static BasicRecipe Tsixunomu => new BasicRecipe()
        {
            Product = "Tsixunomu",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.015m, WeaveLace),
            }
        };

        public static BasicRecipe Tsixomu => new BasicRecipe()
        {
            Product = "Tsixomu",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, new List<BasicRecipe>() {Tsixataq, LeatherTsixataq}),
                new RecipeComponent(0.00625m, SpoolOfThread),
            }
        };

        public static BasicRecipe Tsixunjlj => new BasicRecipe()
        {
            Product = "Tsixunələ",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.01m, WeaveLace),
            }
        };

        public static BasicRecipe Tsixawamj => new BasicRecipe()
        {
            Product = "Tsixawamə",
            DifficultyValue = 23,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.08m, WeaveKnitLace),
                new RecipeComponent(0.01875m, SpoolOfThread),
            }
        };

        public static BasicRecipe LeatherTsixawamj => new BasicRecipe()
        {
            Product = "Tsixawamə",
            DifficultyValue = 23,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.02m, WeaveKnitLace),
                new RecipeComponent(2, LeatherFur),
                new RecipeComponent(0.01875m, SpoolOfThread),
            }
        };

        public static BasicRecipe Tsixeti => new BasicRecipe()
        {
            Product = "Tsixeti",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.01m, BoltOfWovenCloth),
                new RecipeComponent(0.00625m, SpoolOfThread),
            }
        };

        public static BasicRecipe Nyemka => new BasicRecipe()
        {
            Product = "Nyemka",
            DifficultyValue = 28,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.08m, BoltOfWovenCloth),
                new RecipeComponent(2, MediumLeather),
                new RecipeComponent(0.01875m, SpoolOfThread),
            }
        };

        public static BasicRecipe Gambeson => new BasicRecipe()
        {
            Product = "Gambeson",
            DifficultyValue = 33,
            PriceMultiplier = 2,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.32m, BoltOfWovenCloth),
                new RecipeComponent(4, Helpers.AnyFiber),
                new RecipeComponent(0.03125m, SpoolOfThread),
            }
        };

        public static BasicRecipe Nawamanqa => new BasicRecipe()
        {
            Product = "Nawamanqa",
            DifficultyValue = 33,
            PriceMultiplier = 3,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.24m, BoltOfWovenCloth),
                new RecipeComponent(2, MediumLeather),
                new RecipeComponent(2, MediumFur),
                new RecipeComponent(0.01875m, SpoolOfThread),
            }
        };

        public static BasicRecipe Tsixuke => new BasicRecipe()
        {
            Product = "Tsixuke",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.03m, BoltOfWovenCloth),
                new RecipeComponent(0.00625m, SpoolOfThread),
            }
        };

        public static BasicRecipe LeatherTsixuke => new BasicRecipe()
        {
            Product = "Tsixuke",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, MediumLeather),
                new RecipeComponent(0.00625m, SpoolOfThread),
            }
        };

        /*public static BasicRecipe BasicSjnenli => new BasicRecipe()
        {
            Product = "Sənenli",
            DifficultyValue = 15,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
            }
        };
        */
    }
}