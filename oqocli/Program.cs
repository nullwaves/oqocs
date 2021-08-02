using oqocs.character;
using System;
using System.IO;

namespace oqocs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Directory.CreateDirectory("output");
                var fs = File.OpenWrite($"output\\{i}.txt");
                var write = new StreamWriter(fs);
                write.Write(CharacterManager.GenerateCharacter(Species.Human));
                write.Flush();
                write.Close();
            }
            Console.Write(CharacterManager.GenerateCharacter());
            ConsoleKeyInfo c = Console.ReadKey();
            while (c.Key != ConsoleKey.Escape)
            {
                Console.Write(CharacterManager.GenerateCharacter());
                Console.ReadKey();
            }
        }
    }
}