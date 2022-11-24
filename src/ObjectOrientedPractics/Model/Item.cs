using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Все товары.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>
        /// </summary>
        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
            Name = "Title";
            Info = "Info";
            Cost = 1000;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара. Должно быть не более 200 символов.</param>
        /// <param name="info">Описание товара. Должно быть не более 1000 символов.</param>
        /// <param name="cost">Стоимость товара. Должна быть в пределах от 0 до 100000.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название товара. 
        /// Должно быть не более 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт описание товара. 
        /// Должно быть не более 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара. 
        /// Должно быть в пределах от 0 до 100000.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertValueInRange(nameof(Cost), value, 0, 100000);
                _cost = value;
            }
        }
    }
}
