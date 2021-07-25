using oqocs.items.materials;
using System.Collections.Generic;

namespace oqocs.items.recipes
{
    public static class Tailoring
    {
        public static List<BasicRecipe> All => Helpers.CompileList(new List<BasicRecipe>[] { BasicComponents, Products, Armors });

        #region Helpers

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

        internal static List<BasicRecipe> ThreadOrYarn => new List<BasicRecipe>()
        {
            SpoolOfThread,
            BundleOfYarn,
        };

        internal static List<BasicRecipe> ThreadOrCord => new List<BasicRecipe>()
        {
            SpoolOfThread,
            BundleOfCord,
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

        #endregion Helpers

        #region Basic Components

        public static List<BasicRecipe> BasicComponents => new List<BasicRecipe>()
        {
            SpoolOfThread,
            BundleOfYarn,
            BundleOfCord,
            SpoolOfWire,
            BoltOfFelt,
            BoltOfWovenCloth,
            BoltOfKnitCloth,
            BoltOfLace,
            BoltOfCarpet,
            MediumLeather,
            MediumFur,
            LeatherScale,
            LeatherLame,
            WoodScale,
            LacqueredWoodScale,
            MetalScale,
            WoodLame,
            LacqueredWoodLame,
            MetalLame,
            Belt,
            Fitting,
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

        public static BasicRecipe LeatherScale => new BasicRecipe()
        {
            Product = "Leather Scale",
            DifficultyValue = 18,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.1m, MediumLeather),
            }
        };

        public static BasicRecipe LeatherLame => new BasicRecipe()
        {
            Product = "Leather Lame",
            DifficultyValue = 18,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.2m, MediumLeather),
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

        #endregion Basic Components

        #region Products

        public static List<BasicRecipe> Products => new List<BasicRecipe>()
        {
            Tsixataq,
            LeatherTsixataq,
            Tsixunomu,
            Tsixomu,
            Tsixunjlj,
            Tsixawamj,
            LeatherTsixawamj,
            Tsixeti,
            Nyemka,
            Gambeson,
            Nawamanqa,
            Tsixuke,
            LeatherTsixuke,
            Monchj,
            Yezhipj,
            Yezhipexem,
            Yexhipanqa,
            Socks,
            Underwear,
            Blanket,
            Sheet,
            Curtain,
            Towel,
            Rag,
            Backpack,
            Pillow,
            Mattress,
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

        public static BasicRecipe Monchj => new BasicRecipe()
        {
            Product = "Monchə",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWood),
                new RecipeComponent(0.5m, MediumLeather),
                new RecipeComponent(0.0025m, ThreadOrYarn),
            }
        };

