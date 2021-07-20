using System;
using System.Collections.Generic;
using System.Text;

namespace oqocs.items
{
    public class Metal : BasicItem
    {
        public Metal(string name, string description, decimal value, int durability)
        {
            Name = name + " Metal";
            Description = description;
            CostInPence = value;
            Durability = durability;
            Unit = Unit.Pounds;
            Quality = Grade.C;
        }

        // Basic Metals
        public static Metal Copper => new Metal("Copper", "", 144, 100);

        public static Metal Tin => new Metal("Tin", "", 720, 60);
        public static Metal Gold => new Metal("Gold", "", 5184, 20);
        public static Metal Silver => new Metal("Silver", "", 3456, 125);
        public static Metal Iron => new Metal("Iron", "", 6912, 300);
        public static Metal Lead => new Metal("Lead", "", 36, 20);
        public static Metal Zinc => new Metal("Zinc", "", 384, 15);
        public static Metal Nickel => new Metal("Nickel", "", 1440, 150);

        // Alloyed Metals
        public static Metal Brass => new Metal("Brass", "2:1 Copper/Zinc", 180, 60);

        public static Metal Bronze => new Metal("Bronze", "7:1 Copper/Tin", 216, 150);
        public static Metal Pewter => new Metal("Pewter", "9:1 Tin/Antimony", 648, 57);
        public static Metal Electrum => new Metal("Electrum", "1:1 Gold/Silver", 4320, 73);

        // All
        public static List<Metal> All = new List<Metal>()
        {
            Copper, Tin, Gold, Silver, Iron, Lead, Zinc, Nickel, Brass, Bronze, Pewter, Electrum,
        };
    }
}