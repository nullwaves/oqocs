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
            var retVal = GenerateCharacter(species);
            return retVal;
        }

        public static Character GenerateCharacter(Species species)
        {
            KinshipGroup group = KinshipGroup.All[random.Next(KinshipGroup.All.Count)];
            var retVal = GenerateCharacter(species, group);
            return retVal;
        }

        public static Character GenerateCharacter(Species species, KinshipGroup group)
        {
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
            return retVal;
        }
    }
}