using System.Collections.Generic;

namespace oqocs.character
{
    public static class SkillFactory
    {
        public static List<SkillBonus> MakeSkillList(List<SkillBonus> list)
        {
            var newList = new List<SkillBonus>(list.Count);
            foreach (var item in list)
            {
                newList.Add(new SkillBonus(item.Skill, item.Name, item.BonusCosts));
            }
            return newList;
        }
    }
}