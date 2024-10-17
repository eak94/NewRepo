namespace LibraryPerson
{
    /// <summary>
    /// Дочерний класс Adult
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Поле серии паспорта 
        /// </summary>
        private int _passportSeries;

        /// <summary>
        /// Поле номера паспорта 
        /// </summary>
        private int _passportNumber;

        /// <summary>
        /// Поле партнет
        /// </summary>
        private Adult _partner;


        /// <summary>
        /// Свойство для серии паспорта
        /// </summary>
        public int PassportSeries
        {
            get
            {
                return _passportSeries;
            }
            set
            {
                if (!CheckPassport(value, 4))
                {
                    throw new ArgumentException
                        ("Серия паспорта должен содержать 6 цифр");
                }
                else
                {
                    _passportSeries = value;
                }
            }
        }

        /// <summary>
        /// Свойство для номера паспорта
        /// </summary>
        public int PassportNumber
        {
            get
            {
                return _passportNumber;
            }
            set
            {
                if (!CheckPassport(value, 6))
                {
                    throw new ArgumentException
                        ("Номер паспорта должен содержать 4 цифры");
                }
                else
                {
                    _passportNumber = value;
                }

            }
        }

        /// <summary>
        /// Метод для проверки данных паспорта 
        /// </summary>
        /// <param name="number">Номер/серия</param>
        /// <param name="length">Допустимый размер поля </param>
        /// <returns>Результат проверки</returns>
        private static bool CheckPassport(int number, int length)
        {
            return number.ToString().Length == length;
        }

        /// <summary>
        /// Свойства парнера 
        /// </summary>
        public Adult Parther
        {
            get
            {
                return _partner;
            }
            set
            {
                if (value?.Gender == Gender)
                {
                    throw new ArgumentException
                        ("Однополые браки запрещены");
                }
                _partner = value;

                if (value != null)
                {
                    value._partner = this;
                }
            }
        }

        /// <summary>
        /// Cвойство место работы
        /// </summary>
        public string Job { get; set; }

        /// <summary>
        /// Конструктор класса Adult
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Пол</param>
        /// <param name="passportSeries">Серия паспорта</param>
        /// <param name="passportNumber">Номер паспорта</param>
        /// <param name="parther">партнер</param>
        /// <param name="job">Место работы</param>
        public Adult(string name, string secondName, int age,
            Gender gender, int passportSeries, int passportNumber,
            Adult parther, string job)
            : base(name, secondName,
            age, gender)
        {
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            Parther = parther;
            Job = job;
        }

        /// <summary>
        /// Свойство поля минимального возраста взрослого
        /// </summary>
        public override int MinAge { get; } = 18;

        /// <summary>
        /// Экземляр класса по умолчанию
        /// </summary>
        public Adult() : this("Иван", "Иванов", 50, Gender.Male,
                               1111, 111111, null, null)
        { }

        /// <summary>
        /// Метод для получения информации о взрослом 
        /// </summary>
        /// <returns>Информация о взрослом человеке</returns>
        public override string GetInfo()
        {
            string info = $"{base.GetInfo()}" +
                $"Паспортные данные: серия {PassportSeries} номер {PassportNumber}";

            if (Job == null)
            {
                info += $"Место работы: безработный, ";
            }
            else
            {
                info += $"Место работы: {Job}, ";
            }

            if (Parther == null)
            {
                info += $"Партнер: отсутствует, ";
            }
            else
            {
                info += $"Партнер: {Parther}, ";
            }
            return info;
        }
    }
}
