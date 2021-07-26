using oqocs.items.recipes.tools;
using System.Collections.Generic;

namespace oqocs.items.recipes
{
    public static class Toolcraft
    {
        public static List<BasicRecipe> All = Helpers.CompileList(new List<BasicRecipe>[]
        {
            Butchery,
            Carpentry,
            Cooking,
            Fishing,
            Husbandry,
            Liqourcraft,
            Logging,
            Medicinecraft,
            Mining,
            Survival,
            Tailoring,
            Weapons,
            //Shields,
            //Other,
        });

        public static List<BasicRecipe> Butchery => ButcheryTools.All;
        public static List<BasicRecipe> Carpentry => CarpentryTools.All;
        public static List<BasicRecipe> Cooking => CookingTools.All;
        public static List<BasicRecipe> Fishing => FishingTools.All;
        public static List<BasicRecipe> Husbandry => HusbandryTools.All;
        public static List<BasicRecipe> Liqourcraft => LiqourcraftTools.All;
        public static List<BasicRecipe> Logging => LoggingTools.All;
        public static List<BasicRecipe> Medicinecraft => MedicinecraftTools.All;
        public static List<BasicRecipe> Mining => MiningTools.All;
        public static List<BasicRecipe> Survival => SurvivalTools.All;
        public static List<BasicRecipe> Tailoring => TailoringTools.All;
        public static List<BasicRecipe> Weapons => tools.Weapons.All;
    }
}