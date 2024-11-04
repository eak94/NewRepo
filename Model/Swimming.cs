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
                _distance = value;
            }
        }

        /// <summary>
        /// Конструктор для инициализации нового экземляра класса Swimming
        /// с указанными параметрами
        /// </summary>
        /// <param name="style">стиль плавания</param>
        /// <param name="distance">дистанция</param>
        public Swimming(string style, double distance, double weight, double time)
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
                    return 5;
                case "Кроль-умеренный":
                    return 6;
                case "Кроль-быстрый":
                    return 8;
                case "На спине":
                    return 4.5;
                case "Дельфин":
                    return 10;
                default:
                    return 0;
            }
        }
    }
}
