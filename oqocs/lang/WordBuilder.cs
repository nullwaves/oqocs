using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oqocs.lang
{
    public static class WordBuilder
    {
        public class WordPart
        {
            public string Onset { get; set; }
            public string Vowel { get; set; }
            public string Coda { get; set; }

            public WordPart()
            {
                Onset = "";
                Vowel = "";
                Coda = "";
            }

            public override string ToString()
            {
                return Onset + Vowel + Coda;
            }
        }

        public static string BuildWord(int syllables)
        {
            List<WordPart> parts = new List<WordPart>();
            for (int i = 0; i < syllables; i++)
            {
                parts.Add(RandomWordPart());
                if (i > 0)
                {
                    string cl = parts[i - 1].Coda + parts[i].Onset;
                    while (cl.Length > 0 && !IsConsonant(cl) && !Data.AcceptableClusters.Contains(cl))
                    {
                        var coda = parts[i - 1].Coda;
                        List<string> options = Data.AcceptableClusters.Where(x => x.StartsWith(coda) && x != coda).ToList();
                        if (options.Count > 0)
                            parts[i].Onset = options[RandomService.Instance.Next(options.Count)].Substring(coda.Length);
                        else parts[i - 1].Coda = RandomConsonant();
                        cl = parts[i - 1].Coda + parts[i].Onset;
                    }
                }
            }

            StringBuilder retVal = new StringBuilder();
            int stressPosition = syllables - 2 >= 0 ? syllables - 2 : 0;
            retVal.Append("/");
            for (int j = 0; j < parts.Count; j++)
            {
                if (j > 0) retVal.Append(".");
                if (j == stressPosition)
                    retVal.Append("'");
                retVal.Append(parts[j].Onset);
                retVal.Append(parts[j].Vowel);
                retVal.Append(parts[j].Coda);
            }
            retVal.Append("/");
            return retVal.ToString();
        }

        public static WordPart RandomWordPart()
        {
            WordPart part = new WordPart();
            if (RandomService.Instance.NextDouble() > 0.5)
            {
                part.Onset = RandomConsonant();
            }
            part.Vowel = RandomVowel();
            if (RandomService.Instance.NextDouble() > 0.5)
            {
                part.Coda = RandomConsonant();
            }
            return part;
        }

        public static bool IsConsonant(string c) => Data.Consonants.Contains(c);

        public static string RandomConsonant() => Data.Consonants[RandomService.Instance.Next(Data.Consonants.Count)];

        public static string RandomVowel() => Data.Vowels[RandomService.Instance.Next(Data.Vowels.Count)];

        public static string RandomCluster() => Data.AcceptableClusters[RandomService.Instance.Next(Data.AcceptableClusters.Count)];
    }
}