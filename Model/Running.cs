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
        private int _intensity;

        /// <summary>
        /// Поле расстояние
        /// </summary>
        private double _distance;

        private conts

        /// <summary>
        /// Свойство поля интенсивность
        /// </summary>
        public int Intensity
        {
            get
            {
                return _intensity;
            }
            set
            {
                _intensity = value;
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
                _distance = value;
            }
        }

        /// <summary>
        /// Конструктор для инициализации нового экземляра класса Running
        /// с указанными параметрами
        /// </summary>
        /// <param name="intensity">интенсивность бега</param>
        /// <param name="distance">расстояние</param>
        public Running(int intensity, double distance)
        {
            Intensity = intensity;
            Distance = distance;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Running()
        { }

        public double CalculateCaloriesRunning()
        {

        }

        private void CalculateMet(int intensity)
        {
            if (intensity < 8)
            {
                return 8
            }
        }
    }
}
