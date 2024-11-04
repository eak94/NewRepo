using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс реализующий вид управжения: бег 
    /// </summary>
    public class Running : ExerciseBase
    {
        /// <summary>
        /// Поле интенсивность в км/ч 
        /// </summary>
        private int intensity;

        /// <summary>
        /// Поле расстояние
        /// </summary>
        private double distance;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Running()
        { }

    }
}
