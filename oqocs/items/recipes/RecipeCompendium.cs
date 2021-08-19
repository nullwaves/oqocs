using System.Collections.Generic;

namespace oqocs.items.recipes
{
    public static class RecipeCompendium
    {
        public static List<BasicRecipe> All => Helpers.CompileList(new List<BasicRecipe>[] { Toolcraft.All, Tailoring.All, Carpentry.Furniture });
    }
}