using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс товара
    /// </summary>
    public class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Уникальный ID
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Название товара
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Стоимость товара
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException("Стоимость должна быть от 0 до 100000");
                }
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр товара
        /// </summary>
        public Item(string name, string info, double cost)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}