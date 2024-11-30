using System.Xml.Serialization;

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
        /// Свойство поля интенсивность
        /// </summary>
        [XmlElement]
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
        [XmlElement]
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
        /// Реализация свойства типа упраженения
        /// </summary>
        [XmlElement]
        public override string ExerciseType
        {
            get
            {
                return "Бег";
            }
        }

        /// <summary>
        /// Метод для расчета каллорий при беге 
        /// </summary>
        [XmlElement]
        public override double CalculateCalories
        {
            get
            {
                CalculateMet(Distance, Time);
                double calories = Intensity * Time * WeightPerson;
                return Math.Round(calories, 2);
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
        public void CalculateMet(double distance, double time)
        {
            int metSlow = 8;
            int metModerate = 10;
            int metFast = 12;

            if ((distance / time) < metSlow)
            {
                Intensity = metSlow;
            }
            else if ((distance / time) <= metModerate)
            {
                Intensity = metModerate;
            }
            else
            {
                Intensity = metFast;
            }
        }
    }
}
