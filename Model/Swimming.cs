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
        public Swimming(string style, double distance)
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
