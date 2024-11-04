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

        //Допустим, ваш вес составляет 70 кг, вы делаете жим штанги с умеренными
        //весами(MET = 5), и ваша тренировка занимает 10 минут(или 0.167 часа)

        //Калории = 5 *70*0.167 = 58.5

        /// <summary>
        /// Поле вес во время тренировки
        /// </summary>
        private double _workingweight;

        /// <summary>
        /// Поле максимальный вес, который может сделать человек за 1 повторение
        /// </summary>
        private double _maxweight;

        /// <summary>
        /// Поле количество повторений
        /// </summary>
        private int _repetitions;

        /// <summary>
        /// MET=3 при легких весах
        /// </summary>
        private const int MetSlow = 3;

        /// <summary>
        /// MET=5 при умеренных весах
        /// </summary>
        private const int MetModerate = 5;

        /// <summary>
        /// MET=6 при тяжелых весах
        /// </summary>
        private const int MetFast = 6;

        /// <summary>
        /// Свойство поля вес 
        /// </summary>
        public double WorkingWeight
        {
            get
            {
                return _workingweight;
            }
            set
            {
                _workingweight = value;
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
        /// Свойство поля количество повторений
        /// </summary>
        public int MaxWeight
        {
            get
            {
                return _maxweight;
            }
            set
            {
                _maxweight = value;
            }
        }

        /// <summary>
        /// Конструктор для инициализации нового экземляра класса WeightLifting
        /// с указанными параметрами
        /// </summary>
        /// <param name="weight">вес</param>
        /// <param name="repetitions">количество повторений</param>
        public WeightLifting(double workingweightt, int repetitions, double weight, double time, double maxweight)
        {
            WorkingWeight = workingweight;
            Repetitions = repetitions;
            Weight = weight;
            Time = time;
            MaxWeight = maxweight;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public WeightLifting()
        { }

        /// <summary>
        /// Метод для рассчета MET
        /// </summary>
        public void CalculateMet()
        {
            double weightPercentage = _workingWeight / _maxWeight * 100;

            if (weightPercentage >= 80)
            {
                return MetSlow;
            }
            else if (weightPercentage >= 60)
            {
                return MetModerate;
            }
            else
            {
                return MetSlow;
            }
        }

        /// <summary>
        /// Метод для расчета каллорий при жиме 
        /// </summary>
        public override void CalculateCalories()
        {
            double met = CalculateMet(WorkingWeight);
            caloriesBurned = met * Weight * Time;
        }
    }
}
