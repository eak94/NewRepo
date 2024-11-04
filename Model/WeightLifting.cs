namespace Model
{
    /// <summary>
    /// Класс реализующий вид управжения: жим штанги
    /// </summary>
    public class WeightLifting : ExerciseBase
    {
        //Метаболический эквивалент(MET) для жима штанги составляет примерно 3-6 MET
        //в зависимости от интенсивности тренировки.Для силовых тренировок,
        //таких как жим штанги, можно использовать значение около 5 MET
        //для умеренной интенсивности.
        //- Легкие веса, медленный темп: около 3-4 MET
        //- Умеренные веса: около 5 MET
        //- Тяжелые веса: около 6 MET

        //Если вы делаете 3 подхода по 10 повторений и каждый подход занимает
        //1 минуту, общее время тренировки составит 3 минуты(или 0.05 часа)

        //Допустим, ваш вес составляет 70 кг, вы делаете жим штанги с умеренными
        //весами(MET = 5), и ваша тренировка занимает 10 минут(или 0.167 часа)

        //Калории = 5 *70*0.167 = 58.5

        /// <summary>
        /// Поле вес 
        /// </summary>
        private double _weight;

        /// <summary>
        /// Поле количество повторений
        /// </summary>
        private int _repetitions;

        /// <summary>
        /// Свойство поля вес 
        /// </summary>
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        /// <summary>
        /// Свойство поля количество повторений
        /// </summary>
        public int Repetitions
        {
            get
            {
                return _repetitions;
            }
            set
            {
                _repetitions = value;
            }
        }

        /// <summary>
        /// Конструктор для инициализации нового экземляра класса WeightLifting
        /// с указанными параметрами
        /// </summary>
        /// <param name="weight">вес</param>
        /// <param name="repetitions">количество повторений</param>
        public WeightLifting(double weight, int repetitions)
        {
            Weight = weight;
            Repetitions = repetitions;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public WeightLifting()
        { }
    }
}
