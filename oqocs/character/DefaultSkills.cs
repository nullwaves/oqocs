using oqocs.items;
using System.Collections.Generic;

namespace oqocs.character
{
    public static class DefaultSkills
    {
        internal static int[] CarpentryTwo => new int[] { 500, 750 };
        internal static int[] DefaultThree => new int[] { 250, 500, 750 };
        internal static int[] DefaultFour => new int[] { 250, 500, 750, 1000 };
        internal static int[] DefaultSpread => new int[] { 250, 500, 750, 1000, 1500 };
        internal static int[] LowStartSpread => new int[] { 125, 250, 500, 750, 1000 };
        internal static int[] LowFour => new int[] { 125, 250, 500, 1000 };
        internal static int[] HighFour => new int[] { 500, 750, 1000, 1500 };
        internal static int[] StealthSpread => new int[] { 250, 500, 750, 1000, 1500, 2500 };

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

        public static Skill Logging => new Skill(
            "Logging",
            new SkillBonus[]
            {
                new SkillBonus("Gathering Rate", new int[] { 500, 750, 1000, 1500, 2000 }),
            });

        public static Skill Fishing => new Skill(
            "Fishing",
            new SkillBonus[]
            {
                new SkillBonus("Rod Fishing", DefaultSpread),
                new SkillBonus("Net Fishing", DefaultSpread),
                new SkillBonus("Trap Fishing", DefaultSpread),
            });

        public static Skill Mining => new Skill(
            "Mining",
            new SkillBonus[]
            {
                new SkillBonus("Mining Yield Quality", DefaultSpread),
                new SkillBonus("Mining Rate", DefaultSpread),
            });

        public static Skill Survival => new Skill(
            "Survival",
            new SkillBonus[]
            {
                new SkillBonus("Gather Food", DefaultThree),
                new SkillBonus("Gather Firewood", DefaultThree),
                new SkillBonus("Gather Medicine", DefaultThree),
                new SkillBonus("Gather Resin Components", DefaultThree),
                new SkillBonus("Small Game Tracking", DefaultThree),
                new SkillBonus("Medium Game Tracking", DefaultThree),
                new SkillBonus("Large Game Tracking", DefaultThree),
                new SkillBonus("Exotic Game Tracking", DefaultThree),
                new SkillBonus("Forest Tracking", DefaultThree),
                new SkillBonus("Desert Tracking", DefaultThree),
                new SkillBonus("Snowy Tracking", DefaultThree),
                new SkillBonus("Grassland Tracking", DefaultThree),
                new SkillBonus("Highland Tracking", DefaultThree),
                new SkillBonus("Snare Traps", DefaultThree),
                new SkillBonus("Pitfall Traps", DefaultThree),
                new SkillBonus("Cage Traps", DefaultThree),
            });

        public static Skill Husbandry => new Skill(
            "Husbandry",
            new SkillBonus[]
            {
                new SkillBonus("Training", DefaultThree),
                new SkillBonus("Herd Size", LowStartSpread),
                new SkillBonus("Riding", DefaultSpread),
                new SkillBonus("Breaking", DefaultSpread),
                new SkillBonus("Exotic Animal Taming", DefaultSpread),
                new SkillBonus("Breeding", LowStartSpread),
            });

        public static Skill Carpentry => new Skill(
            "Carpentry",
            new SkillBonus[]
            {
                new SkillBonus("Base Quality", DefaultFour),
                new SkillBonus("Base Rate", DefaultFour),
                new SkillBonus("Furniture Quality", CarpentryTwo),
                new SkillBonus("Furniture Rate", CarpentryTwo),
                new SkillBonus("Upholstery Quality", CarpentryTwo),
                new SkillBonus("Upholstery Rate", CarpentryTwo),
                new SkillBonus("Cabinetry Quality", CarpentryTwo),
                new SkillBonus("Cabinetry Rate", CarpentryTwo),
                new SkillBonus("Surfaces Quality", CarpentryTwo),
                new SkillBonus("Surfaces Rate", CarpentryTwo),
                new SkillBonus("Structures Quality", CarpentryTwo),
                new SkillBonus("Structures Rate", CarpentryTwo),
                new SkillBonus("Masonry Quality", CarpentryTwo),
                new SkillBonus("Masonry Rate", CarpentryTwo),
                new SkillBonus("Housing Quality", CarpentryTwo),
                new SkillBonus("Housing Rate", CarpentryTwo),
                new SkillBonus("Utility Quality", CarpentryTwo),
                new SkillBonus("Utility Rate", CarpentryTwo),
                new SkillBonus("Improvised Quality", DefaultSpread),
                new SkillBonus("Improvised Rate", DefaultSpread),
            });

        public static Skill Cooking => new Skill(
            "Cooking",
            new SkillBonus[]
            {
                new SkillBonus("Regional Cuisine Quality", DefaultSpread),
                new SkillBonus("Regional Cuisine Rate", DefaultSpread),
                new SkillBonus("Dish Quality", DefaultSpread),
                new SkillBonus("Dish Rate", DefaultSpread),
            });

