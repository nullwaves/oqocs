using oqocs.items.materials;
using oqocs.items.recipes.carpentry;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class TailoringTools
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            Shears,
            FiberComb,
            Club,
            Spindle,
            FeltPan,
            FeltingFrame,
            Loom,
            PairKnittingNeedles,
            PairCrochetNeedles,
            CarpetLoom,
            TanningBench,
            SandMold,
            File,
            PolishingTools,
            Punch,
            SewingNeedle,
            SewingBoard,
            ShoeStand,
            Awl,
            LeatherKnife,
            DrawingDie,
        };

        public static BasicRecipe Shears => new BasicRecipe()
        {
            Product = "Shears",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyMetal),
                new RecipeComponent(0.25m, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe FiberComb => new BasicRecipe()
        {
            Product = "Fiber Comb",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Club => new BasicRecipe()
        {
            Product = "Club",
            DifficultyValue = 15,
            PriceMultiplier = 1,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Spindle => new BasicRecipe()
        {
            Product = "Spindle",
            DifficultyValue = 15,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.2m, Helpers.AnyWood),
            }
        };

        public static BasicRecipe FeltPan => new BasicRecipe()
        {
            Product = "Felt Pan",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3, Helpers.AnyWood),
            }
        };

        public static BasicRecipe FeltingFrame => new BasicRecipe()
        {
            Product = "Felting Frame",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Loom => new BasicRecipe()
        {
            Product = "Loom",
            DifficultyValue = 28,
            PriceMultiplier = 3,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(75, Helpers.AnyWood),
                new RecipeComponent(1, Tailoring.BundleOfCord),
                new RecipeComponent(20, CarpentryTools.Nail),
                new RecipeComponent(1, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe PairKnittingNeedles => new BasicRecipe()
        {
            Product = "Pair of Knitting Needles",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.125m, Helpers.AnyWoodOrMetal),
            }
        };

        public static BasicRecipe PairCrochetNeedles => new BasicRecipe()
        {
            Product = "Pair of Crochet Needles",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.125m, Helpers.AnyWood),
            }
        };

        public static BasicRecipe CarpetLoom => new BasicRecipe()
        {
            Product = "Carpet Loom",
            DifficultyValue = 28,
            PriceMultiplier = 3,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(150, Helpers.AnyWood),
                new RecipeComponent(2, Tailoring.BundleOfCord),
                new RecipeComponent(40, CarpentryTools.Nail),
                new RecipeComponent(2, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe TanningBench => new BasicRecipe()
        {
            Product = "Tanning Bench",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(10, Helpers.AnyWood),
                new RecipeComponent(16, CarpentryTools.Nail),
            }
        };

        public static BasicRecipe SandMold => new BasicRecipe()
        {
            Product = "Sand Mold",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWood),
            }
        };

        public static BasicRecipe File => new BasicRecipe()
        {
            Product = "File",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyMetal),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe PolishingTools => new BasicRecipe()
        {
            Product = "Polishing Tools",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.01m, Tailoring.BoltOfWovenCloth),
                new RecipeComponent(1, Unique.Sand),
                new RecipeComponent(1, Unique.FineSand),
                new RecipeComponent(1, File),
            }
        };

        public static BasicRecipe Punch => new BasicRecipe()
        {
            Product = "Punch",
            DifficultyValue = 23,
            PriceMultiplier = 1.5m,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(10, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe SewingNeedle => new BasicRecipe()
        {
            Product = "Sewing Needle",
            DifficultyValue = 23,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.01m, Tailoring.SpoolOfWire),
            }
        };

        public static BasicRecipe SewingBoard => new BasicRecipe()
        {
            Product = "Sewing Board",
            DifficultyValue = 12,
            PriceMultiplier = 1,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Helpers.AnyWood),
            }
        };

        public static BasicRecipe ShoeStand => new BasicRecipe()
        {
            Product = "Shoe Stand",
            DifficultyValue = 18,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Awl => new BasicRecipe()
        {
            Product = "Awl",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.1m, Helpers.AnyMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe LeatherKnife => new BasicRecipe()
        {
            Product = "Leather Knife",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyMetal),
                new RecipeComponent(0.5m, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe DrawingDie => new BasicRecipe()
        {
            Product = "Drawing Die",
            DifficultyValue = 28,
            PriceMultiplier = 1,
            DurabilityMultiplier = 4,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Helpers.AnyMetal),
            }
        };
    }
}