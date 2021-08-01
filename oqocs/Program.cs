using oqocs.items;
using System;

namespace oqocs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write(CharacterManager.GenerateCharacter());
            Console.ReadKey();
        }
    }
}