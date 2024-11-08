namespace Model
{
    /// <summary>
    /// Класс реализующий вид управжения: бег 
    /// </summary>
    public class Running : ExerciseBase
    {
        //- Бег медленным темпом(около 8 км/ч) — примерно 8 MET.
        //- Бег в умеренном темпе(около 10 км/ч) — примерно 10 MET.
        //- Бег быстрым темпом(более 12 км/ч) — около 12-15 MET.
        // Время можно рассчитать, зная расстояние и темп. Например, если вы пробежали
        // 5 км со скоростью 10 км/ч, то время бега составит 0.5 часа (5 км ÷ 10 км/ч)
        // Допустим, ваш вес 70 кг, вы пробежали 5 км со скоростью
        // 10 км/ч(это 0.5 часа), и MET для этой интенсивности составляет 10.

        // Калории = 10(интенсивность) *  70(вес) * 0,5 (время)= 350 

        /// <summary>
        /// Поле интенсивность в км/ч 
        /// </summary>
        private double _intensity;

        /// <summary>
        /// Поле расстояние
        /// </summary>
        private double _distance;

        /// <summary>
        /// MET= 8 в беге при медленном теме(около 8 км/ч) 
        /// </summary>
        private const int _metSlow = 8;

        /// <summary>
        /// MET=10 в беге при умеренном теме(около 10 км/ч) 
        /// </summary>
        private const int _metModerate = 10;

        /// <summary>
        /// MET=12 в беге при быстром теме(более 12 км/ч) 
        /// </summary>
        private const int _metFast = 12;

        /// <summary>
        /// Свойство поля интенсивность
        /// </summary>
        public double Intensity
        {
            get
            {
                return _intensity;
            }
            set
            {
                _intensity = CheckNumber(value);
            }
        }

        /// <summary>
        /// Свойство поля расстояние
        /// </summary>
        public double Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                _distance = CheckNumber(value);
            }
        }

        /// <summary>
        /// Конструктор для инициализации нового экземляра класса Running
        /// с указанными параметрами
        /// </summary>
        /// <param name="intensity">интенсивность бега</param>
        /// <param name="distance">расстояние</param>
        public Running(int intensity, double distance,
           : base(double weight, double time))
        {
            Intensity = intensity;
            Distance = distance;
            Weight = weight;
            Time = time;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Running()
        { }

        /// <summary>
        /// Метод для расчета каллорий при беге 
        /// </summary>
        /// <returns></returns>
        public override void CalculateCalories()
        { 
            double met = CalculateMet(Intensity);
            caloriesBurned = met * Weight * Time;
        }


        /// <summary>
        /// Метод для определения Met
        /// </summary>
        /// <param name="intensity">интенсивность</param>
        private int CalculateMet(int intensity)
        {
            if (intensity < _metSlow)
            {
                return _metSlow;
            }

            else if (intensity <= _metModerate)
            {
                return _metModerate;
            }
            else
            {
                return _metFast;
            }
        }
    }
}
