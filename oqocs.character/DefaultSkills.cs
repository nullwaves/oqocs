namespace oqocs.character
{
    public static class DefaultSkills
    {
        internal static int[] CarpentryTwo => new int[] { 500, 750 };

        internal static int[] defaultThree => new int[] { 250, 500, 750 };

        internal static int[] defaultFour => new int[] { 250, 500, 750, 1000 };

        internal static int[] defaultSpread => new int[] { 250, 500, 750, 1000, 1500 };

        internal static int[] lowStartSpread => new int[] { 125, 250, 500, 750, 1000 };
        internal static int[] LowFour => new int[] { 125, 250, 500, 1000 };
        internal static int[] HighFour => new int[] { 500, 750, 1000, 1500 };
        internal static int[] StealthSpread => new int[] { 250, 500, 750, 1000, 1500, 2500 };

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
                new SkillBonus("Rod Fishing", defaultSpread),
                new SkillBonus("Net Fishing", defaultSpread),
                new SkillBonus("Trap Fishing", defaultSpread),
            });

        public static Skill Mining => new Skill(
            "Mining",
            new SkillBonus[]
            {
                new SkillBonus("Mining Yield Quality", defaultSpread),
                new SkillBonus("Mining Rate", defaultSpread),
            });

        public static Skill Survival => new Skill(
            "Survival",
            new SkillBonus[]
            {
                new SkillBonus("Gather Food", defaultThree),
                new SkillBonus("Gather Firewood", defaultThree),
                new SkillBonus("Gather Medicine", defaultThree),
                new SkillBonus("Gather Resin Components", defaultThree),
                new SkillBonus("Small Game Tracking", defaultThree),
                new SkillBonus("Medium Game Tracking", defaultThree),
                new SkillBonus("Large Game Tracking", defaultThree),
                new SkillBonus("Exotic Game Tracking", defaultThree),
                new SkillBonus("Forest Tracking", defaultThree),
                new SkillBonus("Desert Tracking", defaultThree),
                new SkillBonus("Snowy Tracking", defaultThree),
                new SkillBonus("Grassland Tracking", defaultThree),
                new SkillBonus("Highland Tracking", defaultThree),
                new SkillBonus("Snare Traps", defaultThree),
                new SkillBonus("Pitfall Traps", defaultThree),
                new SkillBonus("Cage Traps", defaultThree),
            });

        public static Skill Husbandry => new Skill(
            "Husbandry",
            new SkillBonus[]
            {
                new SkillBonus("Training", defaultThree),
                new SkillBonus("Herd Size", lowStartSpread),
                new SkillBonus("Riding", defaultSpread),
                new SkillBonus("Breaking", defaultSpread),
                new SkillBonus("Exotic Animal Taming", defaultSpread),
                new SkillBonus("Breeding", lowStartSpread),
            });

        public static Skill Carpentry => new Skill(
            "Carpentry",
            new SkillBonus[]
            {
                new SkillBonus("Base Quality", defaultFour),
                new SkillBonus("Base Rate", defaultFour),
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
                new SkillBonus("Improvised Quality", defaultSpread),
                new SkillBonus("Improvised Rate", defaultSpread),
            });

        public static Skill Cooking => new Skill(
            "Cooking",
            new SkillBonus[]
            {
                new SkillBonus("Regional Cuisine Quality", defaultSpread),
                new SkillBonus("Regional Cuisine Rate", defaultSpread),
                new SkillBonus("Dish Quality", defaultSpread),
                new SkillBonus("Dish Rate", defaultSpread),
            });

        public static Skill Liquorcraft => new Skill(
            "Liquorcraft",
            new SkillBonus[]
            {
                new SkillBonus("Distilling", defaultSpread),
                new SkillBonus("Brewing", defaultSpread),
                new SkillBonus("Fermenting", defaultSpread),
            });

        public static Skill Toolcraft => new Skill(
            "Toolcraft",
            new SkillBonus[]
            {
                new SkillBonus("Tools Quality", defaultSpread),
                new SkillBonus("Tools Rate", defaultSpread),
                new SkillBonus("Weapons Quality", defaultSpread),
                new SkillBonus("Weapons Rate", defaultSpread),
                new SkillBonus("Mechanical Rate", defaultSpread),
                new SkillBonus("Max Mechanical Complexity", defaultSpread),
            });

        public static Skill Tailoring = new Skill(
            "Tailoring",
            new SkillBonus[]
            {
                new SkillBonus("Shearing", defaultFour),
                new SkillBonus("Armorcraft Quality", HighFour),
                new SkillBonus("Armorcraft Rate", HighFour),
                new SkillBonus("Clothing Quality", defaultFour),
                new SkillBonus("Clothing Rate", defaultFour),
                new SkillBonus("Threadwork Quality", defaultFour),
                new SkillBonus("Threadwork Rate", defaultFour),
            });

        public static Skill Medicine => new Skill(
            "Medicinecraft",
            new SkillBonus[]
            {
                new SkillBonus("Diagnosis", defaultSpread),
                new SkillBonus("Crafting Quality", defaultSpread),
                new SkillBonus("Crafting Rate", defaultSpread),
            });

        public static Skill Butchery => new Skill(
            "Butchery",
            new SkillBonus[]
            {
                new SkillBonus("Non-Sapient Yield", defaultFour),
                new SkillBonus("Non-Sapient Rate", defaultFour),
                new SkillBonus("Sapient Yield", defaultFour),
                new SkillBonus("Sapient Rate", defaultFour),
            });

        public static Skill Inscriptions => new Skill(
            "Inscriptions",
            new SkillBonus[]
            {
                new SkillBonus("Inscription Quality", defaultSpread),
                new SkillBonus("Inscribing Rate", defaultSpread),
                new SkillBonus("Rune Retention", defaultSpread),
            });

        public static Skill Resin => new Skill(
            "Resin",
            new SkillBonus[]
            {
                new SkillBonus("Resincraft Quality", defaultSpread),
                new SkillBonus("Resincraft Rate", defaultSpread),
                new SkillBonus("Component Preparation", defaultSpread),
            });

        public static Skill LightArms => new Skill(
            "Light Arms",
            new SkillBonus[]
            {
                new SkillBonus("Daggers", defaultFour),
                new SkillBonus("Swords", defaultFour),
                new SkillBonus("Hand-Axes & Maces", defaultFour),
                new SkillBonus("Light Polearms", defaultFour),
            });

        public static Skill HeavyArms => new Skill(
            "Heavy Arms",
            new SkillBonus[]
            {
                new SkillBonus("Greatswords", defaultFour),
                new SkillBonus("Heavy Axes", defaultFour),
                new SkillBonus("Heavy Hammers", defaultFour),
                new SkillBonus("Polearms", defaultFour),
            });

        public static Skill ThrownWeapons => new Skill(
            "Thrown Weapons",
            new SkillBonus[]
            {
                new SkillBonus("Blades", defaultFour),
                new SkillBonus("Bones", defaultFour),
                new SkillBonus("Polearms", defaultFour),
                new SkillBonus("Improvised", defaultFour),
            });

        public static Skill RangedWeapons => new Skill(
            "Ranged Weapons",
            new SkillBonus[]
            {
                new SkillBonus("Shortbow", defaultFour),
                new SkillBonus("Longbow", defaultFour),
                new SkillBonus("Crossbow", defaultFour),
                new SkillBonus("Mounted Archery", defaultFour),
            });

        public static Skill Armor => new Skill(
            "Armor",
            new SkillBonus[]
            {
                new SkillBonus("Improved Joints", defaultFour),
                new SkillBonus("Shield Training", defaultFour),
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
                new SkillBonus("Song", lowStartSpread),
                new SkillBonus("Dance", lowStartSpread),
                new SkillBonus("Public Speaking", lowStartSpread),
                new SkillBonus("Intimidation", lowStartSpread),
                new SkillBonus("Deception", lowStartSpread),
            });
    }
}