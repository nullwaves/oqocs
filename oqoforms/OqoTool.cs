using oqocs;
using oqocs.character;
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
    }
}