namespace Model
{
    /// <summary>
    /// Класс реализующий вид управжения: жим штанги
    /// </summary>
    public class WeightLifting : ExerciseBase
    {
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
        private const int _metSlow = 3;

        /// <summary>
        /// MET=5 при умеренных весах
        /// </summary>
        private const int _metModerate = 5;

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
                _workingweight = CheckNumberBase(value);
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
                _repetitions = (int)CheckNumberBase(value);
            }
        }

        /// <summary>
        /// Свойство поля количество повторений
        /// </summary>
        public double MaxWeight
        {
            get
            {
                return _maxweight;
            }
            set
            {
                _maxweight = CheckNumberBase(value);
            }
        }

        /// <summary>
        /// Метод для расчета каллорий для жима штанги
        /// </summary>
        public override double CalculateCalories
        {
            get
            {
                double met = CalculateMet(WorkingWeight, MaxWeight);
                return met * Time * WeightPerson;
            }
        }

        /// <summary>
        /// Конструктор для инициализации нового экземляра
        /// класса тяжелая атлетика(жим штанги)
        /// с указанными параметрами
        /// </summary>
        /// <param name="weight">вес</param>
        /// <param name="repetitions">количество повторений</param>
        public WeightLifting(double workingweightt, int repetitions,
            double maxweight, double weightperson, double time) : base(weightperson, time)
        {
            WorkingWeight = workingweightt;
            Repetitions = repetitions;
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
        public double CalculateMet(double workingWeight, double maxWeight)
        {
            double weightPercentage = workingWeight / maxWeight * 100;

            if (weightPercentage >= 80)
            {
                return _metSlow;
            }
            else if (weightPercentage >= 60)
            {
                return _metModerate;
            }
            else
            {
                return _metSlow;
            }
        }
    }
}
