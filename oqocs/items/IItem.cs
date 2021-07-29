namespace oqocs.items
{
    interface IItem
    {
        string Name { get; }
        string Description { get; }
        decimal CostInPence { get; }
        Grade Quality { get; }
        Unit Unit { get; }
        int Durability { get; }
    }
}
