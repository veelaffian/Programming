using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс покупателя
    /// </summary>
    public class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

        /// <summary>
        /// Уникальный ID
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Полное имя.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, "Fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, "Address");
                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр покупателя
        /// </summary>
        public Customer(string fullname, string address)
        {
            _id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }
    }
}