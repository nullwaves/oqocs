using System.Collections.Generic;

namespace oqocs.character
{
    public class Profession
    {
        public string Name { get; set; }
        public Dictionary<int, SkillBonus[]> PrioritySkills { get; set; }

        public Profession(string name, Dictionary<int, SkillBonus[]> skills)
        {
            Name = name;
            PrioritySkills = skills;
        }

        public override string ToString()
        {
            return Name;
        }

        public static Profession Laborer => new Profession(
            "Laborer",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.BaseQuality } },
                { 2, new SkillBonus[] { DefaultSkills.BaseRate, DefaultSkills.LoggingRate, DefaultSkills.MiningRate, } },
                { 3, new SkillBonus[] { DefaultSkills.MiningQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.FurnitureQuality, DefaultSkills.FurnitureRate, DefaultSkills.UpholsteryQuality, DefaultSkills.UpholsteryRate,
                                        DefaultSkills.CabinetryQuality, DefaultSkills.CabinetryRate, DefaultSkills.SurfacesQuality, DefaultSkills.SurfacesRate,
                                        DefaultSkills.MasonryQuality, DefaultSkills.MasonryRate, DefaultSkills.HousingQuality, DefaultSkills.HousingRate,
                                        DefaultSkills.ImprovisedQuality, DefaultSkills.ImprovisedRate, } },
            });

        public static Profession Fisherman => new Profession(
            "Fisherman",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.RodFishing, DefaultSkills.NetFishing, DefaultSkills.TrapFishing, } },
                { 2, new SkillBonus[] { DefaultSkills.GatherFood, DefaultSkills.GatherFirewood, } },
                { 3, new SkillBonus[] { DefaultSkills.SmallGameTracking, DefaultSkills.MediumGameTracking, } },
            });

        public static Profession Miner => new Profession(
            "Miner",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.MiningRate, DefaultSkills.MiningQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.HandAxes, } },
            });

        public static Profession Guard => new Profession(
            "Guard",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ImprovedJoints, DefaultSkills.ShieldTraining, DefaultSkills.HeavyLifting, } },
                { 2, new SkillBonus[] { DefaultSkills.Polearms, DefaultSkills.HeavyPolearms, } },
                { 3, new SkillBonus[] { DefaultSkills.Sword, DefaultSkills.HandAxes, DefaultSkills.HeavyAxes, DefaultSkills.Hammers, } },
                { 4, new SkillBonus[] { DefaultSkills.Shortbow, DefaultSkills.Longbow, DefaultSkills.Crossbow, } },
            });

        public static Profession Lumberjack => new Profession(
            "Lumberjack",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.LoggingRate, } },
                { 2, new SkillBonus[] { DefaultSkills.BaseRate, DefaultSkills.BaseQuality, DefaultSkills.HandAxes, DefaultSkills.HeavyAxes, } },
            });

        public static Profession Boatsman => new Profession(
            "Boatsman",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.RodFishing, DefaultSkills.NetFishing, } },
                { 2, new SkillBonus[] { DefaultSkills.TrapFishing, DefaultSkills.GatherFood, DefaultSkills.GatherFirewood, DefaultSkills.GatherMedicine, } },
                { 3, new SkillBonus[] { DefaultSkills.SmallGameTracking, DefaultSkills.MediumGameTracking, DefaultSkills.GrasslandTracking, DefaultSkills.HighlandTracking, } },
            });

        public static Profession Rancher => new Profession(
            "Rancher",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.HerdSize, } },
                { 2, new SkillBonus[] { DefaultSkills.Breeding, } },
                { 3, new SkillBonus[] { DefaultSkills.Training, } },
                { 4, new SkillBonus[] { DefaultSkills.GatherFood, DefaultSkills.MediumGameTracking, DefaultSkills.Riding, DefaultSkills.Breaking, DefaultSkills.Shortbow, DefaultSkills.Longbow, DefaultSkills.Crossbow,} },
                { 5, new SkillBonus[] { DefaultSkills.GatherFirewood, DefaultSkills.GatherMedicine, DefaultSkills.SmallGameTracking, DefaultSkills.LargeGameTracking, } },
            });

        public static Profession NomadicHerdsman => new Profession(
            "Nomadic Herdsman",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.HerdSize, } },
                { 2, new SkillBonus[] { DefaultSkills.Breeding, } },
                { 3, new SkillBonus[] { DefaultSkills.Riding, } },
                { 4, new SkillBonus[] { DefaultSkills.Shortbow, DefaultSkills.Longbow, DefaultSkills.Crossbow, } },
                { 5, new SkillBonus[] { DefaultSkills.Training, DefaultSkills.Breaking, } },
                { 6, new SkillBonus[] { DefaultSkills.GatherFood, DefaultSkills.GatherFirewood, DefaultSkills.GatherMedicine, } },
                { 7, new SkillBonus[] { DefaultSkills.SmallGameTracking, DefaultSkills.MediumGameTracking, DefaultSkills.LargeGameTracking, } },
            });

        public static Profession Mercenary => new Profession(
            "Mercenary",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Daggers, DefaultSkills.Sword, DefaultSkills.HandAxes, DefaultSkills.Polearms, DefaultSkills.Greatswords, DefaultSkills.HeavyAxes, DefaultSkills.Hammers, DefaultSkills.HeavyPolearms, } },
                { 2, new SkillBonus[] { DefaultSkills.ImprovedJoints, DefaultSkills.ShieldTraining, DefaultSkills.HeavyLifting, } },
                { 3, new SkillBonus[] { DefaultSkills.Shortbow, DefaultSkills.Longbow, DefaultSkills.Crossbow, DefaultSkills.MountedArchery, } },
            });

        public static Profession Weaver => new Profession(
            "Weaver",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ThreadworkQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.ThreadworkRate, } },
                { 3, new SkillBonus[] { DefaultSkills.ClothingQuality, DefaultSkills.ClothingRate, } },
            });

        public static Profession Butcher => new Profession(
            "Butcher",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.NSBoneYield, } },
                { 2, new SkillBonus[] { DefaultSkills.NSBoneRate, } },
            });

        public static Profession Butcherpriest => new Profession(
            "Butcherpriest",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.SapientYield, } },
                { 2, new SkillBonus[] { DefaultSkills.SapientRate, } },
                { 3, new SkillBonus[] { DefaultSkills.NSBoneRate, } },
                { 4, new SkillBonus[] { DefaultSkills.NSBoneYield, } },
                { 5, new SkillBonus[] { DefaultSkills.RuneRetention, } },
                { 6, new SkillBonus[] { DefaultSkills.InscriptionQuality, DefaultSkills.InscriptionRate, } },
            });

        public static Profession Priest => new Profession(
            "Priest",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 2, new SkillBonus[] { DefaultSkills.RuneRetention, } },
                { 3, new SkillBonus[] { DefaultSkills.MedicineQuality, DefaultSkills.MedicineRate, } },
                { 4, new SkillBonus[] { DefaultSkills.InscriptionQuality, DefaultSkills.InscriptionRate, } },
                { 5, new SkillBonus[] { DefaultSkills.ResinQuality, DefaultSkills.ResinRate, } },
                { 6, new SkillBonus[] { DefaultSkills.Trickery, } },
                { 7, new SkillBonus[] { DefaultSkills.SapientYield, DefaultSkills.SapientRate, DefaultSkills.ComponentPreparation, } },
                { 8, new SkillBonus[] { DefaultSkills.ThreadworkQuality, DefaultSkills.ThreadworkRate, } },
                { 9, new SkillBonus[] { DefaultSkills.Deception, } },
                { 10, new SkillBonus[] { DefaultSkills.Song, DefaultSkills.Dance, } },
            });

        public static Profession Taxman => new Profession(
            "Taxman",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Intimidation, } },
                { 2, new SkillBonus[] { DefaultSkills.Deception, } },
                { 3, new SkillBonus[] { DefaultSkills.Daggers, DefaultSkills.Sword, DefaultSkills.HandAxes, DefaultSkills.Polearms, } },
            });

        public static Profession DebtCollector => new Profession(
            "Debt Collector",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Intimidation, } },
                { 2, new SkillBonus[] { DefaultSkills.Daggers, DefaultSkills.Sword, DefaultSkills.HandAxes, DefaultSkills.Polearms, DefaultSkills.Greatswords, DefaultSkills.HeavyAxes, DefaultSkills.Hammers, DefaultSkills.HeavyPolearms, } },
                { 3, new SkillBonus[] { DefaultSkills.ImprovedJoints, DefaultSkills.ShieldTraining, DefaultSkills.HeavyLifting, } },
                { 4, new SkillBonus[] { DefaultSkills.MoveSilently, } },
                { 5, new SkillBonus[] { DefaultSkills.LockpickingRate, } },
                { 6, new SkillBonus[] { DefaultSkills.LockpickingAbility, } },
            });

        public static Profession Banker => new Profession(
            "Banker",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 2, new SkillBonus[] { DefaultSkills.ThreadworkQuality, DefaultSkills.ThreadworkRate, } },
                { 3, new SkillBonus[] { DefaultSkills.Intimidation, DefaultSkills.Deception, } },
                { 4, new SkillBonus[] { DefaultSkills.Pickpocketing, } },
            });

        public static Profession Miller => new Profession(
            "Miller",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.RegionalRate, DefaultSkills.DishQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.DishRate, DefaultSkills.Brewing, } },
            });

        public static Profession Brewer => new Profession(
            "Brewer",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Brewing, } },
            });

        public static Profession Distiller => new Profession(
            "Distiller",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Distilling, } },
            });

        public static Profession Winemaker => new Profession(
            "Winemaker",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Fermenting, } },
            });

        public static Profession Cabinetmaker => new Profession(
            "Cabinetmaker",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.BaseQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.BaseRate, } },
                { 3, new SkillBonus[] { DefaultSkills.CabinetryQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.CabinetryRate, } },
                { 5, new SkillBonus[] { DefaultSkills.SurfacesQuality, DefaultSkills.SurfacesRate, DefaultSkills.ImprovisedQuality, DefaultSkills.ImprovisedRate, } },
                { 6, new SkillBonus[] { DefaultSkills.FurnitureQuality, DefaultSkills.FurnitureRate, DefaultSkills.UpholsteryQuality, DefaultSkills.UpholsteryRate, } },
                { 7, new SkillBonus[] { DefaultSkills.HousingQuality, DefaultSkills.HousingRate, } },
                { 8, new SkillBonus[] { DefaultSkills.MasonryQuality, DefaultSkills.MasonryRate, } },
            });

        public static Profession Upholsterer => new Profession(
            "Upholsterer",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.BaseQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.BaseRate, } },
                { 3, new SkillBonus[] { DefaultSkills.UpholsteryQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.UpholsteryRate, } },
                { 5, new SkillBonus[] { DefaultSkills.FurnitureQuality, DefaultSkills.FurnitureRate, DefaultSkills.SurfacesQuality, DefaultSkills.SurfacesRate, } },
                { 6, new SkillBonus[] { DefaultSkills.ImprovisedQuality, DefaultSkills.ImprovisedRate, } },
                { 7, new SkillBonus[] { DefaultSkills.CabinetryQuality, DefaultSkills.CabinetryRate, } },
                { 8, new SkillBonus[] { DefaultSkills.MasonryQuality, DefaultSkills.MasonryRate, } },
            });

        public static Profession Mason => new Profession(
            "Mason",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.BaseQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.BaseRate, } },
                { 3, new SkillBonus[] { DefaultSkills.MasonryQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.MasonryRate, } },
                { 5, new SkillBonus[] { DefaultSkills.HousingQuality, } },
                { 6, new SkillBonus[] { DefaultSkills.HousingRate, } },
                { 7, new SkillBonus[] { DefaultSkills.ImprovisedQuality, DefaultSkills.ImprovisedRate, } },
            });

        public static Profession Handyman => new Profession(
            "Handyman",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.BaseQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.BaseRate, } },
                { 3, new SkillBonus[] { DefaultSkills.ImprovisedQuality, DefaultSkills.ImprovisedRate, } },
                { 4, new SkillBonus[] { DefaultSkills.FurnitureQuality, DefaultSkills.FurnitureRate, } },
                { 5, new SkillBonus[] { DefaultSkills.SurfacesQuality, DefaultSkills.SurfacesRate, } },
                { 6, new SkillBonus[] { DefaultSkills.MasonryQuality, DefaultSkills.MasonryRate, } },
                { 7, new SkillBonus[] { DefaultSkills.HousingQuality, DefaultSkills.HousingRate, } },
                { 8, new SkillBonus[] { DefaultSkills.UtilityQuality, DefaultSkills.UtilityRate, } },
                { 9, new SkillBonus[] { DefaultSkills.CabinetryQuality, DefaultSkills.CabinetryRate, } },
                { 10, new SkillBonus[] { DefaultSkills.UpholsteryQuality, DefaultSkills.UpholsteryRate, } },
            });

        public static Profession Carpenter => new Profession(
            "Carpenter",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.BaseQuality, DefaultSkills.FurnitureQuality, DefaultSkills.UpholsteryQuality, DefaultSkills.CabinetryQuality, DefaultSkills.SurfacesQuality, DefaultSkills.MasonryQuality, DefaultSkills.HousingQuality, DefaultSkills.UtilityQuality, DefaultSkills.ImprovisedQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.BaseRate, DefaultSkills.FurnitureRate, DefaultSkills.UpholsteryRate, DefaultSkills.CabinetryRate, DefaultSkills.SurfacesRate, DefaultSkills.MasonryRate, DefaultSkills.HousingRate, DefaultSkills.UtilityRate, DefaultSkills.ImprovisedRate, } },
            });

        public static Profession Chef => new Profession(
            "Chef",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.DishQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.DishRate, } },
                { 3, new SkillBonus[] { DefaultSkills.RegionalQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.RegionalRate, } },
            });

        public static Profession Smith => new Profession(
            "Smith",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ToolQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.ToolRate, } },
                { 3, new SkillBonus[] { DefaultSkills.WeaponQuality, DefaultSkills.WeaponRate, } },
                { 4, new SkillBonus[] { DefaultSkills.BaseQuality, DefaultSkills.BaseRate, DefaultSkills.ArmorQuality, DefaultSkills.ArmorRate, } },
            });

        public static Profession Weaponsmith => new Profession(
            "Weaponsmith",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.WeaponQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.WeaponRate, } },
                { 3, new SkillBonus[] { DefaultSkills.ToolQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.ToolRate, } },
                { 5, new SkillBonus[] { DefaultSkills.ArmorQuality, DefaultSkills.ArmorRate, } },
            });

        public static Profession Armorsmith => new Profession(
            "Armorsmith",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ArmorQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.ArmorRate, } },
                { 3, new SkillBonus[] { DefaultSkills.WeaponQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.WeaponRate, } },
                { 5, new SkillBonus[] { DefaultSkills.ToolQuality, DefaultSkills.ToolRate, } },
            });

        public static Profession Tailor => new Profession(
            "Tailor",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ClothingQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.ClothingRate, } },
                { 3, new SkillBonus[] { DefaultSkills.ThreadworkQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.ThreadworkRate, } },
                { 5, new SkillBonus[] { DefaultSkills.ArmorQuality, DefaultSkills.ArmorRate, } },
            });

        public static Profession Hatmaker => new Profession(
            "Hatmaker",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ClothingQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.ClothingRate, } },
                { 3, new SkillBonus[] { DefaultSkills.ThreadworkQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.ThreadworkRate, } },
                { 5, new SkillBonus[] { DefaultSkills.ArmorQuality, DefaultSkills.ArmorRate, } },
            });

        public static Profession Glovemaker => new Profession(
            "Glovemaker",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ClothingQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.ClothingRate, } },
                { 3, new SkillBonus[] { DefaultSkills.ThreadworkQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.ThreadworkRate, } },
                { 5, new SkillBonus[] { DefaultSkills.ArmorQuality, DefaultSkills.ArmorRate, } },
            });

        public static Profession Spinner => new Profession(
            "Spinner",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ThreadworkQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.ThreadworkRate, } },
            });

        public static Profession Medic => new Profession(
            "Medic",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.MedicineQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.GatherMedicine, } },
                { 3, new SkillBonus[] { DefaultSkills.MedicineRate, } },
            });

        public static Profession Bonecrafter => new Profession(
            "Bonecrafter",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.InscriptionQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.InscriptionRate, } },
                { 3, new SkillBonus[] { DefaultSkills.RuneRetention, DefaultSkills.ResinQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.ResinRate, } }
            });

        public static Profession Arborist => new Profession(
            "Arborist",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.GatherFirewood, } },
                { 2, new SkillBonus[] { DefaultSkills.GatherMedicine, } },
                { 3, new SkillBonus[] { DefaultSkills.GatherResinComponents, } },
                { 4, new SkillBonus[] { DefaultSkills.GatherFood, } },
                { 5, new SkillBonus[] { DefaultSkills.SnareTraps, DefaultSkills.PitfallTraps, DefaultSkills.CageTraps, } },
                { 6, new SkillBonus[] { DefaultSkills.ForestTracking, } },
            });

        public static Profession Farmer => new Profession(
            "Farmer",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.HerdSize, } },
                { 2, new SkillBonus[] { DefaultSkills.Riding, } },
                { 3, new SkillBonus[] { DefaultSkills.Breeding, } },
                { 4, new SkillBonus[] { DefaultSkills.GatherFirewood, } },
                { 5, new SkillBonus[] { DefaultSkills.GatherMedicine, } },
                { 6, new SkillBonus[] { DefaultSkills.GatherFood, } },
                { 7, new SkillBonus[] { DefaultSkills.MediumGameTracking, } },
                { 8, new SkillBonus[] { DefaultSkills.GrasslandTracking, } },
            });

        public static Profession Archer => new Profession(
            "Archer",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Shortbow, DefaultSkills.Longbow, DefaultSkills.Crossbow, } },
                { 2, new SkillBonus[] { DefaultSkills.MountedArchery, } },
                { 3, new SkillBonus[] { DefaultSkills.ImprovisedThrown, } },
                { 4, new SkillBonus[] { DefaultSkills.Blades, DefaultSkills.Bones, DefaultSkills.ThrownPolearms } },
            });

        public static Profession Tanner => new Profession(
            "Tanner",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ArmorQuality, DefaultSkills.ArmorRate, DefaultSkills.ClothingQuality, DefaultSkills.ClothingRate, } },
                { 2, new SkillBonus[] { DefaultSkills.NSBoneYield, DefaultSkills.NSBoneRate, } },
            });

        public static Profession Leatherworker => new Profession(
            "Leatherworker",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ArmorQuality, DefaultSkills.ArmorRate, DefaultSkills.ClothingQuality, DefaultSkills.ClothingRate, } },
                { 2, new SkillBonus[] { DefaultSkills.NSBoneYield, DefaultSkills.NSBoneRate, } },
            });

        public static Profession Furrier => new Profession(
            "Furrier",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ArmorQuality, DefaultSkills.ArmorRate, DefaultSkills.ClothingQuality, DefaultSkills.ClothingRate, } },
                { 2, new SkillBonus[] { DefaultSkills.NSBoneYield, DefaultSkills.NSBoneRate, } },
            });

        public static Profession Harnessmaker => new Profession(
            "Harnessmaker",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ArmorQuality, DefaultSkills.ArmorRate, DefaultSkills.ClothingQuality, DefaultSkills.ClothingRate, } },
                { 2, new SkillBonus[] { DefaultSkills.NSBoneYield, DefaultSkills.NSBoneRate, } },
            });

        public static Profession Saddler => new Profession(
            "Saddler",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ArmorQuality, DefaultSkills.ArmorRate, DefaultSkills.ClothingQuality, DefaultSkills.ClothingRate, } },
                { 2, new SkillBonus[] { DefaultSkills.NSBoneYield, DefaultSkills.NSBoneRate, } },
            });

        public static Profession Jeweler => new Profession(
            "Jeweler",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ClothingQuality, DefaultSkills.ClothingRate, } },
                { 2, new SkillBonus[] { DefaultSkills.ThreadworkQuality, DefaultSkills.ThreadworkRate, } },
            });

        public static Profession Musician => new Profession(
            "Musician",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Song, } },
                { 2, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 3, new SkillBonus[] { DefaultSkills.Deception, } },
                { 4, new SkillBonus[] { DefaultSkills.Trickery, } },
                { 5, new SkillBonus[] { DefaultSkills.Dance, } },
            });

        public static Profession Dancer => new Profession(
            "Dancer",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Dance, } },
                { 2, new SkillBonus[] { DefaultSkills.Trickery, } },
                { 3, new SkillBonus[] { DefaultSkills.Song, } },
                { 4, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 5, new SkillBonus[] { DefaultSkills.Deception, } },
            });

        public static Profession Actor => new Profession(
            "Actor",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 2, new SkillBonus[] { DefaultSkills.Deception, } },
                { 3, new SkillBonus[] { DefaultSkills.Intimidation, } },
                { 4, new SkillBonus[] { DefaultSkills.Trickery, } },
                { 5, new SkillBonus[] { DefaultSkills.Song, DefaultSkills.Dance, } },
            });

        public static Profession Writer => new Profession(
            "Writer",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 2, new SkillBonus[] { DefaultSkills.Deception, } },
                { 3, new SkillBonus[] { DefaultSkills.Trickery, } },
            });

        public static Profession Playwrite => new Profession(
            "Playwrite",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 2, new SkillBonus[] { DefaultSkills.Deception, } },
                { 3, new SkillBonus[] { DefaultSkills.Trickery, } },
            });

        public static Profession Shipwright => new Profession(
            "Shipwright",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.BaseQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.BaseRate, } },
                { 3, new SkillBonus[] { DefaultSkills.UtilityQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.UtilityRate, } },
                { 5, new SkillBonus[] { DefaultSkills.ImprovisedQuality, DefaultSkills.ImprovisedRate, } },
            });

        public static Profession Cartmaker => new Profession(
            "Cartmaker",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.BaseQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.BaseRate, } },
                { 3, new SkillBonus[] { DefaultSkills.UtilityQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.UtilityRate, } },
                { 5, new SkillBonus[] { DefaultSkills.ImprovisedQuality, DefaultSkills.ImprovisedRate, } },
            });

        public static Profession Assassin => new Profession(
            "Assassin",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.MoveSilently, } },
                { 2, new SkillBonus[] { DefaultSkills.Daggers, DefaultSkills.Sword, } },
                { 3, new SkillBonus[] { DefaultSkills.Deception, } },
                { 4, new SkillBonus[] { DefaultSkills.Disguise, DefaultSkills.LockpickingRate, DefaultSkills.LockpickingAbility, } },
                { 5, new SkillBonus[] { DefaultSkills.Shortbow, DefaultSkills.Longbow, DefaultSkills.Crossbow, DefaultSkills.Trickery, } },
            });

        public static Profession Trader => new Profession(
            "Trader",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 2, new SkillBonus[] { DefaultSkills.Deception, DefaultSkills.Riding, } },
                { 3, new SkillBonus[] { DefaultSkills.UtilityQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.UtilityRate, } },
                { 5, new SkillBonus[] { DefaultSkills.Daggers, DefaultSkills.Sword, DefaultSkills.HandAxes, DefaultSkills.Polearms, DefaultSkills.Greatswords, DefaultSkills.HeavyAxes, DefaultSkills.Hammers, DefaultSkills.HeavyPolearms, } },
                { 6, new SkillBonus[] { DefaultSkills.MountedArchery, } },
                { 7, new SkillBonus[] { DefaultSkills.Shortbow, DefaultSkills.Longbow, DefaultSkills.Crossbow, } },
                { 8, new SkillBonus[] { DefaultSkills.InscriptionQuality, } },
            });

        public static Profession Houselord => new Profession(
            "Houselord",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Deception, } },
                { 2, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 3, new SkillBonus[] { DefaultSkills.Intimidation, } },
                { 4, new SkillBonus[] { DefaultSkills.Daggers, DefaultSkills.Sword, DefaultSkills.HandAxes, DefaultSkills.Polearms, DefaultSkills.Greatswords, DefaultSkills.HeavyAxes, DefaultSkills.Hammers, DefaultSkills.HeavyPolearms, DefaultSkills.Shortbow, DefaultSkills.Longbow, DefaultSkills.Crossbow, } },
                { 5, new SkillBonus[] { DefaultSkills.Disguise, } },
            });

        public static Profession Monger => new Profession(
            "Monger",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 2, new SkillBonus[] { DefaultSkills.Deception, } },
                { 3, new SkillBonus[] { DefaultSkills.Intimidation, } },
                { 4, new SkillBonus[] { DefaultSkills.Disguise, } },
                { 5, new SkillBonus[] { DefaultSkills.Trickery, } },
                { 6, new SkillBonus[] { DefaultSkills.Pickpocketing, } },
                { 4, new SkillBonus[] { DefaultSkills.Daggers, DefaultSkills.Sword, DefaultSkills.HandAxes, DefaultSkills.Polearms, DefaultSkills.Greatswords, DefaultSkills.HeavyAxes, DefaultSkills.Hammers, DefaultSkills.HeavyPolearms, DefaultSkills.Shortbow, DefaultSkills.Longbow, DefaultSkills.Crossbow, } },
            });

        public static Profession Fletcher => new Profession(
            "Fletcher",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.WeaponQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.WeaponRate, } },
            });

        public static Profession Potter => new Profession(
            "Potter",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ToolQuality, } },
                { 2, new SkillBonus[] { DefaultSkills.ToolRate, } },
            });

        public static Profession Zoologist => new Profession(
            "Zoologist",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ExoticTaming, } },
                { 2, new SkillBonus[] { DefaultSkills.Breeding, } },
                { 3, new SkillBonus[] { DefaultSkills.Training, } },
            });

        public static Profession Swordsman => new Profession(
            "Swordsman",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.Sword, } },
                { 2, new SkillBonus[] { DefaultSkills.ShieldTraining, } },
                { 3, new SkillBonus[] { DefaultSkills.ImprovedJoints, DefaultSkills.HeavyLifting, } },
            });

        public static Profession Soldier => new Profession(
            "Soldier",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.HandAxes, } },
                { 2, new SkillBonus[] { DefaultSkills.ShieldTraining, } },
                { 3, new SkillBonus[] { DefaultSkills.ImprovedJoints, DefaultSkills.HeavyLifting, } },
            });

        public static Profession Spearman => new Profession(
             "Spearman",
             new Dictionary<int, SkillBonus[]>
             {
                { 1, new SkillBonus[] { DefaultSkills.Polearms, } },
                { 2, new SkillBonus[] { DefaultSkills.ShieldTraining, } },
                { 3, new SkillBonus[] { DefaultSkills.ImprovedJoints, DefaultSkills.HeavyLifting, } },
             });

        public static Profession TwoHander => new Profession(
             "Two Hander",
             new Dictionary<int, SkillBonus[]>
             {
                { 1, new SkillBonus[] { DefaultSkills.Greatswords, } },
                { 2, new SkillBonus[] { DefaultSkills.ImprovedJoints, } },
                { 3, new SkillBonus[] { DefaultSkills.HeavyLifting, } },
             });

        public static Profession Barbarian => new Profession(
             "Barbarian",
             new Dictionary<int, SkillBonus[]>
             {
                { 1, new SkillBonus[] { DefaultSkills.HeavyAxes, DefaultSkills.Hammers, } },
                { 2, new SkillBonus[] { DefaultSkills.ImprovedJoints, } },
                { 3, new SkillBonus[] { DefaultSkills.HeavyLifting, } },
             });

        public static Profession Pikeman => new Profession(
             "Pikeman",
             new Dictionary<int, SkillBonus[]>
             {
                { 1, new SkillBonus[] { DefaultSkills.HeavyPolearms, } },
                { 2, new SkillBonus[] { DefaultSkills.ImprovedJoints, } },
                { 3, new SkillBonus[] { DefaultSkills.HeavyLifting, } },
             });

        public static Profession Javelineer => new Profession(
             "Javelineer",
             new Dictionary<int, SkillBonus[]>
             {
                { 1, new SkillBonus[] { DefaultSkills.ImprovisedThrown, } },
                { 2, new SkillBonus[] { DefaultSkills.ImprovedJoints, } },
                { 3, new SkillBonus[] { DefaultSkills.HeavyLifting, } },
             });

        public static Profession WarCaster => new Profession(
             "War Caster",
             new Dictionary<int, SkillBonus[]>
             {
                { 1, new SkillBonus[] { DefaultSkills.Bones, } },
                { 2, new SkillBonus[] { DefaultSkills.ImprovedJoints, } },
                { 3, new SkillBonus[] { DefaultSkills.HeavyLifting, } },
                { 4, new SkillBonus[] { DefaultSkills.Daggers, DefaultSkills.Sword, } },
             });

        public static Profession Papermaker => new Profession(
            "Papermaker",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ToolQuality, DefaultSkills.ToolRate, } },
            });

        public static Profession Bookbinder => new Profession(
            "Bookbinder",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ToolQuality, DefaultSkills.ToolRate, } },
            });

        public static Profession Chandler => new Profession(
            "Chandler",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ToolQuality, DefaultSkills.ToolRate, } },
            });

        public static Profession Cooper => new Profession(
            "Cooper",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ToolQuality, DefaultSkills.ToolRate, } },
            });

        public static Profession Locksmith => new Profession(
            "Locksmith",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ToolQuality, DefaultSkills.ToolRate, } },
            });

        public static Profession Scabbardmaker => new Profession(
            "Scabbardmaker",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.ToolQuality, DefaultSkills.ToolRate, } },
            });

        public static Profession Bureaucrat => new Profession(
            "Bureaucrat",
            new Dictionary<int, SkillBonus[]>
            {
                { 1, new SkillBonus[] { DefaultSkills.PublicSpeaking, } },
                { 2, new SkillBonus[] { DefaultSkills.Deception, } },
                { 3, new SkillBonus[] { DefaultSkills.Intimidation, } },
            });
    }
}