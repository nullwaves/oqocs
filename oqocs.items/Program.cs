using oqocs.items.materials;
using oqocs.items.recipes;
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
                    var n = Tailoring.SpoolOfThread.ProduceFrom();
                    Console.WriteLine($"{n.Name} - Value: {CurrencyFormatter.PrettyCopperFromPence(n.QualityAdjustedValueInPence())} - DUR: {n.Durability}");
                }
            }
            Console.ReadKey();
        }
    }
}