namespace Model
{
    /// <summary>
    /// Базовый класс упражнения 
    /// </summary>
    public abstract class ExerciseBase
    {
        /// <summary>
        /// Поле время тренировки 
        /// </summary>
        private double _time;

        /// <summary>
        /// Поле вес человека
        /// </summary>
        private double _weightperson;

        /// <summary>
        /// Единицы измерения времени
        /// </summary>
        private TimeUnit _timeUnit;

        /// <summary>
        /// Свойство Вес человека
        /// </summary>
        public double WeightPerson
        {
            get
            {
                return _weightperson;
            }
            set
            {
                _weightperson = CheckNumberBase(value);
            }
        }

        /// <summary>
        /// Свойство Время
        /// </summary>
        public double Time
        {
            get

            {
                return _time;
            }
            set
            {
                _time = CheckNumberBase(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TimeUnit TimeUnit
        {
            get => _timeUnit;
            set => _timeUnit = value;
        }

        /// <summary>
        /// Конструктор, инициализирующий поля веса человека и времени тренировки
        /// </summary>
        /// <param name="weightperson">Вес человека</param>
        /// <param name="time">Время тренировки</param>
        public ExerciseBase(double weightperson, double time)
        {
            WeightPerson = weightperson;
            Time = time;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public ExerciseBase() : this(0, 0)
        { }


        /// <summary>
        /// Метод для проверки введенного числа 
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        protected static double CheckNumberBase(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Число должно быть положительным.");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Метод расчета каллорий 
        /// </summary>
        /// <returns>Каллории.</returns>
        public abstract double CalculateCalories { get; }
    }
}
