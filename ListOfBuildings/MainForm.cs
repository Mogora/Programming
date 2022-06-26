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

        /// <summary>
        /// Очищает информациюю о зданиях из списка и текстовых полей.
        /// </summary>
        private void ClearBuildingInfo()
        {
            TitleBuildingTextBox.Clear();
            AddressTextBox.Clear();
            TitleBuildingTextBox.BackColor = AppColors.CorrectColor;
            AddressTextBox.BackColor = AppColors.CorrectColor;
            RatingBuildingTextBox.BackColor = AppColors.CorrectColor;
            BuildingListBox.Items.Clear();
        }
        
        /// <summary>
        /// На значения здания задаются параметры.
        /// </summary>
        /// <param name="building"> Здание. </param>
        /// <returns> Возвращает форматированный текст. </returns>
        private string BuildingDescription(Building building)
        {
            return $"{building.Id}:" + 
                   $"({building.Category} - {building.Title})";
        }


        private void UpdateBuildingInfo(Building building)
        {
            int index = _buildings.IndexOf(building);

            if (index == -1) return;

            BuildingListBox.Items[index] = BuildingDescription(building);
        }


        private void TitleBuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingListBox.SelectedIndex == -1) return;

            try
            {
                _currentBuilding.Title = TitleBuildingTextBox.Text;
                TitleBuildingTextBox.BackColor = AppColors.CorrectColor;
                UpdateBuildingInfo(_currentBuilding);
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
                    UpdateBuildingInfo(_currentBuilding);
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
                    UpdateBuildingInfo(_currentBuilding);
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
            UpdateBuildingInfo(_currentBuilding);
        }

        private void AddBuildingButton_Click(object sender, EventArgs e)
        {
            _currentBuilding = new Building();
            _buildings.Add(_currentBuilding);
            BuildingListBox.Items.Add(BuildingDescription(_currentBuilding));
            BuildingListBox.SelectedIndex = _buildings.Count - 1;
        }

        private void RemoveBuildingButton_Click(object sender, EventArgs e)
        {
            int indexSelectedBuilding = BuildingListBox.SelectedIndex;

            if (indexSelectedBuilding == -1) return;

            _buildings.RemoveAt(indexSelectedBuilding);

            ClearBuildingInfo();


            foreach (var building in _buildings)
            {
                BuildingListBox.Items.Add(BuildingDescription(building));
                BuildingListBox.SelectedIndex = 0;
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
    } 
}
