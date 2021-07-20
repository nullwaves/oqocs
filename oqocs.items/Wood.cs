
namespace oqocs.items
{
    public class Wood : BasicItem
    {
        public Wood(string name, string description, decimal value, int durability)
        {
            Name = name + " Wood";
            Description = description;
            CostInPence = value;
            Durability = durability;
            Unit = Unit.Pounds;
            Quality = Grade.C;
        }

        public Wood Tolpet => new Wood("Tolpet", "light, lightgreen, heavyinterlocked", 1.5m, 28);
        public Wood Ilezmj => new Wood("Ilezmə", "light, white, lightwavy", 1m, 10);
        public Wood Ljxattlayj => new Wood("Ləxattlayə", "light, lightblue, mediumspiral", 0.75m, 10);
        public Wood Timcha => new Wood("Timcha", "light, lightsilver, heavyspiral", 6, 34);
        public Wood Umoi => new Wood("Umoi", "heavy, darkbrass, heavyknotted", 9, 40);
        public Wood Oyettlao => new Wood("Oyettlao", "heavier, darkorange, heavy spiral", 4, 28);
        public Wood Yotiyatkwal => new Wood("Yotiyatkwal", "medium, lightbrown, heavy wavy", 9, 28);
        public Wood Enyozozhi => new Wood("Enyozozhi", "light, grey, heavyinterlocked", 2, 28);
        public Wood Tsayemqoi => new Wood("Tsayemqoi", "heavy, darkgrey, light straight", 12, 22);
        public Wood Uqazo => new Wood("Uqazo", "light, lightred, heavyspiral", 6, 34);

    }
}
