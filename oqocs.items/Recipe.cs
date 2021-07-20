using System.Collections.Generic;

namespace oqocs.items
{
    public class BasicRecipe
    {
        public BasicItem Product { get; }
        public List<RecipeItem> Components { get; }
        public int DifficultyValue { get; }
        public string Knowledge { get; }
    }

    public class RecipeItem
    {
        public decimal Quantity { get; }
        public BasicItem Item { get; }

        public RecipeItem(decimal q, BasicItem i)
        {
            Quantity = q;
            Item = i;
        }
    }
}
