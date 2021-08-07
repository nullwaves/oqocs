using System;
using System.Collections.Generic;
using System.Text;

namespace oqocs.character
{
    public static class NameGenerator
    {
        internal static Random Random => new Random();

        public static List<string> Consonants => new List<string>()
        {
            "p", "t", "k", "q",
            "ts", "tʃ",
            "s", "ʃ", "x", "h",
            "z", "ʒ",
            "m", "n", "ɲ",
            "ɬ",
            "w", "l", "j",
        };

        public static List<string> Vowels => new List<string>()
        {
            "i", "u",
            "ə", "o",
            "ɛ", "ɑ",
        };

        internal static string RandomConsonant() => Consonants[Random.Next(Consonants.Count)];

        internal static string RandomVowel() => Vowels[Random.Next(Vowels.Count)];

        public static string GenerateName()
        {
            StringBuilder retVal = new StringBuilder();
            retVal.Append(RandomConsonant());
            retVal.Append(RandomVowel());
            retVal.Append(RandomConsonant());
            if (Random.NextDouble() < 0.66)
            {
                retVal.Append(RandomConsonant());
            }
            retVal.Append(RandomVowel());
            retVal.Append(RandomConsonant());
            return retVal.ToString();
        }
    }
}