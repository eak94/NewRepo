using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для генерации случайных данных, 
    /// связанных с расчетом калорий, для различных типов упражнений
    /// </summary>
    public class RandomCallories
    {
        /// <summary>
        /// Экземпляр класса Random 
        /// для генерации случайных чисел
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Минимальный вес для случайной 
        /// генерации в килограммах
        /// </summary>
        private const int _minWeight = 40;

        /// <summary>
        /// Максимальный вес для 
        /// случайной генерации в килограммах
        /// </summary>
        private const int _maxWeight = 150;

        /// <summary>
        /// Минимальное время тренировки в часах
        /// </summary>
        private const double _minTime = 0.5;

        /// <summary>
        /// Максимальное время тренировки в часах
        /// </summary>
        private const double _maxTime = 3.0;

        /// <summary>
        /// Метод для получения случайного значения веса
        /// </summary>
        /// <returns>Случайное значение веса в килограммах в диапазоне
        /// от  _minWeight до _maxWeight</returns>
        public static double GetRandomWeight()
        {
            return Math.Round((double)_random.Next(_minWeight, _maxWeight + 1));
        }

        /// <summary>
        /// Метод для получения случайного времени тренировки
        /// </summary>
        /// <returns>Случайное значение времени тренировки в часах
        /// в диапазоне от _minTime до _maxTime</returns>
        public static double GetRandomTime()
        {
            double time = _random.NextDouble() * (_maxTime - _minTime) + _minTime;
            return Math.Round(time);
        }

        /// <summary>
        /// Метод для получения случайной интенсивности бега
        /// </summary>
        /// <returns>Случайное значение интенсивности бега 
        /// в диапазоне от 5 до 20 км/ч.</returns>
        public static double GetRandomRunningIntensity()
        {
            return Math.Round((double)_random.Next(5, 21));
        }

        /// <summary>
        /// Метод для получения случайной дистанции плавания
        /// </summary>
        /// <returns>Случайное значение дистанции 
        /// плавания в метрах от 100 до 2000 метров</returns>
        public static double GetRandomSwimmingDistance()
        {
            return Math.Round((double)_random.Next(100, 2001));
        }

        /// <summary>
        /// Метод для получения случайного стиля плавания
        /// </summary>
        /// <returns>Случайное значение из
        /// перечисления SwimmingStyle</returns>
        public static SwimmingStyle GetRandomSwimmingStyle()
        {
            var styles = Enum.GetValues(typeof(SwimmingStyle));
            return (SwimmingStyle)styles.GetValue(_random.Next(styles.Length));
        }

        /// <summary>
        /// Метод для получения случайного рабочего
        /// веса для тренировки с тяжестями
        /// </summary>
        /// <returns>Случайное значение рабочего
        /// веса в килограммах от 40 до 100 кг</returns>
        public static double GetRandomWeightLiftingWorkingWeight()
        {
            return Math.Round((double)_random.Next(40, 101));
        }

        /// <summary>
        /// Метод для получения случайного 
        /// максимального веса для тренировки с тяжестями
        /// </summary>
        /// <returns>Случайное значение максимального 
        /// веса в килограммах от 100 до 200 кг</returns>
        public static double GetRandomWeightLiftingMaxWeight()
        {
            return Math.Round((double)_random.Next(100, 201));
        }

        /// <summary>
        /// Метод для получения случайного количества
        /// повторений при тренировке с тяжестями
        /// </summary>
        /// <returns>Случайное количество 
        /// повторений в диапазоне от 5 до 20/returns>
        public static int GetRandomRepetitions()
        {
            return _random.Next(5, 21);
        }

        /// <summary>
        /// Метод для генерации случайного 
        /// упражнения с соответствующими данными
        /// </summary>
        /// <returns>Случайное упражнение</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static ExerciseBase GetRandomExercise()
        {
            int exerciseType = _random.Next(0, 3); 

            double weight = GetRandomWeight();
            double time = GetRandomTime();

            switch (exerciseType)
            {
                case 0:
                {
                    double intensity = GetRandomRunningIntensity();
                    double distance = _random.Next(1000, 5000);
                    return new Running((int)intensity, distance, weight, time);
                }
                case 1:
                {
                    SwimmingStyle style = GetRandomSwimmingStyle();
                    double swimmingDistance = GetRandomSwimmingDistance();
                    return new Swimming(style, swimmingDistance, weight, time);
                }
                case 2:
                {
                    double workingWeight = GetRandomWeightLiftingWorkingWeight();
                    double maxWeight = GetRandomWeightLiftingMaxWeight();
                    int repetitions = GetRandomRepetitions();
                    return new WeightLifting(workingWeight, repetitions, maxWeight, weight, time);
                }
                default:
                    throw new InvalidOperationException("Неверный тип упражнения");
            }
        }
    }
}
