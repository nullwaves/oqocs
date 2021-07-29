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

        public Species(string name, int adulthood, int avgLifespan, int ev, int ins, int per, int sta, int hp, int slp, int hng, int thi)
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
        }

        public static List<Species> All => new List<Species>() { Human, Salamander, Bird };
        public static Species Human => new Species("Human", 14, 56, 10, 0, 0, 5, 50, 50, 90, 30);
        public static Species Salamander => new Species("Salamander", 12, 50, 9, 0, 2, 6, 55, 60, 90, 15);
        public static Species Bird => new Species("Bird", 22, 112, 11, 1, 0, 4, 50, 40, 70, 40);
    }
}