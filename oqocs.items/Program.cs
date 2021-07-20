using oqocs.items.materials;
using System;

namespace oqocs.items
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (Wood w in Wood.All)
            {
                foreach (Stone m in Stone.All)
                {
                    var n = recipes.tools.LoggingTools.StoneWoodaxe.ProduceFrom(w, null, m);
                    Console.WriteLine($"{n.Name} - Value: {CurrencyFormatter.PrettyCopperFromPence(n.QualityAdjustedValueInPence())} - DUR: {n.Durability}");
                }
            }
            Console.ReadKey();
        }
    }
}