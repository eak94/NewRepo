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
        protected double _time;

        /// <summary>
        /// Поле вес человека
        /// </summary>
        protected double _weightpepople;

        /// <summary>
        /// Свойство Вес 
        /// </summary>
        public double Weight
        {
            get

            {
                return _weightpepople;
            }
            set
            {
                _weightpepople = CheckNumber(value);
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
                _time = CheckNumber(value);
            }
        }

        /// <summary>
        /// Конструктор для инициализации нового экземляра класса Running
        /// с указанными параметрами
        /// </summary>
        /// <param name="intensity">интенсивность бега</param>
        /// <param name="distance">расстояние</param>
        public ExerciseBase(double weight, double time)
        {
            Weight = weight;
            Time = time;
        }

        /// <summary>
        /// Метод для проверки введенного числа 
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        protected static double CheckNumber(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Число должно быть положительным.");
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
