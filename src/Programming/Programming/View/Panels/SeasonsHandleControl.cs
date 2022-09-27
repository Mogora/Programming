using Programming.Model.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    ///  Реализация изменения цвета фона главного окна.
    /// </summary>
    public partial class SeasonsHandleControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonHandleControl"/>.
        /// </summary>
        public SeasonsHandleControl()
        {
            InitializeComponent();

            Array seasons = Enum.GetValues(typeof(Seasons));
            foreach (Seasons value in seasons)
            {
                SeasonsComboBox.Items.Add(value);
            }
            SeasonsComboBox.SelectedIndex = 0;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonsComboBox.SelectedItem)
            {
                case Seasons.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Холодно! Куда бежать согреваться??");
                    break;
                case Seasons.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Seasons.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show(" Ура! Солнце! Тепло!");
                    break;
                case Seasons.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
    }
}
