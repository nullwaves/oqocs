using oqocs.character;
using System;
using System.Collections.Generic;

namespace oqocs
{
    public class SkillManager
    {
        public int XPH { get; private set; }
        public List<SkillBonus> Skills { get; private set; }

        private readonly Random random = new Random();

        public SkillManager()
        {
            Skills = DefaultSkills.All;
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
            int spendable = 0;
            while (XPH > 250)
            {
                spendable = XPH >= 750 ? ((XPH / 200) + 1) * 100 : XPH;
                if (job.PrioritySkills.ContainsKey(jobDepth))
                {
                    var bonus = job.PrioritySkills[jobDepth][random.Next(job.PrioritySkills[jobDepth].Length)];
                    spent += TryBuyBonus(bonus, spendable);
                }
                else
                {
                    var bonus = DefaultSkills.All[random.Next(DefaultSkills.All.Count)];
                    spent += TryBuyBonus(bonus, spendable);
                }
                jobDepth++;
            }
            return spent;
        }

        public int RandomInitBonuses()
        {
            int spentXPH = 0;
            int combatXP = ((XPH / 200) + 1) * 100;
            if (combatXP < XPH)
            {
                Skill combatSkill = Skill.Weapons[random.Next(Skill.Weapons.Count)];
                spentXPH += AllocateRandomBonus(combatXP, combatSkill);
            }
            Skill remainderSkill = Skill.All[random.Next(Skill.All.Count)];
            spentXPH += AllocateRandomBonus(XPH, remainderSkill);
            return spentXPH;
        }

        private int AllocateRandomBonus(int spendable, Skill skill)
        {
            var bonuses = BonusesForSkill(skill);
            SkillBonus bonus = bonuses[random.Next(bonuses.Count)];
            int spent = 0;
            for (int i = 0; bonus.CanIncrease; i++)
            {
                int cost = bonus.NextBonusCost;
                if (spendable >= cost && spendable <= XPH)
                {
                    if (TryBuyBonus(bonus))
                    {
                        spendable -= cost;
                        spent += cost;
                        bonus.CurrentBonus++;
                    }
                }
                else
                {
                    break;
                }
            }
            return spent;
        }

        public List<SkillBonus> BonusesForSkill(Skill skill)
        {
            return DefaultSkills.All.FindAll(x => x.Skill.Name == skill.Name);
        }

        public int TryBuyBonus(SkillBonus bonus, int spendLimit)
        {
            int spent = 0;
            for (int i = 0; bonus.CanIncrease; i++)
            {
                int cost = bonus.NextBonusCost;
                if (spendLimit >= cost && spendLimit <= XPH)
                {
                    if (TryBuyBonus(bonus))
                    {
                        spendLimit -= cost;
                        spent += cost;
                        bonus.CurrentBonus++;
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