using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class ButcheryTools
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            ButcherBlock,
            ButcheringKnfie,
            InscribingSet,
        };

        public static BasicRecipe ButcherBlock => new BasicRecipe()
        {
            Product = "Butcher Block",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3, Helpers.AnyWood),
            }
        };

        public static BasicRecipe ButcheringKnfie => new BasicRecipe()
        {
            Product = "Butchering Knife",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyMetal),
                new RecipeComponent(0.5m, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe InscribingSet => new BasicRecipe()
        {
            Product = "Inscribing Set",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyMetal),
            }
        };
    }
}