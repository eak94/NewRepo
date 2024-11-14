namespace Model
{
    /// <summary>
    /// Класс реализующий вид управжения: плавание 
    /// </summary>
    public class Swimming : ExerciseBase
    {
        /// <summary>
        /// Поле стиль плавания
        /// </summary>
        private int _style;

        /// <summary>
        /// Поле дистанция 
        /// </summary>
        private double _distance;

        /// <summary>
        /// Met для Брасс
        /// </summary>
        private const int _brassMet = 5;

        /// <summary>
        /// Met для Кроль-умеренный
        /// </summary>
        private const int _crawlModerateMet = 6;

        /// <summary>
        /// Met для Кроль-быстрый
        /// </summary>
        private const int _crawlFastMet = 8;

        /// <summary>
        /// Met для На спине
        /// </summary>
        private const int _backstrokeMet = 4;

        /// <summary>
        /// Met для Дельфин
        /// </summary>
        private const int _dolphinMet = 10;

        /// <summary>
        /// Свойство поля стиля плавания
        /// </summary>
        public int Style
        {
            get
            {
                return _style;
            }
            set
            {
                _style = (int)CheckNumberBase(value);
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
                return _style * Time * WeightPerson;
            }
        }

        /// <summary>
        /// Конструктор для инициализации нового экземляра класса Swimming
        /// с указанными параметрами
        /// </summary>
        /// <param name="style">стиль плавания</param>
        /// <param name="distance">дистанция</param>
        public Swimming(int style, double distance, double weightperson, double time)
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
                case 1:
                    Style = _brassMet;
                    break;
                case 2:
                    Style = _crawlModerateMet;
                    break;
                case 3:
                    Style = _crawlFastMet;
                    break;
                case 4:
                    Style = _backstrokeMet;
                    break;
                case 5:
                    Style = _dolphinMet;
                    break;
                default:
                    Style = 0;
                    break;
            }
        }
    }
}
