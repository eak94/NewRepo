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
        private double _weightPerson;

        //TODO: refactor
        /// <summary>
        /// Константа хранит максимальный вес человека
        /// </summary>
        private const int _maxWeightPerson = 300;

        //TODO: refactor
        //TODO: XML
        /// <summary>
        /// Константа хранит максимальный вес человека
        /// </summary>
        private const double _maxTime = 24;

        /// <summary>
        /// Свойство Вес человека
        /// </summary>
        public double WeightPerson
        {
            get
            {
                return _weightPerson;
            }
            set
            {
                _weightPerson = CheckNumberBase(value);

                if (value > _maxWeightPerson)
                {
                    throw new ArgumentException("Вес не может быть " +
                        $"больше {_maxWeightPerson} кг");
                }
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

                if (value > _maxTime)
                {
                    throw new ArgumentException("Время тренировки не может" +
                        $" быть больше {_maxTime} ч");
                }
            }
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
        public ExerciseBase() : this(1, 1)
        { }


        /// <summary>
        /// Метод для проверки введенного числа 
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        protected static double CheckNumberBase(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Введенное число должно быть положительным " +
                    "или не равным нулю");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Метод расчета каллорий 
        /// </summary>
        public abstract double CalculateCalories { get; }
    }
}
