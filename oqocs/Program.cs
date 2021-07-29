using oqocs.items;
using System;

namespace oqocs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (var rec in items.recipes.Toolcraft.Weapons)
            {
                var finalItem = ItemBuilder.BuildRandomItem(rec);
                Console.WriteLine($"\n\nBuilt {finalItem.Name} Valued at {CurrencyFormatter.PrettyCopperFromPence(finalItem.QualityAdjustedValueInPence())} with DUR {finalItem.Durability}\n" +
                    $"{finalItem.Description}\n");
            }
            Console.ReadKey();
        }
    }
}