        public static Skill Liquorcraft => new Skill(
            "Liquorcraft",
            new SkillBonus[]
            {
                new SkillBonus("Distilling", DefaultSpread),
                new SkillBonus("Brewing", DefaultSpread),
                new SkillBonus("Fermenting", DefaultSpread),
            });

        public static Skill Toolcraft => new Skill(
            "Toolcraft",
            new SkillBonus[]
            {
                new SkillBonus("Tools Quality", DefaultSpread),
                new SkillBonus("Tools Rate", DefaultSpread),
                new SkillBonus("Weapons Quality", DefaultSpread),
                new SkillBonus("Weapons Rate", DefaultSpread),
                new SkillBonus("Mechanical Rate", DefaultSpread),
                new SkillBonus("Max Mechanical Complexity", DefaultSpread),
            });

        public static Skill Tailoring => new Skill(
            "Tailoring",
            new SkillBonus[]
            {
                new SkillBonus("Shearing", DefaultFour),
                new SkillBonus("Armorcraft Quality", HighFour),
                new SkillBonus("Armorcraft Rate", HighFour),
                new SkillBonus("Clothing Quality", DefaultFour),
                new SkillBonus("Clothing Rate", DefaultFour),
                new SkillBonus("Threadwork Quality", DefaultFour),
                new SkillBonus("Threadwork Rate", DefaultFour),
            });

        public static Skill Medicine => new Skill(
            "Medicinecraft",
            new SkillBonus[]
            {
                new SkillBonus("Diagnosis", DefaultSpread),
                new SkillBonus("Crafting Quality", DefaultSpread),
                new SkillBonus("Crafting Rate", DefaultSpread),
            });

        public static Skill Butchery => new Skill(
            "Butchery",
            new SkillBonus[]
            {
                new SkillBonus("Non-Sapient Yield", DefaultFour),
                new SkillBonus("Non-Sapient Rate", DefaultFour),
                new SkillBonus("Sapient Yield", DefaultFour),
                new SkillBonus("Sapient Rate", DefaultFour),
            });

        public static Skill Inscriptions => new Skill(
            "Inscriptions",
            new SkillBonus[]
            {
                new SkillBonus("Inscription Quality", DefaultSpread),
                new SkillBonus("Inscribing Rate", DefaultSpread),
                new SkillBonus("Rune Retention", DefaultSpread),
            });

        public static Skill Resin => new Skill(
            "Resin",
            new SkillBonus[]
            {
                new SkillBonus("Resincraft Quality", DefaultSpread),
                new SkillBonus("Resincraft Rate", DefaultSpread),
                new SkillBonus("Component Preparation", DefaultSpread),
            });

        public static Skill LightArms => new Skill(
            "Light Arms",
            new SkillBonus[]
            {
                new SkillBonus("Daggers", DefaultFour),
                new SkillBonus("Swords", DefaultFour),
                new SkillBonus("Hand-Axes & Maces", DefaultFour),
                new SkillBonus("Light Polearms", DefaultFour),
            });

        public static Skill HeavyArms => new Skill(
            "Heavy Arms",
            new SkillBonus[]
            {
                new SkillBonus("Greatswords", DefaultFour),
                new SkillBonus("Heavy Axes", DefaultFour),
                new SkillBonus("Heavy Hammers", DefaultFour),
                new SkillBonus("Polearms", DefaultFour),
            });

        public static Skill ThrownWeapons => new Skill(
            "Thrown Weapons",
            new SkillBonus[]
            {
                new SkillBonus("Blades", DefaultFour),
                new SkillBonus("Bones", DefaultFour),
                new SkillBonus("Polearms", DefaultFour),
                new SkillBonus("Improvised", DefaultFour),
            });

        public static Skill RangedWeapons => new Skill(
            "Ranged Weapons",
            new SkillBonus[]
            {
                new SkillBonus("Shortbow", DefaultFour),
                new SkillBonus("Longbow", DefaultFour),
                new SkillBonus("Crossbow", DefaultFour),
                new SkillBonus("Mounted Archery", DefaultFour),
            });

        public static Skill Armor => new Skill(
            "Armor",
            new SkillBonus[]
            {
                new SkillBonus("Improved Joints", DefaultFour),
                new SkillBonus("Shield Training", DefaultFour),
                new SkillBonus("Heavy Lifting", new int[] { 1000, 1500 }),
            });

        public static Skill Stealth => new Skill(
            "Stearlth",
            new SkillBonus[]
            {
                new SkillBonus("Move Silently", StealthSpread),
                new SkillBonus("Disguise", StealthSpread),
            });

        public static Skill SleightOfHand => new Skill(
            "Sleight of Hand",
            new SkillBonus[]
            {
                new SkillBonus("Lockpicking Rate", LowFour),
                new SkillBonus("Lockpicking Ability", LowFour),
                new SkillBonus("Pickpocketing", LowFour),
                new SkillBonus("Trickery", LowFour),
            });

        public static Skill Performance => new Skill(
            "Performance",
            new SkillBonus[]
            {
                new SkillBonus("Song", LowStartSpread),
                new SkillBonus("Dance", LowStartSpread),
                new SkillBonus("Public Speaking", LowStartSpread),
                new SkillBonus("Intimidation", LowStartSpread),
                new SkillBonus("Deception", LowStartSpread),
            });
    }
}