using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListOfBuildings.Model;
using Building = ListOfBuildings.Model.Building;
using System.Text.RegularExpressions;
using Category = ListOfBuildings.Model.Category;

namespace ListOfBuildings.View
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

        

        public MainForm()
        {
            InitializeComponent();

            _buildings = new List<Building>();
            Array typeValues = Enum.GetValues(typeof(Category));
            foreach (Category value in typeValues)
            {
                CategoryBuildingComboBox.Items.Add(value);
            }
            CategoryBuildingComboBox.SelectedIndex = 0;

            

            //UpdateListBox(-1);
        }

        /// <summary>
        /// Обновляет данные в списке.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateListBox(int index)
        {
            List<Building> buildings = _buildings;
            foreach (var building in buildings)
            {
                if (building.Title != null)
                {
                    BuildingListBox.Items.Add(building.Title);
                }
                else
                {
                    BuildingListBox.Items.Add($"Building {building.Id}");
                }
            }
            if (-1 <= index && index < BuildingListBox.Items.Count)
            {
                BuildingListBox.SelectedIndex = index;
            }
        }
        private void AddBuildingButton_MouseEnter(object sender, EventArgs e)
        {
            AddBuildingButton.BackgroundImage = Properties.Resources.add_building_color_green_;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddBuildingButton.BackgroundImage = Properties.Resources.add_building_grey;
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveBuildingButton.BackgroundImage = Properties.Resources.remove_building_color_red_;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveBuildingButton.BackgroundImage = Properties.Resources.remove_building_grey;
        }

        private void TitleBuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingListBox.SelectedIndex == -1) return;

            try
            {
                _currentBuilding.Title = TitleBuildingTextBox.Text;
                TitleBuildingTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                TitleBuildingTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void BuildingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BuildingListBox.SelectedIndex != -1)
            {
                int indexSelectedBuilding = BuildingListBox.SelectedIndex;
                _currentBuilding = _buildings[indexSelectedBuilding];
                TitleBuildingTextBox.Text = _currentBuilding.Title;
                AddressTextBox.Text = _currentBuilding.Address;
                RatingBuildingTextBox.Text = _currentBuilding.Rating.ToString();
                CategoryBuildingComboBox.Text = _currentBuilding.Category.ToString();
            }             
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingListBox.SelectedIndex != -1)
            {
                try
                {
                    string currentAddres = AddressTextBox.Text;
                    _currentBuilding.Address = currentAddres;
                }
                catch
                {
                    AddressTextBox.BackColor = AppColors.ErrorColor;
                    return;
                }
            }
            AddressTextBox.BackColor = AppColors.CorrectColor;
        }

        private void RatingBuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingListBox.SelectedIndex != -1)
            {
                try
                {
                    string currentRating = RatingBuildingTextBox.Text;
                    double ratingBuildingValue = double.Parse(currentRating);
                    _currentBuilding.Rating = ratingBuildingValue;
                }
                catch
                {
                    RatingBuildingTextBox.BackColor = AppColors.ErrorColor;
                    return;
                }
            }
            RatingBuildingTextBox.BackColor = AppColors.CorrectColor;
        }

        private void CategoryBuildingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BuildingListBox.SelectedItem == null) return;
            _currentBuilding.Category = (Category)CategoryBuildingComboBox.SelectedItem;
        }

        private void AddBuildingButton_Click(object sender, EventArgs e)
        {
            var building = new Building();
            _buildings.Add(building);
            UpdateListBox(_buildings.IndexOf(building));
            //_currentBuilding = new Building();

            //_buildings.Add(_currentBuilding);
            //BuildingListBox.Items.Add(_currentBuilding.BuildingDescription());

            //BuildingListBox.SelectedIndex = _buildings.Count - 1;

            //UpdateListBox(_buildings.IndexOf(_currentBuilding));
        }

        private void RemoveBuildingButton_Click(object sender, EventArgs e)
        {

        }
    } 
}
