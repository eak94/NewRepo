namespace Model
{
    /// <summary>
    /// Класс реализующий вид управжения: плавание 
    /// </summary>
    public class Swimming : ExerciseBase
    {

        // Брасс: 5 MET
        // Кроль на груди(умеренный темп) : 6 MET
        // Кроль на груди(быстрый темп) : 8 MET
        // На спине: 4.5 MET
        // Дельфин: 10 MET
        //Допустим, ваш вес 70 кг, вы проплыли 1 км в стиле кроль с умеренной
        //интенсивностью (MET = 9), и вы сделали это за 30 минут (0.5 часа).

        //Калории = 9(МЕТ) * 70(вес) *0.5(время) = 315 

        /// <summary>
        /// Поле стиль плавания
        /// </summary>
        private string _style;

        /// <summary>
        /// Поле дистанция 
        /// </summary>
        private double _distance;

        /// <summary>
        /// Met для Брасс
        /// </summary>
        private const double _brassMet = 5;

        /// <summary>
        /// Met для Кроль-умеренный
        /// </summary>
        private const double _crawlModerateMet = 6;

        /// <summary>
        /// Met для Кроль-быстрый
        /// </summary>
        private const double _crawlFastMet = 8;

        /// <summary>
        /// Met для На спине
        /// </summary>
        private const double _backstrokeMet = 4.5;

        /// <summary>
        /// Met для Дельфин
        /// </summary>
        private const double _dolphinMet = 10;

        /// <summary>
        /// Свойство поля стиля плавания
        /// </summary>
        public string Style
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value;
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
                _distance = CheckNumber(value);
            }
        }

        /// <summary>
        /// Конструктор для инициализации нового экземляра класса Swimming
        /// с указанными параметрами
        /// </summary>
        /// <param name="style">стиль плавания</param>
        /// <param name="distance">дистанция</param>
        public Swimming(string style, double distance)
            : base(double weight, double time)
        {
            Style = style;
            Distance = distance;
            Weight = weight;
            Time = time;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Swimming()
        { }

        /// <summary>
        /// Метод для расчета каллорий при плавании 
        /// </summary>
        public override void CalculateCalories()
        {
            double met = CalculateMetValue(Style);
            caloriesBurned = met * Weight * Time;
        }

        /// <summary>
        /// Метод для опрееделения Met
        /// </summary>
        /// <param name="style">стиль плавания</param>
        /// <returns></returns>
        private double CalculateMetValue(string style)
        {
            switch (style)
            {
                case "Брасс":
                    return _brassMet;
                case "Кроль-умеренный":
                    return _crawlModerateMet;
                case "Кроль-быстрый":
                    return _crawlFastMet;
                case "На спине":
                    return _backstrokeMet;
                case "Дельфин":
                    return _dolphinMet;
                default:
                    return 0;
            }
        }
    }
}
