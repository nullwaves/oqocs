using oqocs.items.recipes.tools;
using System.Collections.Generic;

namespace oqocs.items.recipes.carpentry
{
    public static class Furniture
    {
        public static List<BasicRecipe> All => new List<BasicRecipe>()
        {
            Dowel,
            Lampstick,
            Candlestick,
            Stool,
            EndTable,
            Bookshelf,
            CoffeeTable,
            KitchenTable,
            BigTable,
            Desk,
            Cabinets,
            Wardrobe,
            BedFrame,
            Bench,
            Chair,
            Couch,
        };

        public static BasicRecipe Dowel => new BasicRecipe()
        {
            Product = "Dowel",
            DifficultyValue = 12,
            PriceMultiplier = 5,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Helpers.AnyWood)
            }
        };

        public static BasicRecipe Lampstick => new BasicRecipe()
        {
            Product = "Lampstick",
            DifficultyValue = 15,
            PriceMultiplier = 7,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Dowel),
            }
        };

        public static BasicRecipe Candlestick => new BasicRecipe()
        {
            Product = "Candlestick",
            DifficultyValue = 12,
            PriceMultiplier = 5,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(1, Dowel),
            }
        };

        public static BasicRecipe Stool => new BasicRecipe()
        {
            Product = "Stool",
            DifficultyValue = 15,
            PriceMultiplier = 7,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(156, Helpers.AnyWood),
                new RecipeComponent(12, CarpentryTools.Nail),
            }
        };

        public static BasicRecipe EndTable => new BasicRecipe()
        {
            Product = "End Table",
            DifficultyValue = 18,
            PriceMultiplier = 10,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(156, Helpers.AnyWood),
                new RecipeComponent(12, CarpentryTools.Nail),
            }
        };

        public static BasicRecipe Bookshelf => new BasicRecipe()
        {
            Product = "Bookshelf",
            DifficultyValue = 15,
            PriceMultiplier = 13,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(312, Helpers.AnyWood),
                new RecipeComponent(20, CarpentryTools.Nail),
            }
        };

        public static BasicRecipe CoffeeTable => new BasicRecipe()
        {
            Product = "Coffee Table",
            DifficultyValue = 18,
            PriceMultiplier = 13,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(312, Helpers.AnyWood),
                new RecipeComponent(12, CarpentryTools.Nail),
            }
        };

        public static BasicRecipe KitchenTable => new BasicRecipe()
        {
            Product = "Kitchen Table",
            DifficultyValue = 20,
            PriceMultiplier = 13,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(468, Helpers.AnyWood),
                new RecipeComponent(24, CarpentryTools.Nail),
            }
        };

        public static BasicRecipe BigTable => new BasicRecipe()
        {
            Product = "Big Table",
            DifficultyValue = 20,
            PriceMultiplier = 15,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(624, Helpers.AnyWood),
                new RecipeComponent(32, CarpentryTools.Nail),
            }
        };

        public static BasicRecipe Desk => new BasicRecipe()
        {
            Product = "Desk",
            DifficultyValue = 23,
            PriceMultiplier = 13,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(468, Helpers.AnyWood),
                new RecipeComponent(32, CarpentryTools.Nail),
            }
        };

        public static BasicRecipe Cabinets => new BasicRecipe()
        {
            Product = "Cabinets",
            DifficultyValue = 20,
            PriceMultiplier = 13,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(234, Helpers.AnyWood),
                new RecipeComponent(8, CarpentryTools.Nail),
                new RecipeComponent(2, CarpentryTools.Hinge),
            }
        };

        public static BasicRecipe Wardrobe => new BasicRecipe()
        {
            Product = "Wardrobe",
            DifficultyValue = 23,
            PriceMultiplier = 15,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(390, Helpers.AnyWood),
                new RecipeComponent(12, CarpentryTools.Nail),
                new RecipeComponent(3, CarpentryTools.Hinge),
            }
        };

        public static BasicRecipe BedFrame => new BasicRecipe()
        {
            Product = "Bed Frame",
            DifficultyValue = 23,
            PriceMultiplier = 13,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(468, Helpers.AnyWood),
                new RecipeComponent(18, CarpentryTools.Nail),
            }
        };

        public static BasicRecipe Bench => new BasicRecipe()
        {
            Product = "Bench",
            DifficultyValue = 15,
            PriceMultiplier = 13,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(312, Helpers.AnyWood),
                new RecipeComponent(18, CarpentryTools.Nail),
            }
        };

        public static BasicRecipe Chair => new BasicRecipe()
        {
            Product = "Chair",
            DifficultyValue = 18,
            PriceMultiplier = 10,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(156, Helpers.AnyWood),
                new RecipeComponent(12, CarpentryTools.Nail),
                new RecipeComponent(0.05m, Tailoring.BoltOfWovenCloth),
                new RecipeComponent(0.01255m, Tailoring.SpoolOfThread),
            }
        };

        public static BasicRecipe Couch => new BasicRecipe()
        {
            Product = "Couch",
            DifficultyValue = 23,
            PriceMultiplier = 15,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>()
            {
                new RecipeComponent(312, Helpers.AnyWood),
                new RecipeComponent(64, CarpentryTools.Nail),
                new RecipeComponent(0.15m, Tailoring.BoltOfWovenCloth),
                new RecipeComponent(0.0375m, Tailoring.SpoolOfThread),
            }
        };
    }
}