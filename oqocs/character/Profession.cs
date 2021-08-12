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
    }
}