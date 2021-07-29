using oqocs.items.materials;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class MedicinecraftTools
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            MortarAndPestle,
            Alembic,
            Grater,
            JuicePress,
            Pipe,
            Censer,
            Bottle,
        };

        public static BasicRecipe MortarAndPestle => new BasicRecipe()
        {
            Product = "Mortar & Pestle",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(4, Helpers.AnyStone),
            }
        };

        public static BasicRecipe Alembic => new BasicRecipe()
        {
            Product = "Alembic",
            DifficultyValue = 37,
            PriceMultiplier = 3,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyMetal),
                new RecipeComponent(2, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Grater => new BasicRecipe()
        {
            Product = "Grater",
            DifficultyValue = 37,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyMetal),
                new RecipeComponent(1, Helpers.AnyWoodMetalOrStone),
            }
        };

        public static BasicRecipe JuicePress => new BasicRecipe()
        {
            Product = "Juice Press",
            DifficultyValue = 15,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1.1m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Pipe => new BasicRecipe()
        {
            Product = "Pipe",
            DifficultyValue = 12,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWood),
            }
        };

        public static BasicRecipe Censer => new BasicRecipe()
        {
            Product = "Censer",
            DifficultyValue = 23,
            PriceMultiplier = 3,
            DurabilityMultiplier = 1.25m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe Bottle => new BasicRecipe()
        {
            Product = "Bottle",
            DifficultyValue = 18,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Stone.Clay),
            }
        };
    }
}