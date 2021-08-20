using oqocs;
using oqocs.character;
using oqocs.items;
using oqocs.items.recipes;
using oqocs.lang;
using System.Collections.Generic;
using System.Windows.Forms;

namespace oqoforms
{
    public partial class OqoTool : Form
    {
        public OqoTool()
        {
            InitializeComponent();
            ComboSpecies.DataSource = Species.All;
            ComboSpecies.DisplayMember = "Name";
            ComboKinship.DataSource = KinshipGroup.All;
            ComboKinship.DisplayMember = "Name";
            ComboJob.DataSource = Profession.All;
            ComboJob.DisplayMember = "Name";
            ComboItemRecipes.DataSource = RecipeCompendium.All;
            ComboItemRecipes.DisplayMember = "Product";
        }

        private void GenerateCharacter(object sender, System.EventArgs e)
        {
            Species species = (Species)ComboSpecies.SelectedItem;
            KinshipGroup group = (KinshipGroup)ComboKinship.SelectedItem;
            Profession job = (Profession)ComboJob.SelectedItem;

            TextCharacterOutput.Text = CharacterManager.GenerateCharacter(species, group, job).ToString();
        }

        private void GenerateRandomCharacter(object sender, System.EventArgs e)
        {
            TextCharacterOutput.Text = CharacterManager.GenerateCharacter().ToString();
        }

        private void GenerateCharacterBySpecies(object sender, System.EventArgs e)
        {
            TextCharacterOutput.Text = CharacterManager.GenerateCharacter((Species)ComboSpecies.SelectedItem).ToString();
        }

        private void GenerateCharacterBySpeciesAndGroup(object sender, System.EventArgs e)
        {
            TextCharacterOutput.Text = CharacterManager.GenerateCharacter((Species)ComboSpecies.SelectedItem, (KinshipGroup)ComboKinship.SelectedItem).ToString();
        }

        private void GenerateCharacterByJob(object sender, System.EventArgs e)
        {
            TextCharacterOutput.Text = CharacterManager.GenerateCharacter((Profession)ComboJob.SelectedItem).ToString();
        }

        private void GenerateWords(object sender, System.EventArgs e)
        {
            if (int.TryParse(TextNumSyllables.Text, out int syl) && int.TryParse(TextNumWords.Text, out int words))
            {
                List<string> ret = new List<string>(words);
                for (int i = 0; i < words; i++)
                {
                    ret.Add(WordBuilder.BuildWord(syl));
                }
                TextWordOutput.Clear();
                TextWordOutput.Lines = ret.ToArray();
            }
            else
            {
                MessageBox.Show("Both the Syllables field and Number of Words field must be integers.");
            }
        }

        private void BuildItem(object sender, System.EventArgs e)
        {
            var recipe = (BasicRecipe)ComboItemRecipes.SelectedItem;
            var finalItem = new ItemBuilder().BuildItem(recipe);
            TextItemOutput.Text = $"Built {finalItem.Name} Valued at {CurrencyFormatter.PrettyCopperFromPence(finalItem.QualityAdjustedValueInPence())} with DUR {finalItem.Durability}\r\n" +
                    $"{finalItem.Description}\r\n";
        }

        private void GenerateCharacterBySpeciesAndJob(object sender, System.EventArgs e)
        {
            TextCharacterOutput.Text = CharacterManager.GenerateCharacter((Species)ComboSpecies.SelectedItem, CharacterManager.RandomKinship(), (Profession)ComboJob.SelectedItem).ToString();
        }
    }
}