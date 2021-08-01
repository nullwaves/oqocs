using oqocs.character;
using System;
using System.Collections.Generic;

namespace oqocs
{
    public class SkillManager
    {
        public int XPH { get; private set; }
        public List<Skill> Skills { get; private set; }

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

        public int RandomInitBonuses()
        {
            int spentXPH = 0;
            int combatXP = ((XPH / 200) + 1) * 100;
            if (combatXP < XPH)
            {
                Skill combatSkill = DefaultSkills.Weapons[random.Next(DefaultSkills.Weapons.Count)];
                spentXPH += AllocateRandomBonus(combatXP, combatSkill);
            }
            Skill remainderSkill = DefaultSkills.All[random.Next(DefaultSkills.All.Count)];
            spentXPH += AllocateRandomBonus(XPH, remainderSkill);
            return spentXPH;
        }

        private int AllocateRandomBonus(int spendable, Skill skill)
        {
            SkillBonus bonus = skill.Bonuses[random.Next(skill.Bonuses.Length)];
            int spent = 0;
            for (int i = 0; bonus.CanIncrease; i++)
            {

                int cost = bonus.NextBonusCost;
                if (spendable >= cost && spendable <= XPH)
                {
                    if (TryBuyBonus(skill, bonus))
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

        public bool TryBuyBonus(Skill skill, SkillBonus bonus)
        {
            Skill l = Skills.Find(x => x.Name == skill.Name);
            SkillBonus l2 = Array.Find(l.Bonuses, x => x.Name == bonus.Name);
            if (l2.CanIncrease && XPH > l2.NextBonusCost)
            {
                XPH -= l2.NextBonusCost;
                l2.CurrentBonus++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}