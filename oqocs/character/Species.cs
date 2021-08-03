using System.Collections.Generic;

namespace oqocs.character
{
    public class Species
    {
        public string Name { get; }
        public int Adulthood { get; }
        public int AverageLifespan { get; }
        public int EV { get; }
        public int INS { get; }
        public int PER { get; }
        public int STA { get; }
        public int HP { get; }
        public int SLP { get; }
        public int HNG { get; }
        public int THI { get; }

        public string[] HairColors { get; }
        public string[] EyeColors { get; }

        public int MinHeightInInches { get; }
        public int MaxHeightInInches { get; }
        public int MinWeightInPounds { get; }
        public int MaxWeightInPounds { get; }

        public Species(string name, int adulthood, int avgLifespan, int ev, int ins, int per, int sta, int hp, int slp, int hng, int thi, string[] hair, string[] eyes, int minHeight, int maxHeight, int minWeight, int maxWeight)
        {
            Name = name;
            Adulthood = adulthood;
            AverageLifespan = avgLifespan;
            EV = ev;
            INS = ins;
            PER = per;
            STA = sta;
            HP = hp;
            SLP = slp;
            HNG = hng;
            THI = thi;
            HairColors = hair;
            EyeColors = eyes;
            MinHeightInInches = minHeight;
            MaxHeightInInches = maxHeight;
            MinWeightInPounds = minWeight;
            MaxWeightInPounds = maxWeight;
        }

        public static List<Species> All => new List<Species>() { Human, Salamander, Bird };

        public static Species Human => new Species("Human",
                                                   14,
                                                   56,
                                                   10,
                                                   0,
                                                   0,
                                                   5,
                                                   50,
                                                   50,
                                                   90,
                                                   30,
                                                   new string[] { "Black", "Dark Brown", "Brown", "Auburn" },
                                                   new string[] { "Brown", "Dark Violet", "Emerald", "Obsidian" },
                                                   61,
                                                   91,
                                                   90,
                                                   300);

        public static Species Salamander => new Species("Salamander",
                                                        12,
                                                        50,
                                                        9,
                                                        0,
                                                        2,
                                                        6,
                                                        55,
                                                        60,
                                                        90,
                                                        15,
                                                        new string[] { "Ruby", "Turquoise", "Violet", "Amethyst", "Copper", "Navy", "Emerald", "Sapphire", "Obsidian", "Brown", "Dark Gray", "Amber", "Vermillion" },
                                                        new string[] { "Ruby", "Turquoise", "Violet", "Amethyst", "Copper", "Navy", "Emerald", "Sapphire", "Obsidian", "Brown", "Dark Gray", "Amber", "Vermillion" },
                                                        72,
                                                        101,
                                                        130,
                                                        450);

        public static Species Bird => new Species("Bird",
                                                  22,
                                                  112,
                                                  11,
                                                  1,
                                                  0,
                                                  4,
                                                  50,
                                                  40,
                                                  70,
                                                  40,
                                                  new string[] { "Ruby", "Turquoise", "Violet", "Amethyst", "Copper", "Navy", "Emerald", "Sapphire", "Obsidian", "Brown", "Dark Gray", "Amber", "Vermillion", "Pink", "Cyan", "Magenta", "Yellow", "Blue", "Green", "Lime", "White", "Gray", "Tan", "Orange" },
                                                  new string[] { "Brown", "Dark Violet", "Emerald", "Obsidian", "Dark Yellow" },
                                                  67,
                                                  93,
                                                  90,
                                                  200);
    }
}