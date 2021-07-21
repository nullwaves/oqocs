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

        /*public static BasicRecipe BoltOfWovenCloth => new BasicRecipe()
        {
            Product = "Bolt of Woven Cloth",
            DifficultyValue = 23,
            PriceMultiplier = 8,
            DurabilityMultiplier = 10,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(ComponentType.Multi)
            }
        }*/
    }
}