        public static BasicRecipe Yezhipj => new BasicRecipe()
        {
            Product = "Yezhipə",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, MediumLeather),
                new RecipeComponent(0.00625m, ThreadOrCord),
                new RecipeComponent(1, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Yezhipexem => new BasicRecipe()
        {
            Product = "Yezhipexem",
            DifficultyValue = 28,
            PriceMultiplier = 2,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, MediumLeather),
                new RecipeComponent(0.01m, ThreadOrCord),
                new RecipeComponent(1, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Yexhipanqa => new BasicRecipe()
        {
            Product = "Yexhipanqa",
            DifficultyValue = 33,
            PriceMultiplier = 2.5m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3, MediumLeather),
                new RecipeComponent(0.01m, ThreadOrCord),
                new RecipeComponent(1, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Socks => new BasicRecipe()
        {
            Product = "Socks",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.01m, BoltOfWovenCloth),
                new RecipeComponent(0.000025m, SpoolOfThread),
            }
        };

        public static BasicRecipe Underwear => new BasicRecipe()
        {
            Product = "Underwear",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.02m, BoltOfWovenCloth),
                new RecipeComponent(0.00625m, SpoolOfThread),
            }
        };

        public static BasicRecipe Blanket => new BasicRecipe()
        {
            Product = "Blanket",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.09m, BoltOfWovenCloth),
            }
        };

        public static BasicRecipe Sheet => new BasicRecipe()
        {
            Product = "Sheet",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.09m, BoltOfWovenCloth),
            }
        };

        public static BasicRecipe Curtain => new BasicRecipe()
        {
            Product = "Curtain",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.02m, BoltOfWovenCloth),
                new RecipeComponent(0.00625m, SpoolOfThread),
            }
        };

        public static BasicRecipe Towel => new BasicRecipe()
        {
            Product = "Towel",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.02m, BoltOfWovenCloth),
            }
        };

        public static BasicRecipe Rag => new BasicRecipe()
        {
            Product = "Rag",
            DifficultyValue = 15,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.00125m, BoltOfWovenCloth),
            }
        };

        public static BasicRecipe Backpack => new BasicRecipe()
        {
            Product = "Backpack",
            DifficultyValue = 18,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(4, MediumLeather),
                new RecipeComponent(0.01m, ThreadOrCord),
                new RecipeComponent(10, Fitting),
            }
        };

        public static BasicRecipe Pillow => new BasicRecipe()
        {
            Product = "Pillow",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.02m, BoltOfWovenCloth),
            }
        };

        public static BasicRecipe Mattress => new BasicRecipe()
        {
            Product = "Mattress",
            DifficultyValue = 23,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(252, BoltOfWovenCloth),
                new RecipeComponent(15, Helpers.AnyFiber),
                new RecipeComponent(0.05m, SpoolOfThread),
            }
        };

        #endregion Products

        #region Armors

        public static List<BasicRecipe> Armors = new List<BasicRecipe>()
        {
            LeatherArmor,
            ReinforcedLeatherArmor,
            WoodArmor,
            WoodPlateArmor,
            LacqueredWoodArmor,
            LacqueredWoodPlateArmor,
            MetalPlateArmor,
            HeavyMetalPlateArmor,
        };

        public static BasicRecipe LeatherArmor => new BasicRecipe()
        {
            Product = "Leather Armor",
            DifficultyValue = 23,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(210, LeatherScale),
                new RecipeComponent(0.05m, BundleOfCord),
                new RecipeComponent(6, Belt),
                new RecipeComponent(1, Gambeson),
                new RecipeComponent(1, Yexhipanqa),
                new RecipeComponent(0.1m, BoltOfWovenCloth),
                new RecipeComponent(40, Fitting),
            }
        };

        public static BasicRecipe ReinforcedLeatherArmor => new BasicRecipe()
        {
            Product = "Reinforced Leather Armor",
            DifficultyValue = 23,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(35, LeatherLame),
                new RecipeComponent(0.025m, BundleOfCord),
                new RecipeComponent(11, Belt),
                new RecipeComponent(1, Gambeson),
                new RecipeComponent(1, Yexhipanqa),
                new RecipeComponent(0.1m, BoltOfWovenCloth),
                new RecipeComponent(160, Fitting),
            }
        };

        public static BasicRecipe WoodArmor => new BasicRecipe()
        {
            Product = "Wood Armor",
            DifficultyValue = 23,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(210, WoodScale),
                new RecipeComponent(0.05m, BundleOfCord),
                new RecipeComponent(6, Belt),
                new RecipeComponent(1, Gambeson),
                new RecipeComponent(1, Yexhipanqa),
                new RecipeComponent(0.1m, BoltOfWovenCloth),
                new RecipeComponent(40, Fitting),
            }
        };

        public static BasicRecipe WoodPlateArmor => new BasicRecipe()
        {
            Product = "Wood Plate Armor",
            DifficultyValue = 23,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(35, WoodLame),
                new RecipeComponent(0.025m, BundleOfCord),
                new RecipeComponent(11, Belt),
                new RecipeComponent(1, Gambeson),
                new RecipeComponent(1, Yexhipanqa),
                new RecipeComponent(0.1m, BoltOfWovenCloth),
                new RecipeComponent(160, Fitting),
            }
        };

        public static BasicRecipe LacqueredWoodArmor => new BasicRecipe()
        {
            Product = "Lacquered Wood Armor",
            DifficultyValue = 23,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(210, LacqueredWoodScale),
                new RecipeComponent(0.05m, BundleOfCord),
                new RecipeComponent(6, Belt),
                new RecipeComponent(1, Gambeson),
                new RecipeComponent(1, Yexhipanqa),
                new RecipeComponent(0.1m, BoltOfWovenCloth),
                new RecipeComponent(40, Fitting),
            }
        };

        public static BasicRecipe LacqueredWoodPlateArmor => new BasicRecipe()
        {
            Product = "Lacquered Wood Plate Armor",
            DifficultyValue = 23,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(35, LacqueredWoodLame),
                new RecipeComponent(0.025m, BundleOfCord),
                new RecipeComponent(11, Belt),
                new RecipeComponent(1, Gambeson),
                new RecipeComponent(1, Yexhipanqa),
                new RecipeComponent(0.1m, BoltOfWovenCloth),
                new RecipeComponent(160, Fitting),
            }
        };

        public static BasicRecipe MetalPlateArmor => new BasicRecipe()
        {
            Product = "Metal Plate Armor",
            DifficultyValue = 23,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(210, MetalScale),
                new RecipeComponent(0.05m, BundleOfCord),
                new RecipeComponent(6, Belt),
                new RecipeComponent(1, Gambeson),
                new RecipeComponent(1, Yexhipanqa),
                new RecipeComponent(0.1m, BoltOfWovenCloth),
                new RecipeComponent(40, Fitting),
            }
        };

        public static BasicRecipe HeavyMetalPlateArmor => new BasicRecipe()
        {
            Product = "Heavy Metal Plate Armor",
            DifficultyValue = 23,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(35, MetalLame),
                new RecipeComponent(0.025m, BundleOfCord),
                new RecipeComponent(11, Belt),
                new RecipeComponent(1, Gambeson),
                new RecipeComponent(1, Yexhipanqa),
                new RecipeComponent(0.1m, BoltOfWovenCloth),
                new RecipeComponent(160, Fitting),
            }
        };

        #endregion Armors
    }
}