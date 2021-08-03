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
            double mod = random.NextDouble();
            int height = species.MinHeightInInches + (int)(mod * (species.MaxHeightInInches - species.MinHeightInInches));
            int weight = species.MinWeightInPounds + (int)(mod * (species.MinWeightInPounds - species.MinWeightInPounds)) + random.Next(-10, 10);
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
                species.THI,
                species.HairColors[random.Next(species.HairColors.Length)],
                species.EyeColors[random.Next(species.EyeColors.Length)],
                $"{height / 12}ft {height % 12}in",
                $"{weight}lbs"
                );

            retVal.Skills.GiveXPH(2900);
            retVal.Skills.RandomInitBonuses();
            return retVal;
        }
    }
}