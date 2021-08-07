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
                { 2, new SkillBonus[] { DefaultSkills.BaseRate, } },
                { 3, new SkillBonus[] { DefaultSkills.MiningQuality, } },
                { 4, new SkillBonus[] { DefaultSkills.FurnitureQuality, DefaultSkills.FurnitureRate, DefaultSkills.UpholsteryQuality, DefaultSkills.UpholsteryRate,
                                        DefaultSkills.CabinetryQuality, DefaultSkills.CabinetryRate, DefaultSkills.SurfacesQuality, DefaultSkills.SurfacesRate,
                                        DefaultSkills.MasonryQuality, DefaultSkills.MasonryRate, DefaultSkills.HousingQuality, DefaultSkills.HousingRate,
                                        DefaultSkills.ImprovisedQuality, DefaultSkills.ImprovisedRate, } },
            });
    }
}