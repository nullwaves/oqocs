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

        public static List<SkillBonus> All => new List<SkillBonus>()
        {
            LoggingRate,
            RodFishing, NetFishing, TrapFishing,
            MiningQuality, MiningRate,
            GatherFood, GatherFirewood, GatherMedicine,GatherResinComponents,
            SmallGameTracking, MediumGameTracking, LargeGameTracking, ExoticGameTracking, ForestTracking, DesertTracking, SnowyTracking, GrasslandTracking, HighlandTracking,
            SnareTraps, PitfallTraps, CageTraps,
            Training, HerdSize, Riding, Breaking, ExoticTaming, Breeding,
            BaseQuality, BaseRate, FurnitureQuality, FurnitureRate, UpholsteryQuality, UpholsteryRate, CabinetryQuality, CabinetryRate, SurfacesQuality, SurfacesRate,
            StructuresQuality, StructuresRate, MasonryQuality, MasonryRate, HousingQuality, HousingRate, UtilityQuality, UtilityRate, ImprovisedQuality, ImprovisedRate,
            RegionalQuality, RegionalRate, DishQuality, DishRate,
            Distilling, Brewing, Fermenting,
            ToolQuality, ToolRate, WeaponQuality, WeaponRate, MechanicalRate, MechanicalComplexity,
            ArmorQuality, ArmorRate, ClothingQuality, ClothingRate, ThreadworkQuality, ThreadworkRate,
            Diagnosis, MedicineQuality, MedicineRate,
            NSBoneYield, NSBoneRate, SapientYield, SapientRate,
            InscriptionQuality, InscriptionRate, RuneRetention,
            ResinQuality, ResinRate, ComponentPreparation,
            Daggers, Sword, HandAxes, Polearms,
            Greatswords, HeavyAxes, Hammers, HeavyPolearms,
            Blades, Bones, ThrownPolearms, ImprovisedThrown,
            Shortbow, Longbow, Crossbow, MountedArchery,
            ImprovedJoints, ShieldTraining, HeavyLifting,
            MoveSilently, Disguise,
            LockpickingRate, LockpickingAbility, Pickpocketing, Trickery,
            Song, Dance, PublicSpeaking, Intimidation, Deception,
        };

        // Logging

        public static SkillBonus LoggingRate => new SkillBonus(Skill.Logging, "Gathering Rate", new int[] { 500, 750, 1000, 1500, 2000 });

        // Fishing

        public static SkillBonus RodFishing => new SkillBonus(Skill.Fishing, "Rod Fishing", DefaultSpread);
        public static SkillBonus NetFishing => new SkillBonus(Skill.Fishing, "Net Fishing", DefaultSpread);
        public static SkillBonus TrapFishing => new SkillBonus(Skill.Fishing, "Trap Fishing", DefaultSpread);

        // Mining

        public static SkillBonus MiningQuality => new SkillBonus(Skill.Mining, "Mining Yield Quality", DefaultSpread);
        public static SkillBonus MiningRate => new SkillBonus(Skill.Mining, "Mining Rate", DefaultSpread);

        //Survival

        public static SkillBonus GatherFood => new SkillBonus(Skill.Survival, "Gather Food", DefaultThree);
        public static SkillBonus GatherFirewood => new SkillBonus(Skill.Survival, "Gather Firewood", DefaultThree);
        public static SkillBonus GatherMedicine => new SkillBonus(Skill.Survival, "Gather Medicine", DefaultThree);
        public static SkillBonus GatherResinComponents => new SkillBonus(Skill.Survival, "Gather Resin Components", DefaultThree);
        public static SkillBonus SmallGameTracking => new SkillBonus(Skill.Survival, "Small Game Tracking", DefaultThree);
        public static SkillBonus MediumGameTracking => new SkillBonus(Skill.Survival, "Medium Game Tracking", DefaultThree);
        public static SkillBonus LargeGameTracking => new SkillBonus(Skill.Survival, "Large Game Tracking", DefaultThree);
        public static SkillBonus ExoticGameTracking => new SkillBonus(Skill.Survival, "Exotic Game Tracking", DefaultThree);
        public static SkillBonus ForestTracking => new SkillBonus(Skill.Survival, "Forest Tracking", DefaultThree);
        public static SkillBonus DesertTracking => new SkillBonus(Skill.Survival, "Desert Tracking", DefaultThree);
        public static SkillBonus SnowyTracking => new SkillBonus(Skill.Survival, "Snowy Tracking", DefaultThree);
        public static SkillBonus GrasslandTracking => new SkillBonus(Skill.Survival, "Grassland Tracking", DefaultThree);
        public static SkillBonus HighlandTracking => new SkillBonus(Skill.Survival, "Highland Tracking", DefaultThree);
        public static SkillBonus SnareTraps => new SkillBonus(Skill.Survival, "Snare Traps", DefaultThree);
        public static SkillBonus PitfallTraps => new SkillBonus(Skill.Survival, "Pitfall Traps", DefaultThree);
        public static SkillBonus CageTraps => new SkillBonus(Skill.Survival, "Cage Traps", DefaultThree);

        // Husbandry

        public static SkillBonus Training => new SkillBonus(Skill.Husbandry, "Training", DefaultThree);
        public static SkillBonus HerdSize => new SkillBonus(Skill.Husbandry, "Herd Size", LowStartSpread);
        public static SkillBonus Riding => new SkillBonus(Skill.Husbandry, "Riding", DefaultSpread);
        public static SkillBonus Breaking => new SkillBonus(Skill.Husbandry, "Breaking", DefaultSpread);
        public static SkillBonus ExoticTaming => new SkillBonus(Skill.Husbandry, "Exotic Animal Taming", DefaultSpread);
        public static SkillBonus Breeding => new SkillBonus(Skill.Husbandry, "Breeding", LowStartSpread);

        //Carpentry

        public static SkillBonus BaseQuality => new SkillBonus(Skill.Carpentry, "Base Quality", DefaultFour);
        public static SkillBonus BaseRate => new SkillBonus(Skill.Carpentry, "Base Rate", DefaultFour);
        public static SkillBonus FurnitureQuality => new SkillBonus(Skill.Carpentry, "Furniture Quality", CarpentryTwo);
        public static SkillBonus FurnitureRate => new SkillBonus(Skill.Carpentry, "Furniture Rate", CarpentryTwo);
        public static SkillBonus UpholsteryQuality => new SkillBonus(Skill.Carpentry, "Upholstery Quality", CarpentryTwo);
        public static SkillBonus UpholsteryRate => new SkillBonus(Skill.Carpentry, "Upholstery Rate", CarpentryTwo);
        public static SkillBonus CabinetryQuality => new SkillBonus(Skill.Carpentry, "Cabinetry Quality", CarpentryTwo);
        public static SkillBonus CabinetryRate => new SkillBonus(Skill.Carpentry, "Cabinetry Rate", CarpentryTwo);
        public static SkillBonus SurfacesQuality => new SkillBonus(Skill.Carpentry, "Surfaces Quality", CarpentryTwo);
        public static SkillBonus SurfacesRate => new SkillBonus(Skill.Carpentry, "Surfaces Rate", CarpentryTwo);
        public static SkillBonus StructuresQuality => new SkillBonus(Skill.Carpentry, "Structures Quality", CarpentryTwo);
        public static SkillBonus StructuresRate => new SkillBonus(Skill.Carpentry, "Structures Rate", CarpentryTwo);
        public static SkillBonus MasonryQuality => new SkillBonus(Skill.Carpentry, "Masonry Quality", CarpentryTwo);
        public static SkillBonus MasonryRate => new SkillBonus(Skill.Carpentry, "Masonry Rate", CarpentryTwo);
        public static SkillBonus HousingQuality => new SkillBonus(Skill.Carpentry, "Housing Quality", CarpentryTwo);
        public static SkillBonus HousingRate => new SkillBonus(Skill.Carpentry, "Housing Rate", CarpentryTwo);
        public static SkillBonus UtilityQuality => new SkillBonus(Skill.Carpentry, "Utility Quality", CarpentryTwo);
        public static SkillBonus UtilityRate => new SkillBonus(Skill.Carpentry, "Utility Rate", CarpentryTwo);
        public static SkillBonus ImprovisedQuality => new SkillBonus(Skill.Carpentry, "Improvised Quality", DefaultSpread);
        public static SkillBonus ImprovisedRate => new SkillBonus(Skill.Carpentry, "Improvised Rate", DefaultSpread);

        // Cooking

        public static SkillBonus RegionalQuality => new SkillBonus(Skill.Cooking, "Regional Cuisine Quality", DefaultSpread);
        public static SkillBonus RegionalRate => new SkillBonus(Skill.Cooking, "Regional Cuisine Rate", DefaultSpread);
        public static SkillBonus DishQuality => new SkillBonus(Skill.Cooking, "Dish Quality", DefaultSpread);
        public static SkillBonus DishRate => new SkillBonus(Skill.Cooking, "Dish Rate", DefaultSpread);

        // Liqourcraft

        public static SkillBonus Distilling => new SkillBonus(Skill.Liquorcraft, "Distilling", DefaultSpread);
        public static SkillBonus Brewing => new SkillBonus(Skill.Liquorcraft, "Brewing", DefaultSpread);
        public static SkillBonus Fermenting => new SkillBonus(Skill.Liquorcraft, "Fermenting", DefaultSpread);

        // Toolcraft

        public static SkillBonus ToolQuality => new SkillBonus(Skill.Toolcraft, "Tools Quality", DefaultSpread);
        public static SkillBonus ToolRate => new SkillBonus(Skill.Toolcraft, "Tools Rate", DefaultSpread);
        public static SkillBonus WeaponQuality => new SkillBonus(Skill.Toolcraft, "Weapons Quality", DefaultSpread);
        public static SkillBonus WeaponRate => new SkillBonus(Skill.Toolcraft, "Weapons Rate", DefaultSpread);
        public static SkillBonus MechanicalRate => new SkillBonus(Skill.Toolcraft, "Mechanical Rate", DefaultSpread);
        public static SkillBonus MechanicalComplexity => new SkillBonus(Skill.Toolcraft, "Max Mechanical Complexity", DefaultSpread);

        //Tailoring

        public static SkillBonus ArmorQuality => new SkillBonus(Skill.Tailoring, "Armorcraft Quality", HighFour);
        public static SkillBonus ArmorRate => new SkillBonus(Skill.Tailoring, "Armorcraft Rate", HighFour);
        public static SkillBonus ClothingQuality => new SkillBonus(Skill.Tailoring, "Clothing Quality", DefaultFour);
        public static SkillBonus ClothingRate => new SkillBonus(Skill.Tailoring, "Clothing Rate", DefaultFour);
        public static SkillBonus ThreadworkQuality => new SkillBonus(Skill.Tailoring, "Threadwork Quality", DefaultFour);
        public static SkillBonus ThreadworkRate => new SkillBonus(Skill.Tailoring, "Threadwork Rate", DefaultFour);

        // Medicine

        public static SkillBonus Diagnosis => new SkillBonus(Skill.Medicine, "Diagnosis", DefaultSpread);
        public static SkillBonus MedicineQuality => new SkillBonus(Skill.Medicine, "Crafting Quality", DefaultSpread);
        public static SkillBonus MedicineRate => new SkillBonus(Skill.Medicine, "Crafting Rate", DefaultSpread);

        // Butchery

        public static SkillBonus NSBoneYield => new SkillBonus(Skill.Butchery, "Non-Sapient Yield", DefaultFour);
        public static SkillBonus NSBoneRate => new SkillBonus(Skill.Butchery, "Non-Sapient Rate", DefaultFour);
        public static SkillBonus SapientYield => new SkillBonus(Skill.Butchery, "Sapient Yield", DefaultFour);
        public static SkillBonus SapientRate => new SkillBonus(Skill.Butchery, "Sapient Rate", DefaultFour);

        // Inscriptions

        public static SkillBonus InscriptionQuality => new SkillBonus(Skill.Inscriptions, "Inscription Quality", DefaultSpread);
        public static SkillBonus InscriptionRate => new SkillBonus(Skill.Inscriptions, "Inscribing Rate", DefaultSpread);
        public static SkillBonus RuneRetention => new SkillBonus(Skill.Inscriptions, "Rune Retention", DefaultSpread);

        // Resincraft

        public static SkillBonus ResinQuality => new SkillBonus(Skill.Resin, "Resincraft Quality", DefaultSpread);
        public static SkillBonus ResinRate => new SkillBonus(Skill.Resin, "Resincraft Rate", DefaultSpread);
        public static SkillBonus ComponentPreparation => new SkillBonus(Skill.Resin, "Component Preparation", DefaultSpread);

        // Light Arms

        public static SkillBonus Daggers => new SkillBonus(Skill.LightArms, "Daggers", DefaultFour);
        public static SkillBonus Sword => new SkillBonus(Skill.LightArms, "Swords", DefaultFour);
        public static SkillBonus HandAxes => new SkillBonus(Skill.LightArms, "Hand-Axes & Maces", DefaultFour);
        public static SkillBonus Polearms => new SkillBonus(Skill.LightArms, "Light Polearms", DefaultFour);

        // Heavy Arms

        public static SkillBonus Greatswords => new SkillBonus(Skill.HeavyArms, "Greatswords", DefaultFour);
        public static SkillBonus HeavyAxes => new SkillBonus(Skill.HeavyArms, "Heavy Axes", DefaultFour);
        public static SkillBonus Hammers => new SkillBonus(Skill.HeavyArms, "Heavy Hammers", DefaultFour);
        public static SkillBonus HeavyPolearms => new SkillBonus(Skill.HeavyArms, "Polearms", DefaultFour);

        // Thrown Weapons

        public static SkillBonus Blades => new SkillBonus(Skill.ThrownWeapons, "Blades", DefaultFour);
        public static SkillBonus Bones => new SkillBonus(Skill.ThrownWeapons, "Bones", DefaultFour);
        public static SkillBonus ThrownPolearms => new SkillBonus(Skill.ThrownWeapons, "Polearms", DefaultFour);
        public static SkillBonus ImprovisedThrown => new SkillBonus(Skill.ThrownWeapons, "Improvised", DefaultFour);

        // Ranged Weapons

        public static SkillBonus Shortbow => new SkillBonus(Skill.RangedWeapons, "Shortbow", DefaultFour);
        public static SkillBonus Longbow => new SkillBonus(Skill.RangedWeapons, "Longbow", DefaultFour);
        public static SkillBonus Crossbow => new SkillBonus(Skill.RangedWeapons, "Crossbow", DefaultFour);
        public static SkillBonus MountedArchery => new SkillBonus(Skill.RangedWeapons, "Mounted Archery", DefaultFour);

        // Armor

        public static SkillBonus ImprovedJoints => new SkillBonus(Skill.Armor, "Improved Joints", DefaultFour);
        public static SkillBonus ShieldTraining => new SkillBonus(Skill.Armor, "Shield Training", DefaultFour);
        public static SkillBonus HeavyLifting => new SkillBonus(Skill.Armor, "Heavy Lifting", new int[] { 1000, 1500 });

        // Stealth

        public static SkillBonus MoveSilently => new SkillBonus(Skill.Stealth, "Move Silently", StealthSpread);
        public static SkillBonus Disguise => new SkillBonus(Skill.Stealth, "Disguise", StealthSpread);

        // Sleight of Hand

        public static SkillBonus LockpickingRate => new SkillBonus(Skill.SleightOfHand, "Lockpicking Rate", LowFour);
        public static SkillBonus LockpickingAbility => new SkillBonus(Skill.SleightOfHand, "Lockpicking Ability", LowFour);
        public static SkillBonus Pickpocketing => new SkillBonus(Skill.SleightOfHand, "Pickpocketing", LowFour);
        public static SkillBonus Trickery => new SkillBonus(Skill.SleightOfHand, "Trickery", LowFour);

        // Performance

        public static SkillBonus Song => new SkillBonus(Skill.Performance, "Song", LowStartSpread);
        public static SkillBonus Dance => new SkillBonus(Skill.Performance, "Dance", LowStartSpread);
        public static SkillBonus PublicSpeaking => new SkillBonus(Skill.Performance, "Public Speaking", LowStartSpread);
        public static SkillBonus Intimidation => new SkillBonus(Skill.Performance, "Intimidation", LowStartSpread);
        public static SkillBonus Deception => new SkillBonus(Skill.Performance, "Deception", LowStartSpread);
    }
}