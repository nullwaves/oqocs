using System.Collections.Generic;

namespace oqocs.character
{
    public class Profession
    {
        public string Name { get; set; }
        public SkillBonus[] PrioritySkills { get; set; }

        public Profession(string name, SkillBonus[] skills)
        {
            Name = name;
            PrioritySkills = skills;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}