using System.Collections.Generic;

namespace oqocs.character
{
    public class KinshipGroup
    {
        public string Name { get; }
        public string Totem { get; }
        public KinshipGroup Parent1 { get; }
        public KinshipGroup Parent2 { get; }
        public KinshipGroup AlwaysAvoid { get; }
        public KinshipGroup FirstPreference { get; }
        public KinshipGroup FirstPrefChild { get; }
        public KinshipGroup FirstPrefAvoid { get; }
        public KinshipGroup SecondPreference { get; }
        public KinshipGroup SecondPrefChild { get; }
        public KinshipGroup SecondPrefAvoid { get; }

        public KinshipGroup(string name,
            string totem,
            KinshipGroup p1,
            KinshipGroup p2,
            KinshipGroup av,
            KinshipGroup fp,
            KinshipGroup fc,
            KinshipGroup fav,
            KinshipGroup sp,
            KinshipGroup sc,
            KinshipGroup sav)
        {
            Name = name;
            Totem = totem;
            Parent1 = p1;
            Parent2 = p2;
            AlwaysAvoid = av;
            FirstPreference = fp;
            FirstPrefChild = fc;
            FirstPrefAvoid = fav;
            SecondPreference = sp;
            SecondPrefChild = sc;
            SecondPrefAvoid = sav;
        }

        public static List<KinshipGroup> All => new List<KinshipGroup>() { A, B, C, D, E, F, G, H, I, J, K, L };
        public static KinshipGroup A = new KinshipGroup("Nekipacho", "Honey-bat", I, J, K, B, E, L, C, G, I);
        public static KinshipGroup B = new KinshipGroup("Takushune", "Breeze", K, L, J, A, E, I, D, H, L);
        public static KinshipGroup C = new KinshipGroup("Tekishano", "Lightning", I, K, J, D, F, L, A, G, I);
        public static KinshipGroup D = new KinshipGroup("Nakupuche", "Giant Bat", J, L, K, C, F, I, B, H, L);
        public static KinshipGroup E = new KinshipGroup("Uqotsenyə", "Mist", A, B, C, F, I, D, G, K, A);
        public static KinshipGroup F = new KinshipGroup("Ezhatosu", "Great Black Octopus", C, D, B, E, I, A, H, L, D);
        public static KinshipGroup G = new KinshipGroup("Uzhotesə", "Alligator-Turtle-Bird", A, C, B, H, J, D, E, K, A);
        public static KinshipGroup H = new KinshipGroup("Eqatsonyu", "Ocean Currents", B, D, C, G, J, A, F, L, D);
        public static KinshipGroup I = new KinshipGroup("Yamapoi", "Herded Llama", E, F, G, J, A, H, K, C, E);
        public static KinshipGroup J = new KinshipGroup("Oxəlawo", "Medic Tree", G, H, F, I, A, E, L, D, H);
        public static KinshipGroup K = new KinshipGroup("Axalowi", "Orange Sand", E, G, F, L, B, H, I, C, E);
        public static KinshipGroup L = new KinshipGroup("Yoməpao", "Weasel Bear", F, H, G, K, B, E, J, D, H);
    }
}