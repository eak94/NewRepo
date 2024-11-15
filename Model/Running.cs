namespace Model
{
    /// <summary>
    /// Класс реализующий вид управжения: бег 
    /// </summary>
    public class Running : ExerciseBase
    {
        /// <summary>
        /// Поле интенсивность в км/ч 
        /// </summary>
        private double _intensity;

        /// <summary>
        /// Поле расстояние
        /// </summary>
        private double _distance;

        /// <summary>
        /// MET= 8 в беге при медленном теме (около 8 км/ч) 
        /// </summary>
        private const int _metSlow = 8;

        /// <summary>
        /// MET=10 в беге при умеренном теме (около 10 км/ч) 
        /// </summary>
        private const int _metModerate = 10;

        /// <summary>
        /// MET=12 в беге при быстром теме (более 12 км/ч) 
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
                _intensity = CheckNumberBase(value);
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
                _distance = CheckNumberBase(value);
            }
        }

        /// <summary>
        /// Метод для расчета каллорий при беге 
        /// </summary>
        public override double CalculateCalories
        {
            get
            {
                CalculateMet(Distance, Time);
                return Intensity * Time * WeightPerson;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="intensity"></param>
        /// <param name="distance"></param>
        public Running(int intensity, double distance, double weightperson, double time)
            : base(weightperson, time)
        {
            Intensity = intensity;
            Distance = distance;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Running()
        { }

        /// <summary>
        /// Метод для определения MET
        /// </summary>
        /// <param name="distance">дистанция</param>
        /// <param name="time">время</param>
        /// <returns></returns>
        private void CalculateMet(double distance, double time)
        {
            if ((distance / time) < _metSlow)
            {
                Intensity = _metSlow;
            }
            else if ((distance / time) <= _metModerate)
            {
                Intensity = _metModerate;
            }
            else
            {
                Intensity = _metFast;
            }
        }
    }
}
