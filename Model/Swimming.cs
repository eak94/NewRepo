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
        /// Метод для расчета каллорий при плавании 
        /// </summary>
        public override double CalculateCalories
        {
            get
            {
                CalculateMet();
                return _metCoefficients[_style] * Time * WeightPerson;
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


        /// <summary>
        /// Метод для опрееделения Met
        /// </summary>
        /// <param name="style">стиль плавания</param>
        /// <returns></returns>
        private void CalculateMet()
        {
            switch (Style)
            {
                case SwimmingStyle.Brass:
                    break;
                case SwimmingStyle.CrawlModerate:
                    break;
                case SwimmingStyle.CrawlFast:
                    break;
                case SwimmingStyle.Backstroke:
                    break;
                case SwimmingStyle.Dolphin:
                    break;
                default:
                    break;
            }
        }
    }
}
