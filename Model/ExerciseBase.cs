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
        private double _weightpepople;

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
