namespace oqocs.character
{
    public class SkillBonus
    {
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

        public SkillBonus(string name, int[] costs)
        {
            Name = name;
            BonusCosts = costs;
            CurrentBonus = 0;
        }
    }
}