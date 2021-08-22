using oqocs.character;
using System.Collections.Generic;

namespace oqocs
{
    public class SkillManager
    {
        public int XPH { get; private set; }
        public List<SkillBonus> Skills { get; private set; }

        public SkillManager()
        {
            Skills = SkillFactory.MakeSkillList(DefaultSkills.All);
            XPH = 0;
        }

        public void GiveXPH(int hours)
        {
            XPH += hours;
        }

        public int AllocateByProfession(Profession job)
        {
            int spent = 0;
            int jobDepth = 1;
            int spendable;
            while (XPH > 250)
            {
                spendable = XPH >= 750 ? ((XPH / 200) + 1) * 100 : XPH;
                if (job.PrioritySkills.ContainsKey(jobDepth))
                {
                    var bonus = job.PrioritySkills[jobDepth][RandomService.Instance.Next(job.PrioritySkills[jobDepth].Length)];
                    spent += TryBuyBonus(bonus, spendable);
                }
                else
                {
                    var bonus = DefaultSkills.All[RandomService.Instance.Next(DefaultSkills.All.Count)];
                    spent += TryBuyBonus(bonus, spendable);
                }
                jobDepth++;
            }
            return spent;
        }

        public int TryBuyBonus(SkillBonus bonus, int spendLimit)
        {
            int spent = 0;
            var l = Skills.Find(x => x.Name == bonus.Name);
            for (int i = 0; l.CanIncrease && i < l.MaxBonus; i++)
            {
                int cost = l.NextBonusCost;
                if (spendLimit >= cost && spendLimit <= XPH)
                {
                    if (TryBuyBonus(bonus))
                    {
                        spendLimit -= cost;
                        spent += cost;
                    }
                }
                else
                {
                    break;
                }
            }
            return spent;
        }

        public bool TryBuyBonus(SkillBonus bonus)
        {
            var l = Skills.Find(x => x.Name == bonus.Name);
            if (l.CanIncrease && XPH > l.NextBonusCost)
            {
                XPH -= l.NextBonusCost;
                l.CurrentBonus++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}