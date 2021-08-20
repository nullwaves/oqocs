using oqocs.items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oqoforms
{
    public partial class ComponentSelectBox : Form
    {
        public ComponentSelectBox()
        {
            InitializeComponent();
        }

        public static BasicItem Show(List<string> stack, List<BasicItem> components)
        {
            if (components.Count < 1) throw new ArgumentOutOfRangeException("components", "Cannot select from 0 items.");
            using (var form = new ComponentSelectBox())
            {
                string st = stack.First();
                for (int i = 1; i < stack.Count; i++)
                {
                    st += $" > {stack[i]}";
                }
                form.TextItemStack.Text = st;
                form.ComboComponent.DataSource = components;
                form.ComboComponent.DisplayMember = "Name";

                var dres = form.ShowDialog();
                return dres == DialogResult.OK ? (BasicItem)form.ComboComponent.SelectedItem : components.First();
            }
        }

        public static BasicRecipe Show(List<string> stack, List<BasicRecipe> components)
        {
            if (components.Count < 1) throw new ArgumentOutOfRangeException("components", "Cannot select from 0 items.");
            using (var form = new ComponentSelectBox())
            {
                string st = stack.First();
                for (int i = 1; i < stack.Count; i++)
                {
                    st += $" > {stack[i]}";
                }
                form.TextItemStack.Text = st;
                form.ComboComponent.DataSource = components;
                form.ComboComponent.DisplayMember = "Product";

                var dres = form.ShowDialog();
                return dres == DialogResult.OK ? (BasicRecipe)form.ComboComponent.SelectedItem : components.First();
            }
        }

        private void SelectComponent(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}