
namespace ClassLibrary1
{
    public class Person
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст пользователя
        /// </summary>
        private string _age;

        /// <summary>
        /// Конструктор класса имя
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Конструктор класса Фамилия
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        /// <summary>
        /// Конструктор класса Возраст
        /// </summary>
        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }
}