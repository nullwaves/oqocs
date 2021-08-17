using oqocs.character;
using oqocs.lang;

namespace oqocs
{
    public class CharacterManager
    {
        public static Species RandomSpecies() => Species.All[RandomService.Instance.Next(Species.All.Count)];

        public static KinshipGroup RandomKinship() => KinshipGroup.All[RandomService.Instance.Next(KinshipGroup.All.Count)];

        public static Profession RandomJob() => Profession.All[RandomService.Instance.Next(Profession.All.Count)];

        public static Character GenerateCharacter()
        {
            var retVal = GenerateCharacter(RandomSpecies(), RandomKinship(), RandomJob());
            return retVal;
        }

        public static Character GenerateCharacter(Species species)
        {
            var retVal = GenerateCharacter(species, RandomKinship(), RandomJob());
            return retVal;
        }

        public static Character GenerateCharacter(Profession job)
        {
            return GenerateCharacter(RandomSpecies(), RandomKinship(), job);
        }

        public static Character GenerateCharacter(Species species, KinshipGroup group)
        {
            var retVal = GenerateCharacter(species, group, RandomJob());
            return retVal;
        }

        public static Character GenerateCharacter(Species species, KinshipGroup group, Profession job)
        {
            string name = WordBuilder.BuildWord(RandomService.Instance.Next(2, 4));
            double mod = RandomService.Instance.NextDouble();
            int height = species.MinHeightInInches + (int)(mod * (species.MaxHeightInInches - species.MinHeightInInches));
            int weight = species.MinWeightInPounds + (int)(mod * (species.MaxWeightInPounds - species.MinWeightInPounds)) + RandomService.Instance.Next(-10, 10);
            Character retVal = new Character(
                name,
                species,
                species.Adulthood,
                group,
                job,
                species.HP,
                species.STA,
                species.EV,
                species.INS,
                species.PER,
                species.SLP,
                species.HNG,
                species.THI,
                species.HairColors[RandomService.Instance.Next(species.HairColors.Length)],
                species.EyeColors[RandomService.Instance.Next(species.EyeColors.Length)],
                $"{height / 12}ft {height % 12}in",
                $"{weight}lbs"
                );

            retVal.Skills.GiveXPH(2900);
            retVal.Skills.AllocateByProfession(retVal.Job);
            return retVal;
        }
    }
}