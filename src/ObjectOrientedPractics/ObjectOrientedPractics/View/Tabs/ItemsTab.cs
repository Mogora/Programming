﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            _items = new List<Item>();

            InitializeComponent();

            var category = Enum.GetValues(typeof(Category));

            foreach (var value in category)
            {
                CategoryComboBox.Items.Add(value);
            }
        }

        /// <summary>
        /// Возвращает и задаёт коллекцию товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// На значения товара задаются параметры.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private string ItemDescription(Item item)
        {
            return $"{item.Name}: - {item.Cost}";
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="selectedIndex">Индекс выбранного элемента.</param>
        private void UpdateItemInfo(Item item)
        {
            List<Item> items = Items;

            int index = _items.IndexOf(item);

            if (index == -1) return;

            ItemsListBox.Items[index] = ItemDescription(item);

        }

        /// <summary>
        /// Очищает информацию о зданиях из списка и текстовых полей.
        /// </summary>
        private void ClearItemInfo()
        {
            NameTextBox.Clear();
            IdTextBox.Clear();
            CostTextBox.Clear();
            DescriptionTextBox.Clear();
            NameTextBox.BackColor = AppColor.CorrectColor;
            CostTextBox.BackColor = AppColor.CorrectColor;
            ItemsListBox.Items.Clear();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int index = ItemsListBox.SelectedIndex;
                _currentItem = _items[index];
                IdTextBox.Text = _currentItem.Id.ToString();
                CostTextBox.Text = _currentItem.Cost.ToString();
                NameTextBox.Text = _currentItem.Name;
                DescriptionTextBox.Text = _currentItem.Info;
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                double cost = Convert.ToDouble(CostTextBox.Text);
                _currentItem.Cost = cost;
                UpdateItemInfo(_currentItem);
            }
            catch
            {
                CostTextBox.BackColor = AppColor.ErrorColor;
                return;
            }
            CostTextBox.BackColor = AppColor.CorrectColor;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                string name = NameTextBox.Text;
                _currentItem.Name = name;
                UpdateItemInfo(_currentItem);
            }
            catch
            {
                NameTextBox.BackColor = AppColor.ErrorColor;
                return;
            }
            NameTextBox.BackColor = AppColor.CorrectColor;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                string info = DescriptionTextBox.Text;
                _currentItem.Info = info;
                UpdateItemInfo(_currentItem);
            }
            catch
            {
                DescriptionTextBox.BackColor = AppColor.ErrorColor;
            }
            DescriptionTextBox.BackColor = AppColor.CorrectColor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();
            _items.Add(_currentItem);
            ItemsListBox.Items.Add(ItemDescription(_currentItem));
            ItemsListBox.SelectedIndex = _items.Count - 1;
            UpdateItemInfo(_currentItem);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _items.RemoveAt(index);
            ClearItemInfo();

            foreach (var item in _items)
            {
                ItemsListBox.Items.Add(ItemDescription(item));
                ItemsListBox.SelectedIndex = 0;
            }

            UpdateItemInfo(_currentItem);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexCategory = CategoryComboBox.SelectedIndex;
            int indexListBox = ItemsListBox.SelectedIndex;

            if ((indexCategory == -1) || (indexListBox == -1))
            {
                return;
            }

            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
        }
    }
}

  
