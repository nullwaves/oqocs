using oqocs.character;
using System;
using System.IO;

namespace oqocs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Directory.CreateDirectory("output");
            var fs = File.OpenWrite($"output\\names.txt");
            var write = new StreamWriter(fs);
            for (int i = 0; i < 1000; i++)
            {
                write.WriteLine(NameGenerator.GenerateName());
            }
            write.Flush();
            write.Close();
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