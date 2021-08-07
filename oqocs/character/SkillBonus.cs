namespace oqocs.character
{
    public class SkillBonus
    {
        public Skill Skill { get; set; }

        public string Name { get; set; }

        public int CurrentBonus { get; set; }

        public int[] BonusCosts { get; set; }

        public int MaxBonus
        {
            get
            {
                return BonusCosts.Length;
            }
        }

        public bool CanIncrease
        {
            get
            {
                return CurrentBonus < MaxBonus;
            }
        }

        public int NextBonusCost
        {
            get
            {
                return BonusCosts[CurrentBonus];
            }
        }

        public SkillBonus(Skill skill, string name, int[] costs)
        {
            Skill = skill;
            Name = name;
            BonusCosts = costs;
            CurrentBonus = 0;
        }
    }
}