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
        public int PassportSeries;
        {
            get
            {
                return _passportSeries;
            }
            set
            {
                _passportSeries = value;
            }
        }

        /// <summary>
        /// Свойство для номера паспорта
        /// </summary>
        public int PassportNumber;
        {
            get
            {
                return _passportNumber;
            }
            set
            {
            _passportNumber = value;
            }
        }


        public Adult Parther;
        {
            get
            {
                return _partner;
            }
            set
            {
                _partner = value;
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
        /// Экземляр класса по умолчанию
        /// </summary>
        public Adult() : this("Иван", "Иванов", 18, Gender.Male,
                               1111, 111111, null, null)
        { }

        /// <summary>
        /// Переопределяемый метод для получения информации о взрослом 
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
                info += $"Партнер: {Parther}? ";
            }
            return info;
        }
    }
}
