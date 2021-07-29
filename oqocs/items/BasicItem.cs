namespace oqocs.items
{
    public class BasicItem : IItem
    {
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        private string description;
        public string Description
        {
            get => description;
            set => description = value;
        }

        private decimal costInPence;
        public decimal CostInPence
        {
            get => costInPence;
            set => costInPence = value;
        }

        private Grade grade;
        public Grade Quality
        {
            get => grade;
            set => grade = value;
        }

        private Unit unit;
        public Unit Unit
        {
            get => unit;
            set => unit = value;
        }

        private int durability;
        public int Durability
        {
            get => durability;
            set => durability = value;
        }

        public int QualityAdjustedValueInPence()
        {
            return (int)(Quality.PriceMultiplier * CostInPence);
        }
    }
}
