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
    }
}