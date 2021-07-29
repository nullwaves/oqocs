namespace oqocs.character
{
    public class Skill
    {
        public string Name { get; }

        public SkillBonus[] Bonuses { get; }

        public Skill(string name, SkillBonus[] bonuses)
        {
            Name = name;
            Bonuses = bonuses;
        }
    }
}