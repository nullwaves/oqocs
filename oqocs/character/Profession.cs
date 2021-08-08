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
    }
}