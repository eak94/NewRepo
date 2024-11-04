using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс реализующий вид управжения: жим штанги
    /// </summary>
    public class WeightLifting : ExerciseBase
    {
        /// <summary>
        /// Поле вес 
        /// </summary>
        private double weight;

        /// <summary>
        /// Поле количество повторений
        /// </summary>
        private int repetitions;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public WeightLifting()
        { }
    }
}
