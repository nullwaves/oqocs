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
                var d = recipes.Carpentry.Dowel.ProduceFrom(w);
                Console.WriteLine($"{d.Name} - Value: {d.QualityAdjustedValueInPence()} - DUR: {d.Durability}");
            }
            foreach (Metal m in Metal.All)
            {
                var n = recipes.Toolcraft.Nail.ProduceFrom(null, m);
                Console.WriteLine($"{n.Name} - Value: {n.QualityAdjustedValueInPence()} - DUR: {n.Durability}");
            }
            Console.ReadKey();
        }
    }
}