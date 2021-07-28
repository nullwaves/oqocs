using oqocs.items.materials;
using System.Collections.Generic;
using System.Linq;

namespace oqocs.items
{
    internal static class Helpers
    {
        internal static List<T> CompileList<T>(List<T>[] ts)
        {
            int total = 0;
            foreach (List<T> t in ts)
            {
                total += t.Count;
            }
            List<T> newList = new List<T>(total);
            foreach (List<T> t in ts)
            {
                newList.AddRange(t);
            }

            return newList;
        }

        internal static List<BasicItem> AnyMetal => Metal.All.ToList<BasicItem>();
        internal static List<BasicItem> AnyStone => Stone.All.ToList<BasicItem>();
        internal static List<BasicItem> AnyWood => Wood.All.ToList<BasicItem>();
        internal static List<BasicItem> AnyResin => Resin.All.ToList<BasicItem>();
        internal static List<BasicItem> AnyFiber => Fiber.All.ToList<BasicItem>();

        internal static List<BasicItem> AnyMetalOrStone => CompileList(new List<BasicItem>[] { AnyMetal, AnyStone });
        internal static List<BasicItem> AnyWoodOrMetal => CompileList(new List<BasicItem>[] { AnyWood, AnyMetal });
        internal static List<BasicItem> AnyWoodMetalOrStone => CompileList(new List<BasicItem>[] { AnyWood, AnyMetal, AnyStone });

        internal static List<BasicItem> AnyWax => new List<BasicItem>() { Unique.AtzhiyjpakFruitWax, Unique.SjlaomoFruitWax, };
    }
}