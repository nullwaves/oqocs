using System;
using System.Collections.Generic;
using System.IO;

namespace oqocs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] syl = new int[] { 282, 226, 45, 12 };
            ConsoleKeyInfo c = new ConsoleKeyInfo();

            Directory.CreateDirectory("output\\lang");
            /*
            var chr = CharacterManager.GenerateCharacter();
                var fs = File.OpenWrite($"output\\chars\\{s}.txt");
            var write = new StreamWriter(fs);
            write.Write(chr.ToString());
            write.Flush();
            write.Close();
            Console.WriteLine($"Wrote {chr.Name} to file.");
            Console.ReadKey();
            */
            List<string>[] words = new List<string>[] { new List<string>(), new List<string>(), new List<string>(), new List<string>(), };
            for (int s = 1; s <= 4; s++)
            {
                for (int i = 0; i < syl[s - 1]; i++)
                {
                    var word = lang.WordBuilder.BuildWord(s);
                    while (words[s - 1].Contains(word))
                    {
                        word = lang.WordBuilder.BuildWord(s);
                    }
                    words[s - 1].Add(word);
                }
            }
            for (int x = 0; x < words.Length; x++)
            {
                var fs = File.OpenWrite($"output\\lang\\{x + 1}.txt");
                var write = new StreamWriter(fs);
                foreach (string w in words[x])
                {
                    write.WriteLine(w);
                }
                write.Flush();
                write.Close();
                Console.WriteLine($"Wrote {words[x].Count} - {x + 1} syllable words to file.");
            }
            c = Console.ReadKey();
        }
    }
}