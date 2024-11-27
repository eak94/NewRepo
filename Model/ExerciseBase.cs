using System.ComponentModel;
using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Базовый класс упражнения 
    /// </summary>
    [XmlInclude(typeof(Running))]
    [XmlInclude(typeof(Swimming))]
    [XmlInclude(typeof(WeightLifting))]
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


        /// <summary>
        /// Свойство Вес человека
        /// </summary>
        [DisplayName("Вес человека, кг")]
        public double WeightPerson
        {
            get
            {
                return _weightPerson;
            }
            set
            {
                int maxWeightPerson = 300;
                _weightPerson = CheckNumberBase(value);

                if (value > maxWeightPerson)
                {
                    throw new ArgumentException("Вес не может быть " +
                        $"больше {maxWeightPerson} кг");
                }
            }
        }

        /// <summary>
        /// Свойство Время
        /// </summary>
        [DisplayName("Время тренировки, ч")]
        public double Time
        {
            get

            {
                return _time;
            }
            set
            {
                int maxTime = 24;
                _time = CheckNumberBase(value);

                if (value > maxTime)
                {
                    throw new ArgumentException("Время тренировки не может" +
                        $" быть больше {maxTime} ч");
                }
            }
        }

        /// <summary>
        /// Тип транспорта.
        /// </summary>
        [DisplayName("Тип упражнения")]
        public abstract string ExerciseType { get; } 

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
        [DisplayName("Количество сожженных каллорий, Ккал")]
        public abstract double CalculateCalories { get; }
    }
}
