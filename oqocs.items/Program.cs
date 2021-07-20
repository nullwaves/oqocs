using oqocs.items.materials;
using System;
using System.Collections.Generic;

namespace oqocs.items
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (Wood w in Wood.All)
            {
                var d = Dowel.ProduceFrom(w);
                Console.WriteLine($"{d.Name} - Value: {d.QualityAdjustedValueInPence()} - DUR: {d.Durability}");
            }
            foreach (Metal m in Metal.All)
            {
                var n = Nail.ProduceFrom(null, m);
                Console.WriteLine($"{n.Name} - Value: {n.QualityAdjustedValueInPence()} - DUR: {n.Durability}");
            }
            Console.ReadKey();
        }

        // TODO: Make a dowel
        public static BasicRecipe Dowel = new BasicRecipe()
        {
            Product = "Dowel",
            DifficultyValue = 12,
            PriceMultiplier = 5,
            DurabilityMultiplier = 1,
            Components = new List<RecipeComponent>() { new RecipeComponent(ComponentType.Wood, 1) }
        };

        public static BasicRecipe Nail = new BasicRecipe()
        {
            Product = "Nail",
            DifficultyValue = 12,
            PriceMultiplier = 1.25m,
            DurabilityMultiplier = 2,
            Components = new List<RecipeComponent>() { new RecipeComponent(ComponentType.Metal, 0.0125m) }
        };
    }
}