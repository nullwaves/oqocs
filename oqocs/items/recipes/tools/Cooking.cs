using oqocs.items.materials;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class CookingTools
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            ChefsKnife,
            Pot,
            Kettle,
            Pan,
            TableKnife,
            EatingUtensil,
            Jug,
            Cup,
            Plate,
            Bowl,
        };

        public static BasicRecipe ChefsKnife => new BasicRecipe()
        {
            Product = "Chef's Knife",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 3,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyMetal),
                new RecipeComponent(0.25m, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe Pot => new BasicRecipe()
        {
            Product = "Pot",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe Kettle => new BasicRecipe()
        {
            Product = "Kettle",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Stone.Clay),
            }
        };

        public static BasicRecipe Pan => new BasicRecipe()
        {
            Product = "Pan",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe TableKnife => new BasicRecipe()
        {
            Product = "Table Knife",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyMetal),
                new RecipeComponent(1, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe EatingUtensil => new BasicRecipe()
        {
            Product = "Eating Utensil",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.1m, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe Jug => new BasicRecipe()
        {
            Product = "Jug",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Stone.Clay),
            }
        };

        public static BasicRecipe Cup => new BasicRecipe()
        {
            Product = "Cup",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Stone.Clay),
            }
        };

        public static BasicRecipe Plate => new BasicRecipe()
        {
            Product = "Plate",
            DifficultyValue = 12,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Stone.Clay),
            }
        };

        public static BasicRecipe Bowl => new BasicRecipe()
        {
            Product = "Bowl",
            DifficultyValue = 12,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Stone.Clay),
            }
        };
    }
}