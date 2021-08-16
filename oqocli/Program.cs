using oqocs.character;
using System;
using System.IO;

namespace oqocs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ConsoleKeyInfo c = new ConsoleKeyInfo();
            while (c.Key != ConsoleKey.Escape)
            {
                var chr = CharacterManager.GenerateCharacter();
                Directory.CreateDirectory("output\\chars");
                var fs = File.OpenWrite($"output\\chars\\{chr.Name}.txt");
                var write = new StreamWriter(fs);
                write.Write(chr.ToString());
                write.Flush();
                write.Close();
                Console.WriteLine($"Wrote {chr.Name} to file.");
                Console.ReadKey();
            }
        }
    }
}