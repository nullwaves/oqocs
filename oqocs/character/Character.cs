using System.Text;

namespace oqocs.character
{
    public class Character
    {
        // General Details
        public string Name { get; set; }

        public Species Species { get; set; }
        public KinshipGroup KinshipGroup { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Hair { get; set; }
        public string Eyes { get; set; }
        public string Ethnicity { get; set; }
        public string SocialClass { get; set; }
        public string Job { get; set; }

        // Stats & Skills
        public SkillManager Skills { get; set; }

        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int MaxSTA { get; set; }
        public int CurrentSTA { get; set; }
        public int MaxEV { get; set; }
        public int CurrentEV { get; set; }
        public int MaxINS { get; set; }
        public int CurrentINS { get; set; }
        public int MaxPER { get; set; }
        public int CurrentPER { get; set; }
        public int MaxSLP { get; set; }
        public int CurrentSLP { get; set; }
        public int MaxHNG { get; set; }
        public int CurrentHNG { get; set; }
        public int MaxTHI { get; set; }
        public int CurrentTHI { get; set; }

        public Character(Species species, int age, KinshipGroup group, int hp, int sta, int ev, int _ins, int per, int slp, int hng, int thi, string hair, string eyes, string height, string weight)
        {
            Species = species;
            Age = age;
            KinshipGroup = group;
            MaxHP = CurrentHP = hp;
            MaxSTA = CurrentSTA = sta;
            MaxEV = CurrentEV = ev;
            MaxINS = CurrentINS = _ins;
            MaxPER = CurrentPER = per;
            MaxSLP = CurrentSLP = slp;
            MaxHNG = CurrentHNG = hng;
            MaxTHI = CurrentTHI = thi;

            Name = "";
            Height = height;
            Weight = weight;
            Hair = hair;
            Eyes = eyes;
            Ethnicity = "";
            SocialClass = "";
            Job = "";
            Skills = new SkillManager();
        }

        public override string ToString()
        {
            StringBuilder retVal = new StringBuilder();
            retVal.AppendLine($"Name: {Name} - Kinship: {KinshipGroup.Name} - Species: {Species.Name}");
            retVal.AppendLine($"Age: {Age} - Height: {Height} - Weight: {Weight}");
            retVal.AppendLine($"Hair: {Hair} - Eyes: {Eyes}");
            retVal.AppendLine($"Ethnicity: {Ethnicity} - Social Class: {SocialClass} - Job: {Job}");
            retVal.AppendLine();
            retVal.AppendLine($"HP {CurrentHP}/{MaxHP} - STA {CurrentSTA}/{MaxSTA} - EV {CurrentEV}/{MaxEV}");
            retVal.AppendLine($"INS {CurrentINS}/{MaxINS} - PER {CurrentPER}/{MaxPER}");
            retVal.AppendLine($"SLP {CurrentSLP}/{MaxSLP} - HNG {CurrentHNG}/{MaxHNG} - THI {CurrentTHI}/{MaxTHI}");
            retVal.AppendLine();
            retVal.AppendLine($"Unallocated XPH: {Skills.XPH}");
            foreach (Skill s in Skills.Skills)
            {
                foreach (SkillBonus b in s.Bonuses)
                    if (b.CurrentBonus > 0)
                    {
                        retVal.AppendLine($"{s.Name} - {b.Name} - {b.CurrentBonus}");
                    }
            };

            return retVal.ToString();
        }
    }
}