using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualTask.Model
{
    public class Building
    {
        /// <summary>
        /// Название заведения.
        /// </summary>
        private string _title = "None";

        /// <summary>
        /// Адрес заведения.
        /// </summary>
        private string _addres = "None";

        /// <summary>
        /// Рейтинг заведения.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Категория заведения.
        /// </summary>
        private string _category;

        public Building (string title, string address, double rating, string category)
        {
            Title = title;
            Address = address;
            Rating = rating;
            Category = category;
        }

        /// <summary>
        /// Возвращает и задает название заведения
        /// </summary>
        public string Title 
        
    }
}
