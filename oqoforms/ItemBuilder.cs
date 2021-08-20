using oqocs.items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oqoforms
{
    public class ItemBuilder
    {
        public List<string> Stack { get; set; }

        public ItemBuilder()
        {
            Stack = new List<string>();
        }

        public BasicItem BuildItem(BasicRecipe recipe)
        {
            Stack.Add(recipe.Product);
            int sumDurability = 0;
            decimal sumValue = 0;
            List<string> sumDescription = new List<string>();
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
                        sumDescription.Add($"{component.Quantity}{localItem.Unit.Short} of {localItem.Name} - {localItem.Description}");
                        break;

                    case ComponentType.Unique:
                        var localUnique = component.UniqueItem;
                        localDurability = localUnique.Durability;
                        localValue = localUnique.CostInPence * component.Quantity * localUnique.Quality.PriceMultiplier;
                        sumDescription.Add($"{component.Quantity}{localUnique.Unit.Short} of {localUnique.Name}");
                        break;

                    case ComponentType.Multi:
                        BasicItem localMulti = PromptMaterial(component.AcceptedInputs);
                        localDurability = localMulti.Durability;
                        localValue = localMulti.CostInPence * component.Quantity * localMulti.Quality.PriceMultiplier;
                        sumDescription.Add($"{component.Quantity}{localMulti.Unit.Short} of {localMulti.Name}");
                        break;

                    case ComponentType.MultiRecipe:
                        var localRecipe = PromptSubRecipe(component.AcceptedCrafted);
                        var localCrafted = BuildItem(localRecipe);
                        localDurability = localCrafted.Durability;
                        localValue = localCrafted.CostInPence * component.Quantity * localCrafted.Quality.PriceMultiplier;
                        sumDescription.Add($"{component.Quantity}{localCrafted.Unit.Short} of {localCrafted.Name} - {localCrafted.Description}");
                        break;
                }
                if (localValue > 0 && localValue < 1) localValue = 1; // Round up component costs.
                sumDurability += localDurability;
                sumValue += localValue;
            }
            Stack.RemoveAt(Stack.Count - 1);

            string description = string.Join("\n", sumDescription).TrimEnd('\n');
            var item = new BasicItem()
            {
                Name = $"{recipe.Product}",
                Description = description,
                Durability = (int)(sumDurability * recipe.DurabilityMultiplier),
                CostInPence = sumValue * recipe.PriceMultiplier,
                Quality = Grade.C,
                Unit = Unit.Each
            };

            return item;
        }

        private BasicRecipe PromptSubRecipe(List<BasicRecipe> acceptedCrafted) => ComponentSelectBox.Show(Stack, acceptedCrafted);

        private BasicItem PromptMaterial(List<BasicItem> acceptedInputs) => ComponentSelectBox.Show(Stack, acceptedInputs);
    }
}