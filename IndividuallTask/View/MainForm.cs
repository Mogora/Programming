using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Building = IndividuallTask.Model.Building;
using IndividuallTask.Model;

namespace IndividuallTask.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция зданий.
        /// </summary>
        private List<Building> _buildings;

        /// <summary>
        /// Выбранное здание.
        /// </summary>
        private Building _currentBuilding;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _buildings = new List<Building>();
            Array typeValues = Enum.GetValues(typeof(Category));
            foreach (Category value in typeValues)
            {
                CategoryBuildingComboBox.Items.Add(value);
            }          
        }

        private void CategoryBuildingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //private void AddBuldingsButton_MouseEnter(object sender, EventArgs e)
        //{
        //    AddBuildingsButton.BackgroundImage = Properties.
        //}

        //private void AddBuldingsButton_MouseLeave(object sender, EventArgs e)
        //{
        //    AddBuildingsButton.BackgroundImage = Properties.
        //}

        //private void RemoveBuildingsButton_MouseEnter(object sender, EventArgs e)
        //{
        //    RemoveBuildingsButton.BackgroundImage = Resources.remove_building_grey;
        //}

        //private void RemoveBuildingsButton_MouseLeave(object sender, EventArgs e)
        //{
        //    RemoveBuildingsButton.BackgroundImage = Resources.rectangle_remove_24x24_uncolor;
        //}
    }
}
