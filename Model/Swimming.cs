using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Класс реализующий вид управжения: плавание 
    /// </summary>
    public class Swimming : ExerciseBase
    {
        //TODO: refactor to enumeration and dictionary with coefficients+
        /// <summary>
        /// Поле стиль плавания
        /// </summary>
        private SwimmingStyle _style;

        /// <summary>
        /// Поле дистанция 
        /// </summary>
        private double _distance;

        /// <summary>
        /// Словарь коэффициентов для стилей плавания
        /// </summary>
        private Dictionary<SwimmingStyle, int>
            _metCoefficients = new Dictionary<SwimmingStyle, int>
        {
            { SwimmingStyle.Brass, 5 },
            { SwimmingStyle.CrawlModerate, 6 },
            { SwimmingStyle.CrawlFast, 8 },
            { SwimmingStyle.Backstroke, 4 },
            { SwimmingStyle.Dolphin, 10 }
        };

        /// <summary>
        /// Свойство поля стиля плавания
        /// </summary>
        [XmlElement]
        public SwimmingStyle Style
        {
            get
            {
                return _style;
            }
            set
            {
                if (Enum.IsDefined(typeof(SwimmingStyle), value))
                {
                    _style = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимый ввод стиля плавания");
                }
            }
        }

        /// <summary>
        /// Свойство поля дистанция
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
                return "Плавание";
            }
        }

        /// <summary>
        /// Метод для расчета каллорий при плавании 
        /// </summary>
        [XmlElement]
        public override double CalculateCalories
        {
            get
            {
                double calories = _metCoefficients[_style] * Time * WeightPerson;
                return Math.Round(calories, 2);
            }
        }

        /// <summary>
        /// Конструктор для инициализации нового экземляра класса Swimming
        /// с указанными параметрами
        /// </summary>
        /// <param name="style">стиль плавания</param>
        /// <param name="distance">дистанция</param>
        public Swimming(SwimmingStyle style, double distance, double weightperson, double time)
            : base(weightperson, time)
        {
            Style = style;
            Distance = distance;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Swimming()
        { }
    }
}
