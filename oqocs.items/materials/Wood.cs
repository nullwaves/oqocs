using System.Collections.Generic;

namespace oqocs.items.materials
{
    public class Wood : BasicItem
    {
        public Wood(string name, string description, decimal value, int durability)
        {
            Name = name;
            Description = description;
            CostInPence = value;
            Durability = durability;
            Unit = Unit.Pounds;
            Quality = Grade.C;
        }

        public static Wood Tolpet => new Wood("Tolpet", "light, lightgreen, heavyinterlocked", 1.5m, 28);
        public static Wood Ilezmj => new Wood("Ilezmə", "light, white, lightwavy", 1m, 10);
        public static Wood Ljxattlayj => new Wood("Ləxattlayə", "light, lightblue, mediumspiral", 0.75m, 10);
        public static Wood Timcha => new Wood("Timcha", "light, lightsilver, heavyspiral", 6, 34);
        public static Wood Umoi => new Wood("Umoi", "heavy, darkbrass, heavyknotted", 9, 40);
        public static Wood Oyettlao => new Wood("Oyettlao", "heavier, darkorange, heavy spiral", 4, 28);
        public static Wood Yotiyatkwal => new Wood("Yotiyatkwal", "medium, lightbrown, heavy wavy", 9, 28);
        public static Wood Enyozozhi => new Wood("Enyozozhi", "light, grey, heavyinterlocked", 2, 28);
        public static Wood Tsayemqoi => new Wood("Tsayemqoi", "heavy, darkgrey, light straight", 12, 22);
        public static Wood Uqazo => new Wood("Uqazo", "light, lightred, heavyspiral", 6, 34);

        public static List<Wood> All = new List<Wood>
        {
            Tolpet, Ilezmj, Ljxattlayj, Timcha, Umoi, Oyettlao, Yotiyatkwal, Enyozozhi, Tsayemqoi, Uqazo
        };
    }
}