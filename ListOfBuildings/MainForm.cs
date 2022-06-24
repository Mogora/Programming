using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfBuildings.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
