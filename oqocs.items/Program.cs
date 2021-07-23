using oqocs.items.recipes;
using System;

namespace oqocs.items
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (BasicRecipe r in Tailoring.WeaveKnitLace)
                Console.WriteLine($"{r.Product}");
            var n = Tailoring.Belt.ProduceFrom();
            Console.WriteLine($"{n.Name} - Value: {CurrencyFormatter.PrettyCopperFromPence(n.QualityAdjustedValueInPence())} - DUR: {n.Durability}");
            Console.ReadKey();
        }
    }
}