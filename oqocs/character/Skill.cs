using oqocs.items;
using System.Collections.Generic;

namespace oqocs.character
{
    public class Skill
    {
        public string Name { get; set; }

        public Skill(string name)
        {
            Name = name;
        }

        public static List<Skill> All => Helpers.CompileList(new List<Skill>[] { Gathering, Crafting, Weapons, Social });

        public static List<Skill> Gathering => new List<Skill>()
        {
            Logging,
            Fishing,
            Mining,
            Survival,
            Husbandry,
        };

        public static List<Skill> Crafting => new List<Skill>()
        {
            Carpentry,
            Cooking,
            Liquorcraft,
            Toolcraft,
            Tailoring,
            Medicine,
            Butchery,
            Inscriptions,
            Resin,
        };

        public static List<Skill> Weapons => new List<Skill>()
        {
            LightArms,
            HeavyArms,
            ThrownWeapons,
            RangedWeapons,
        };

        public static List<Skill> Social => new List<Skill>()
        {
            Armor,
            Stealth,
            SleightOfHand,
            Performance,
        };

        public static Skill Logging => new Skill("Logging");
        public static Skill Fishing => new Skill("Fishing");
        public static Skill Mining => new Skill("Mining");
        public static Skill Survival => new Skill("Survival");
        public static Skill Husbandry => new Skill("Husbandry");
        public static Skill Carpentry => new Skill("Carpentry");
        public static Skill Cooking => new Skill("Cooking");
        public static Skill Liquorcraft => new Skill("Liquorcraft");
        public static Skill Toolcraft => new Skill("Toolcraft");
        public static Skill Tailoring => new Skill("Tailoring");
        public static Skill Medicine => new Skill("Medicine");
        public static Skill Butchery => new Skill("Butchery");
        public static Skill Inscriptions => new Skill("Inscriptions");
        public static Skill Resin => new Skill("Resin");
        public static Skill LightArms => new Skill("Light Arms");
        public static Skill HeavyArms => new Skill("Heavy Arms");
        public static Skill ThrownWeapons => new Skill("Thrown Weapons");
        public static Skill RangedWeapons => new Skill("Ranged Weapons");
        public static Skill Armor => new Skill("Armor");
        public static Skill Stealth => new Skill("Stealth");
        public static Skill SleightOfHand => new Skill("Sleight Of Hand");
        public static Skill Performance => new Skill("Performance");
    }
}