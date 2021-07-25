using oqocs.items;
using System;
using System.Collections.Generic;

namespace oqocs
{
    public class ItemBuilder
    {
        private BasicRecipe Recipe;
        private readonly List<string> AllComponents;
        private static readonly Random random = new Random();

        public ItemBuilder(List<BasicRecipe> recipes)
        {
            AllComponents = new List<string>();
            if (PromptRecipeSelect(recipes))
            {
                var finalItem = BuildItem(Recipe);
                Console.WriteLine($"\n\nBuilt {finalItem.Name} Valued at {CurrencyFormatter.PrettyCopperFromPence(finalItem.QualityAdjustedValueInPence())} with DUR {finalItem.Durability}\n");
                foreach (var c in AllComponents)
                {
                    Console.WriteLine($"Used {c}");
                }
            }
        }

        public ItemBuilder(BasicRecipe recipe)
        {
            AllComponents = new List<string>();

            this.Recipe = recipe;
            var finalItem = BuildItem(Recipe);
            Console.WriteLine($"\n\nBuilt {finalItem.Name} Valued at {CurrencyFormatter.PrettyCopperFromPence(finalItem.QualityAdjustedValueInPence())}\n");
            foreach (var c in AllComponents)
            {
                Console.WriteLine($"Used {c}");
            }
        }

        private bool PromptRecipeSelect(List<BasicRecipe> recipes)
        {
            int i = 1;
            foreach (var r in recipes)
            {
                Console.WriteLine($"{i} - {r.Product}");
                i++;
            }
            Console.Write("Enter Recipe #, then press enter: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int recipeNum))
            {
                Recipe = recipeNum <= recipes.Count ? recipes[recipeNum - 1] : null;
            }
            return Recipe != null;
        }

        private BasicItem BuildItem(BasicRecipe recipe)
        {
            Console.WriteLine($"Beginning to Build {recipe.Product}");
            int sumDurability = 0;
            decimal sumValue = 0;
            foreach (RecipeComponent component in recipe.Components)
            {
                int localDurability = 0;
                decimal localValue = 0;
                switch (component.Type)
                {
                    case ComponentType.CraftableItem:
                        var localItem = BuildItem(component.CraftableItem);
                        localDurability = localItem.Durability;
                        localValue = localItem.CostInPence * component.Quantity * localItem.Quality.PriceMultiplier;
                        AllComponents.Add($"{component.Quantity}{localItem.Unit.Short} of {localItem.Name}");
                        break;

                    case ComponentType.Unique:
                        var localUnique = component.UniqueItem;
                        localDurability = localUnique.Durability;
                        localValue = localUnique.CostInPence * component.Quantity * localUnique.Quality.PriceMultiplier;
                        AllComponents.Add($"{component.Quantity}{localUnique.Unit.Short} of {localUnique.Name}");
                        break;

                    case ComponentType.Multi:
                        BasicItem localMulti = PromptMaterial(component.AcceptedInputs);
                        localDurability = localMulti.Durability;
                        localValue = localMulti.CostInPence * component.Quantity * localMulti.Quality.PriceMultiplier;
                        AllComponents.Add($"{component.Quantity}{localMulti.Unit.Short} of {localMulti.Name}");
                        break;

                    case ComponentType.MultiRecipe:
                        var localRecipe = PromptSubRecipe(component.AcceptedCrafted);
                        var localCrafted = BuildItem(localRecipe);
                        localDurability = localCrafted.Durability;
                        localValue = localCrafted.CostInPence * component.Quantity * localCrafted.Quality.PriceMultiplier;
                        AllComponents.Add($"{component.Quantity}{localCrafted.Unit.Short} of {localCrafted.Name}");
                        break;
                }
                if (localValue > 0 && localValue < 1) localValue = 1; // Round up component costs.
                sumDurability += localDurability;
                sumValue += localValue;
            }

            var item = new BasicItem()
            {
                Name = $"{recipe.Product}",
                Durability = (int)(sumDurability * recipe.DurabilityMultiplier),
                CostInPence = sumValue * recipe.PriceMultiplier,
                Quality = Grade.C,
                Unit = Unit.Each
            };

            return item;
        }

        private BasicRecipe PromptSubRecipe(List<BasicRecipe> acceptedCrafted)
        {
            int i = 1;
            foreach (var r in acceptedCrafted)
            {
                Console.WriteLine($"{i} - {r.Product}");
                i++;
            }
            Console.Write("Enter Recipe #, then press enter: ");
            string input = Console.ReadLine();

            BasicRecipe retItem;
            if (int.TryParse(input, out int matNum))
            {
                retItem = matNum <= acceptedCrafted.Count ? acceptedCrafted[matNum - 1] : acceptedCrafted[random.Next(acceptedCrafted.Count)];
                return retItem;
            }
            return PromptSubRecipe(acceptedCrafted);
        }

        private BasicItem PromptMaterial(List<BasicItem> acceptedInputs)
        {
            int i = 1;
            foreach (var r in acceptedInputs)
            {
                Console.WriteLine($"{i} - {r.Name} : {r.CostInPence}");
                i++;
            }
            Console.Write("Enter Material #, then press enter: ");
            string input = Console.ReadLine();

            BasicItem retItem;
            if (int.TryParse(input, out int matNum))
            {
                retItem = matNum <= acceptedInputs.Count ? acceptedInputs[matNum - 1] : acceptedInputs[random.Next(acceptedInputs.Count)];
                return retItem;
            }
            return PromptMaterial(acceptedInputs);
        }
    }
}