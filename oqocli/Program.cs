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
                write.Write(CharacterManager.GenerateCharacter());
                write.Flush();
                write.Close();
            }
            Console.Write(CharacterManager.GenerateCharacter());
            Console.ReadKey();
        }
    }
}