using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Category = IndividualTask.Model.Enums.Category;


namespace IndividualTask
{
    public partial class MainForm : Form
    {
        private Category _category;

        
        public MainForm()
        {
            InitializeComponent();

            Array _categories = Enum.GetValues(typeof(Category));

            foreach (var item in _categories)
            {
                CategoryComboBox.Items.Add(item);
            }

        }

        private void BuildingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddBuildingButton_Click(object sender, EventArgs e)
        {

        }
    }
}
