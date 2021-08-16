using oqocs.character;
using oqocs.lang;

namespace oqocs
{
    public class CharacterManager
    {
        public static Character GenerateCharacter()
        {
            Species species = Species.All[RandomService.Instance.Next(Species.All.Count)];
            var retVal = GenerateCharacter(species);
            return retVal;
        }

        public static Character GenerateCharacter(Species species)
        {
            KinshipGroup group = KinshipGroup.All[RandomService.Instance.Next(KinshipGroup.All.Count)];
            var retVal = GenerateCharacter(species, group);
            return retVal;
        }

        public static Character GenerateCharacter(Species species, KinshipGroup group)
        {
            Profession job = Profession.All[RandomService.Instance.Next(Profession.All.Count)];
            var retVal = GenerateCharacter(species, group, job);
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