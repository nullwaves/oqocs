using oqocs.items.materials;
using oqocs.items.recipes.carpentry;
using System.Collections.Generic;

namespace oqocs.items.recipes.tools
{
    public static class Weapons
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            Spear,
            Dagger,
            Sword,
            Mace,
            Handaxe,
            Greatsword,
            Battleaxe,
            HeavyMace,
            Bill,
            Pike,
            Bowstring,
            Shortbow,
            Longbow,
            Sling,
            Arrow,
            Bullet,
            SetOfDarts,
            Javelin,
        };

        public static BasicRecipe Spear => new BasicRecipe()
        {
            Product = "Spear",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Dagger => new BasicRecipe()
        {
            Product = "Dagger",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Sword => new BasicRecipe()
        {
            Product = "Sword",
            DifficultyValue = 28,
            PriceMultiplier = 3,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3.5m, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Mace => new BasicRecipe()
        {
            Product = "Mace",
            DifficultyValue = 15,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(3.5m, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Handaxe => new BasicRecipe()
        {
            Product = "Handaxe",
            DifficultyValue = 18,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(2, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Greatsword => new BasicRecipe()
        {
            Product = "Greatsword",
            DifficultyValue = 37,
            PriceMultiplier = 4,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(5, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Battleaxe => new BasicRecipe()
        {
            Product = "Battleaxe",
            DifficultyValue = 20,
            PriceMultiplier = 2,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(4.5m, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe HeavyMace => new BasicRecipe()
        {
            Product = "Heavy Mace",
            DifficultyValue = 20,
            PriceMultiplier = 2,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(7, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Bill => new BasicRecipe()
        {
            Product = "Bill",
            DifficultyValue = 18,
            PriceMultiplier = 3,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Pike => new BasicRecipe()
        {
            Product = "Pike",
            DifficultyValue = 15,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };

        public static BasicRecipe Bowstring => new BasicRecipe()
        {
            Product = "Bowstring",
            DifficultyValue = 15,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.005625m, Tailoring.BundleOfCord),
            }
        };

        public static BasicRecipe Shortbow => new BasicRecipe()
        {
            Product = "Shortbow",
            DifficultyValue = 23,
            PriceMultiplier = 3,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWood),
                new RecipeComponent(1, Bowstring),
            }
        };

        public static BasicRecipe Longbow => new BasicRecipe()
        {
            Product = "Longbow",
            DifficultyValue = 28,
            PriceMultiplier = 3,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWood),
                new RecipeComponent(1, Bowstring),
            }
        };

        public static BasicRecipe Sling => new BasicRecipe()
        {
            Product = "Sling",
            DifficultyValue = 20,
            PriceMultiplier = 1.1m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Tailoring.MediumLeather),
            }
        };

        public static BasicRecipe Arrow => new BasicRecipe()
        {
            Product = "Arrow",
            DifficultyValue = 18,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.25m, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(0.25m, Helpers.AnyWood),
                new RecipeComponent(4, Unique.Feather)
            }
        };

        public static BasicRecipe Bullet => new BasicRecipe()
        {
            Product = "Bullet",
            DifficultyValue = 12,
            PriceMultiplier = 1,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.05m, Helpers.AnyStone),
            }
        };

        public static BasicRecipe SetOfDarts => new BasicRecipe()
        {
            Product = "Set of Darts",
            DifficultyValue = 20,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyMetal),
            }
        };

        public static BasicRecipe Javelin => new BasicRecipe()
        {
            Product = "Javelin",
            DifficultyValue = 15,
            PriceMultiplier = 1.75m,
            DurabilityMultiplier = 1.5m,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(0.5m, Helpers.AnyWoodMetalOrStone),
                new RecipeComponent(1, Furniture.Dowel),
            }
        };
    }
}