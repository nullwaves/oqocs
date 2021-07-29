namespace oqocs.character
{
    public class SkillBonus
    {
        public string Name { get; }

        public int CurrentBonus { get; }

        public int[] BonusCosts { get; }

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