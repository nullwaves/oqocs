using oqocs.character;
using System;

namespace oqocs
{
    public class CharacterManager
    {
        private static readonly Random random = new Random();

        public static Character GenerateCharacter()
        {
            Species species = Species.All[random.Next(Species.All.Count)];
            KinshipGroup group = KinshipGroup.All[random.Next(KinshipGroup.All.Count)];
            Character retVal = new Character(
                species,
                species.Adulthood,
                group,
                species.HP,
                species.STA,
                species.EV,
                species.INS,
                species.PER,
                species.SLP,
                species.HNG,
                species.THI);

            retVal.Skills.GiveXPH(2900);
            retVal.Skills.RandomInitBonuses();

            // Do steps 2-4
            return retVal;
        }
    }
}